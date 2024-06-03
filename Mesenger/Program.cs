using Messenger.Services;
using Mesenger.Components;
using Microsoft.AspNetCore.Components;

var builder = WebApplication.CreateBuilder(args);

// Register the shared registration service
builder.Services.AddSingleton<RegistrationService>();

// Add services to the container
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();