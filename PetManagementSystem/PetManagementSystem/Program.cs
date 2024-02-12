using PetManagemenSystem.WrapperService.Interfaces;
using PetManagementSystem.Components;
using PetManagementSystem.WrapperService.Implementation;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

//API Base address
string apiBaseAddress = "https://localhost:7251/";

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSyncfusionBlazor();

builder.Services.AddHttpClient<IPersonsGetter, PersonsGetter>(client =>
{
    client.BaseAddress = new Uri(apiBaseAddress);
});
builder.Services.AddHttpClient<ISpeciesGetter, SpeciesGetter>(client =>
{
    client.BaseAddress = new Uri(apiBaseAddress);
});
builder.Services.AddHttpClient<IPetOwnerGetter, PetOwnerGetter>(client =>
{
    client.BaseAddress = new Uri(apiBaseAddress);
});
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
