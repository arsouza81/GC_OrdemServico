﻿using AutoMapper;
using HandlebarsDotNet;
using Microsoft.AspNetCore.Mvc;
using OrdemDeServico.Data;
using OrdemDeServico.Dtos;
using OrdemDeServico.Models;
using OrdemDeServico.Services;

namespace OrdemDeServico.Controllers;

[ApiController]
[Route("[controller]")]
public class FormServidorController : ControllerBase {

    private OrdemContext _context;
    private IMapper _mapper;
    private readonly IEmailSender _emailSender;

    public FormServidorController(OrdemContext context, IMapper mapper, IEmailSender emailSender) {
        _context = context;
        _mapper = mapper;
        _emailSender = emailSender;
    }

    [HttpPost]
    public IActionResult PostFormServidor([FromBody] CreateFormServidorDto formServidorDto) {
        FormServidor formServidor = _mapper.Map<FormServidor>(formServidorDto);
        _context.FormsServidores.Add(formServidor);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetFormServidorPorId), new { id = formServidor.Id }, formServidor);
    }

    [HttpGet("{id}")]
    public IActionResult GetFormServidorPorId(int id) {
        var formServidor = _context.FormsServidores.FirstOrDefault(formServidor => formServidor.Id == id);
        if(formServidor == null) return NotFound();
        return Ok(formServidor);
    }

    [HttpGet]
    public IEnumerable<ReadFormServidorDto> GetFormServidor() {
        return _mapper.Map<List<ReadFormServidorDto>>(_context.FormsServidores).ToList();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteFormServidor(int id) {
        var formServidor = _context.FormsServidores.FirstOrDefault(formServidor => formServidor.Id == id);
        if(formServidor == null) return NotFound();
        _context.Remove(formServidor);
        _context.SaveChanges();
        return NoContent();
    }

        [HttpGet("buscar_protocolo")]
        public IActionResult BuscarProtocolo(string? protocolo) {
            // Verificar se o protocolo foi fornecido
            if (string.IsNullOrEmpty(protocolo)) {
                var script = @"
                <html>
                <head>
                    <meta charset=""UTF-8"">
                    <title>Erro</title>
                </head>
                <body>
                    <script>
                        alert('O protocolo não pode estar vazio');
                        window.location.href = '/Pagina/Index'; // Redireciona para a página inicial ou outra página de sua escolha
                    </script>
                </body>
                </html>";

                return Content(script, "text/html");
            }

            // Buscar o protocolo no banco de dados
            var formulario = _context.FormsServidores
                .FirstOrDefault(f => f.Protocolo == protocolo);

            if (formulario == null) {
                var script = @"
                <html>
                <head>
                    <meta charset=""UTF-8"">
                    <title>Erro</title>
                </head>
                <body>
                    <script>
                        alert('Protocolo não encontrado');
                        window.location.href = '/Pagina/Index'; // Redireciona para a página inicial ou outra página de sua escolha
                    </script>
                </body>
                </html>";

                return Content(script, "text/html");
            }

            // Caminho para o layout e template Handlebars
            var layoutPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "Layouts", "main.hbs");
            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "solicitacao.hbs");

            // Verifique se os arquivos existem
            if (!System.IO.File.Exists(layoutPath) || !System.IO.File.Exists(templatePath)) {
                return Content("Templates não encontrados", "text/html");
            }

            // Carregar e registrar o partial
            var layoutContent = System.IO.File.ReadAllText(layoutPath);
            var templateContent = System.IO.File.ReadAllText(templatePath);

            // Compile o layout e o template
            var layoutTemplate = Handlebars.Compile(layoutContent);
            var contentTemplate = Handlebars.Compile(templateContent);

            // Dados a serem passados para o template
            var data = new {
                Title = "Detalhes da Solicitação",
                Mensagem = "Aqui estão os detalhes da sua solicitação.",
                Nome = "Usuário",
                BodyContent = contentTemplate(new { protocoloEncontrado = formulario })
            };

            // Renderize o HTML usando o layout
            var result = layoutTemplate(data);

            // Retorne o resultado como conteúdo
            return Content(result, "text/html");
        }

    [HttpPost("formulario")]
    public async Task<IActionResult> PostFormulario([FromForm] CreateFormServidorDto formDto) {
        //Validar se o SIAPE possui 7 dígitos
        if (formDto.Siape.ToString().Length != 7 || !formDto.Siape.ToString().All(char.IsDigit)) {
            var errorMessage = "O SIAPE deve ter 7 digitos";
            return Content($@"
            <script>
                alert('{errorMessage}');
                window.location.href = '{Url.Action("Index", "Pagina")}';
            </script>", "text/html");
        }

        if(formDto.DescricaoProblema.ToString().Length>600) {
            var errorMessage = "A descricao nao pode passar dos 600 caracteres.";

            return Content($@"
        <script>
            alert('{errorMessage}');
            window.location.href = '{Url.Action("Index", "Pagina")}'; // Redireciona para a página inicial
        </script>", "text/html");
        }

        if (!ModelState.IsValid) {
            return BadRequest(ModelState);
        }

        var formulario = new FormServidor {
            Nome = formDto.Nome,
            Email = formDto.Email,
            Siape = formDto.Siape,
            Bloco = formDto.Bloco,
            Sala = formDto.Sala,
            DescricaoProblema = formDto.DescricaoProblema,
            Data_Solicitacao = formDto.Data_Solicitacao,
            Status = "em_andamento",
            Protocolo = GenerateUniqueProtocolo()
        };

        _context.FormsServidores.Add(formulario);
        await _context.SaveChangesAsync();

        // Enviar e-mail para o e-mail fornecido no formulário
        if (IsValidEmail(formulario.Email)) {
            await _emailSender.SendEmailAsync(
                formulario.Email,
                "Sua Ordem de Serviço Recebida",
                $"Sua ordem de serviço foi recebida com o protocolo: {formulario.Protocolo}. Estamos trabalhando nisso.");
        } else {
            // Log ou tome uma ação apropriada
            return BadRequest("O endereço de e-mail fornecido é inválido.");
        }


        // Enviar e-mail para todos os usuários registrados
        var users = _context.Users.ToList();
        foreach (var user in users) {
            if (IsValidEmail(user.Email)) {
                await _emailSender.SendEmailAsync(
                    user.Email,
                    "Nova Ordem de Serviço Recebida",
                    $"Uma nova ordem de serviço foi criada com o protocolo: {formulario.Protocolo}.<br>" +
                    $"Nome: {formulario.Nome}<br>" +
                    $"Bloco: {formulario.Bloco}<br>" +
                    $"Sala: {formulario.Sala}<br>" +
                    $"Descrição: {formulario.DescricaoProblema}<br>");
            } else {
                // Log ou ignore o e-mail inválido
                Console.WriteLine($"E-mail inválido encontrado: {user.Email}");
            }
        }

        var alertMessage = "E-mail enviado com sucesso!.";
        var redirectUrl = Url.Action("Index", "Pagina");

        return Content($@"
        <script>
            alert('{alertMessage}');
            window.location.href = '{redirectUrl}';
        </script>", "text/html");
    }

    private string GenerateUniqueProtocolo() {
        var random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        string protocolo;

        do {
            protocolo = new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        } while (_context.FormsServidores.Any(f => f.Protocolo == protocolo));

        return protocolo;
    }

    private static bool IsValidEmail(string email) {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        try {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase);
        } catch {
            return false;
        }
    }
}