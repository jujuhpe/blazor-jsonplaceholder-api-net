using BlazorUsersJsonPlaceHolderApi.Components;

var builder = WebApplication.CreateBuilder(args);

// Registra os componentes Blazor e o cliente HTTP.
builder.Services.AddRazorComponents();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configura as páginas e o tratamento de erros.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>();

app.Run();
