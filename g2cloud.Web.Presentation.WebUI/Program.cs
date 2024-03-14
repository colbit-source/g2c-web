using Microsoft.EntityFrameworkCore;

using g2cloud.Web.Presentation.WebUI.Components;
using g2cloud.Web.Application.WebUI.Mediators;
using g2cloud.Web.Infrastructure.GestFact.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(); /* Para realizar llamadas asíncronas por websockets */

builder.Services.AddDbContext<GestFactContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("GestFactConnectionString"), o => o.UseCompatibilityLevel(120))); /* Get Static ConnectionString (appsettings.json) */

/* Inyección de dependencias */
builder.Services.AddScoped<INavigationMediator, NavigationMediator>();
builder.Services.AddScoped<IContentMediator, ContentMediator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode(); /* Para realizar llamadas asíncronas por websockets */

app.Run();