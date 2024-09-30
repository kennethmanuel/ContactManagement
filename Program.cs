using MudBlazor.Services;
using ContactManagement.Components;
using ContactManagement.Models;
using ContactManagement.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor services
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<IContactService, ContactService>();

string? CONNECTION_STRING = builder.Configuration.GetConnectionString("IntranetHomeContext");
ServerVersion serverVersion = ServerVersion.AutoDetect(CONNECTION_STRING);

builder.Services.AddDbContextFactory<IntranetHomeContext>(
    opt => opt.UseMySql(CONNECTION_STRING, serverVersion)
);

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
