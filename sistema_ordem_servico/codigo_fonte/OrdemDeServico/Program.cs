using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using OrdemDeServico.Data;
using System.IO;
using Microsoft.AspNetCore.Authentication.Cookies;
using OrdemDeServico.Services;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("OrdemServicoConnection");

builder.Services.AddDbContext<OrdemContext>(opts =>
    opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Adicionar serviços ao contêiner
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Configurar autenticação com cookies
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => {
        options.LoginPath = "/User/Login";
        options.LogoutPath = "/User/Logout";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30); // Tempo de expiração do cookie
    });

// Adicionar autorização
builder.Services.AddAuthorization();

//email// Adiciona o serviço de e-mail
builder.Services.AddSingleton<IEmailSender, EmailSender>();

var app = builder.Build();

// Configurar o pipeline de requisições HTTP
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Servir arquivos estáticos, como CSS, JS, etc.

// Adicionar autenticação e autorização ao pipeline
app.UseAuthentication();
app.UseAuthorization();

app.UseRouting();

// Configurar o roteamento de controladores
app.MapControllers();

// Configurar a rota padrão do controlador
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pagina}/{action=Index}/{id?}");

app.Run();
