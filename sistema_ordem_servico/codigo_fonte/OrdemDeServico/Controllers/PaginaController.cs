using Microsoft.AspNetCore.Mvc;
using HandlebarsDotNet;
using System.IO;
using Microsoft.EntityFrameworkCore;
using OrdemDeServico.Data;

public class PaginaController : ControllerBase {

    [HttpGet]
    public IActionResult Index() {
        // Caminho para o layout e template Handlebars
        var layoutPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "Layouts", "main.hbs");
        var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "index.hbs");
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
            Title = "Página Inicial",
            Mensagem = "Bem-vindo ao nosso site!",
            Nome = "Usuário",
            BodyContent = contentTemplate(new { /* Dados específicos para index.hbs */ })
        };

        // Renderize o HTML usando o layout
        var result = layoutTemplate(data);

        // Retorne o resultado como conteúdo
        return Content(result, "text/html");
    }

    [HttpGet]
    [Route("login")]
    public IActionResult Login(string erro)
    {
        // Caminho para o layout e template Handlebars
        var layoutPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "Layouts", "main.hbs");
        var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "login.hbs");

        // Verifique se os arquivos existem
        if (!System.IO.File.Exists(layoutPath) || !System.IO.File.Exists(templatePath))
        {
            return Content("Templates não encontrados", "text/html");
        }

        // Carregar o conteúdo dos arquivos
        var layoutContent = System.IO.File.ReadAllText(layoutPath);
        var templateContent = System.IO.File.ReadAllText(templatePath);

        // Compile o layout e o template
        var layoutTemplate = Handlebars.Compile(layoutContent);
        var contentTemplate = Handlebars.Compile(templateContent);

        // Dados a serem passados para o template
        var data = new
        {
            Title = "Login",
            Mensagem = erro, // Passa o parâmetro de erro para o template
            Nome = "Usuário",
            BodyContent = contentTemplate(new { erro = erro }) // Passa o erro também para o conteúdo do template
        };

        // Renderize o HTML usando o layout
        var result = layoutTemplate(data);

        // Retorne o resultado como conteúdo
        return Content(result, "text/html");
    }

    [HttpGet]
    [Route("index_gerente")]
    public IActionResult IndexGerente() {
        // Caminho para o layout e template Handlebars
        var layoutPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "Layouts", "main.hbs");
        var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "index_gerente.hbs");
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
            Title = "Index Gerente",
            Mensagem = "Bem vindo.",
            Nome = "Usuário",
            BodyContent = contentTemplate(new { /* Dados específicos para index_gerente.hbs */ })
        };

        // Renderize o HTML usando o layout
        var result = layoutTemplate(data);

        // Retorne o resultado como conteúdo
        return Content(result, "text/html");
    }

    [HttpGet]
    [Route("solicitacao")]
    public IActionResult Solicitacao() {
        // Caminho para o layout e template Handlebars
        var layoutPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "Layouts", "main.hbs");
        var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "solicitacao.hbs");
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
            Title = "Solicitacao",
            Mensagem = "Bem vindo.",
            Nome = "Usuário",
            BodyContent = contentTemplate(new { /* Dados específicos para solicitacao.hbs */ })
        };

        // Renderize o HTML usando o layout
        var result = layoutTemplate(data);

        // Retorne o resultado como conteúdo
        return Content(result, "text/html");
    }

    [HttpGet]
    [Route("solicitacoes")]
    public IActionResult Solicitacoes() {
        // Caminho para o layout e template Handlebars
        var layoutPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "Layouts", "main.hbs");
        var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "solicitacoes.hbs");
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
            Title = "Solicitacoes",
            Mensagem = "Bem vindo.",
            Nome = "Usuário",
            BodyContent = contentTemplate(new { /* Dados específicos para solicitacoes.hbs */ })
        };

        // Renderize o HTML usando o layout
        var result = layoutTemplate(data);

        // Retorne o resultado como conteúdo
        return Content(result, "text/html");
    }

    [HttpGet]
    [Route("detalhes_solicitacao/{id}")]
    public IActionResult DetalhesSolicitacao(int id) {
        // Caminho para o layout e template Handlebars
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
            Mensagem = "Detalhes da solicitação",
            Nome = "Usuário",
            BodyContent = contentTemplate(new { /* Dados específicos para detalhes_solicitacao.hbs */ })
        };

        // Renderize o HTML usando o layout
        var result = layoutTemplate(data);

        // Retorne o resultado como conteúdo
        return Content(result, "text/html");
    }
}
