using MudBlazor.Services;
using ContactManagement.Components;
using ContactManagement.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor services
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

const string CONNECTION_STRING = "Server=192.168.106.225;Port=3306;Database=intranet_home;User Id=root;Password=myroot;";
ServerVersion serverVersion = ServerVersion.AutoDetect(CONNECTION_STRING);

builder.Services.AddDbContext<IntranetHomeContext>(
    options => options.UseMySql(CONNECTION_STRING, serverVersion)
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
