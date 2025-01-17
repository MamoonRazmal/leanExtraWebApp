using leanExtraWebApp.Components;
using leanExtraWebApp.Data;
using leanExtraWebApp.Models;
using leanExtraWebApp.StateStore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<ServerManagmentContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("ServerManagement"))
);
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
    builder.Services.AddTransient<SessionStorage>();
    builder.Services.AddScoped<ContainerStorage>();
    builder.Services.AddScoped<TorontoOnlineStorage>();
    builder.Services.AddTransient<IServersEFCoreRepository,ServersEFCoreRepository>();

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
    .AddInteractiveServerRenderMode();

app.Run();
