using AspNetCoreIdentity.Areas.Identity.Data;
using AspNetCoreIdentity.Configs;
using AspNetCoreIdentity.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", true, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();

// *** Configurando servi�os no container ***


// Configurando as Claims

builder.Services.AddIdentityConfig(builder.Configuration);

builder.Services.ResolveDependencies();

// Adicionando Autoriza��es personalizadas por policies
 
// Adicionando MVC no pipeline
builder.Services.AddControllersWithViews();

// Adicionando suporte a componentes Razor (ex. Telas do Identity)
builder.Services.AddRazorPages();

var app = builder.Build();


// *** Configurando o resquest dos servi�os no pipeline *** 

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/erro/500");
    app.UseStatusCodePagesWithRedirects("/erro/{0}");
    app.UseHsts();
}

// Redirecionamento para HTTPs
app.UseHttpsRedirection();

// Uso de arquivos est�ticos (ex. CSS, JS)
app.UseStaticFiles();

// Adicionando suporte a rota
app.UseRouting();

// Autenticacao e autoriza��o (Identity)
app.UseAuthentication();
app.UseAuthorization();

// Rota padr�o
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

// Mapeando componentes Razor Pages (ex: Identity)
app.MapRazorPages();

app.Run();