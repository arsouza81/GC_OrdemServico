using AutoMapper;
using HandlebarsDotNet;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using OrdemDeServico.Data;
using OrdemDeServico.Dtos;
using OrdemDeServico.Models;
using System.Security.Claims;

namespace OrdemDeServico.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase {

    private OrdemContext _context;
    private IMapper _mapper;

    public UserController(OrdemContext context, IMapper mapper) {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult PostUser([FromBody] CreateUserDto userDto) {
        User user = _mapper.Map<User>(userDto);
        _context.Users.Add(user);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetUserPorId), new { id = user.Id }, user);
    }

    [HttpGet("{id}")]
    public IActionResult GetUserPorId(int id) {
        var user = _context.Users.FirstOrDefault(user => user.Id == id);
        if(user == null) return NotFound();
        return Ok(user);
    }

    [HttpGet]
    public IEnumerable<ReadUserDto> GetUsers() { 
        return _mapper.Map<List<ReadUserDto>>(_context.Users).ToList();
    }

    [HttpDelete]
    public IActionResult DeleteUser(int id) {
        var user = _context.Users.FirstOrDefault(user => user.Id == id);
        if(user == null) return NotFound();
        _context.Remove(user);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromForm] LoginDto loginDto) {
        // Lógica de autenticação
        var user = _context.Users.FirstOrDefault(u => u.Email == loginDto.Email && u.Password == loginDto.Password);

        if (user != null) {
            // Criar as reivindicações do usuário
            var claims = new List<Claim>
            {
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Name, user.Name)
            // Adicione mais reivindicações conforme necessário
        };

            // Criar identidade e autenticar o usuário
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            // Fazer login e armazenar o usuário na sessão
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            // Redirecionar para a página de gerente se o login for bem-sucedido
            return RedirectToAction("IndexGerente", "Pagina");
        }

        // Redirecionar para a página de login com um parâmetro de erro
        return RedirectToAction("Login", "Pagina", new { erro = "Credenciais inválidas" });
    }

    [HttpGet("logout")]
    public IActionResult Logout() {
        // Limpar o cookie de autenticação
        HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        // Redirecionar para a página inicial
        return RedirectToAction("Index", "Pagina");
    }

    [HttpGet("selecionar_data")]
    public IActionResult SelecionarData(string data_solicitacao) {
        // Exibe a data fornecida pelo usuário
        Console.WriteLine($"Data fornecida pelo usuário: {data_solicitacao}");

        // Verifica se a data foi fornecida
        if (string.IsNullOrEmpty(data_solicitacao)) {
            Console.WriteLine("Data não fornecida.");
            return RedirectToAction("IndexGerente");
        }

        // Tenta converter a data fornecida em um formato válido
        if (!DateTime.TryParseExact(data_solicitacao, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out var dataSolicitacao)) {
            Console.WriteLine($"Data inválida: {data_solicitacao}");
            return Content("Data inválida", "text/html");
        }

        Console.WriteLine($"Data convertida para comparação: {dataSolicitacao.ToString("yyyy-MM-dd")}");

        // Consulta as solicitações com base na data
        var solicitacoes = _context.FormsServidores
            .Where(f => f.Data_Solicitacao.Date == dataSolicitacao.Date)
            .Select(f => new SolicitacaoDto {
                Id = f.Id,
                Nome = f.Nome,
                DataSolicitacao = f.Data_Solicitacao.ToString("dd/MM/yyyy HH:mm:ss")
            })
            .ToList();


        // Exibe as solicitações encontradas no console
        Console.WriteLine($"Número de solicitações encontradas: {solicitacoes.Count}");
        foreach (var solicitacao in solicitacoes) {
            Console.WriteLine($"ID: {solicitacao.Id}, Nome: {solicitacao.Nome}, Data da Solicitação: {solicitacao.DataSolicitacao}");
        }

        // Caminho para os arquivos do template e layout Handlebars
        var layoutPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "Layouts", "main.hbs");
        var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "solicitacoes.hbs");

        // Verifica se os arquivos do layout e template existem
        if (!System.IO.File.Exists(layoutPath) || !System.IO.File.Exists(templatePath)) {
            return Content("Templates não encontrados", "text/html");
        }

        // Carrega o conteúdo dos arquivos
        var layoutContent = System.IO.File.ReadAllText(layoutPath);
        var templateContent = System.IO.File.ReadAllText(templatePath);

        // Compila o layout e o template Handlebars
        var layoutTemplate = Handlebars.Compile(layoutContent);
        var contentTemplate = Handlebars.Compile(templateContent);

        // Dados que serão passados para o template
        var data = new SolicitacoesPageDto {
            Title = "Solicitações do Dia",
            DiaSelecionado = dataSolicitacao.ToString("dd/MM/yyyy"),
            NomesEIds = solicitacoes // Aqui passamos a lista de solicitações
        };
        Console.WriteLine("Solicitações:");
        foreach (var solicitacao in data.NomesEIds) {
            Console.WriteLine($"ID: {solicitacao.Id}, Nome: {solicitacao.Nome}, Data: {solicitacao.DataSolicitacao}");
        }


        // Renderiza o conteúdo da página usando o template Handlebars
        var contentHtml = contentTemplate(data);
        var result = layoutTemplate(new { BodyContent = contentHtml });

        // Retorna o conteúdo HTML renderizado
        return Content(result, "text/html");
    }

    [HttpGet("detalhes_solicitacao/{id}")]
    public IActionResult DetalhesSolicitacao(int id) {
        // Buscar a solicitação no banco de dados
        var solicitacao = _context.FormsServidores
            .Where(s => s.Id == id)
            .Select(s => new ReadFormServidorDto {
                Nome = s.Nome,
                Email = s.Email, // Assumindo que Email é uma propriedade do seu modelo
                Siape = s.Siape, // Assumindo que Siape é uma propriedade do seu modelo
                Bloco = s.Bloco, // Assumindo que Bloco é uma propriedade do seu modelo
                Sala = s.Sala, // Assumindo que Sala é uma propriedade do seu modelo
                DescricaoProblema = s.DescricaoProblema, // Assumindo que DescricaoProblema é uma propriedade do seu modelo
                Status = s.Status, // Assumindo que Status é uma propriedade do seu modelo
                Protocolo = s.Protocolo // Assumindo que Protocolo é uma propriedade do seu modelo
            })
            .FirstOrDefault();

        if (solicitacao == null) {
            return NotFound(); // Retorna um erro 404 se a solicitação não for encontrada
        }

        // Passar os dados para a página Handlebars
        var model = new {
            solicitacao
        };

        // Renderize a página com Handlebars
        var layoutPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "Layouts", "main.hbs");
        var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "detalhes_solicitacao.hbs");
        var partialPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "Partials", "mensagens.hbs");

        // Verifique se os arquivos existem
        if (!System.IO.File.Exists(layoutPath) || !System.IO.File.Exists(templatePath) || !System.IO.File.Exists(partialPath)) {
            return Content("Templates não encontrados", "text/html");
        }

        // Carregar e registrar o partial
        var partialContent = System.IO.File.ReadAllText(partialPath);
        Handlebars.RegisterTemplate("mensagens", partialContent);

        var layoutContent = System.IO.File.ReadAllText(layoutPath);
        var templateContent = System.IO.File.ReadAllText(templatePath);

        // Compile o layout e o template
        var layoutTemplate = Handlebars.Compile(layoutContent);
        var contentTemplate = Handlebars.Compile(templateContent);

        // Dados a serem passados para o template
        var data = new {
            Title = "Detalhes da Solicitação",
            BodyContent = contentTemplate(model)
        };

        // Renderize o HTML usando o layout
        var result = layoutTemplate(data);

        // Retorne o resultado como conteúdo
        return Content(result, "text/html");
    }

    [HttpPost("/atualizar_status")]
    public IActionResult AtualizarStatus([FromBody] AtualizarStatusDto statusDto) {
        // Atualizar o status no banco de dados com base no protocolo e novoStatus fornecidos
        var solicitacao = _context.FormsServidores
            .FirstOrDefault(s => s.Protocolo == statusDto.Protocolo);

        if (solicitacao != null) {
            solicitacao.Status = statusDto.NovoStatus;
            _context.SaveChanges();
            return Ok(); // Retorna uma resposta de sucesso
        }

        return NotFound(); // Retorna um erro 404 se a solicitação não for encontrada
    }


}
