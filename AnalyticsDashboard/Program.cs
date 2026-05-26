using AnalyticsDashboard;
using AnalyticsDashboard.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Registrar el servicio de API
builder.Services.AddScoped<ApiService>();

// Configurar HttpClient para llamar a la API
builder.Services.AddHttpClient<ApiService>(client =>
{
    // URL de la API (ajustar según donde esté corriendo)
    client.BaseAddress = new Uri("https://localhost:7214/");
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

// Registrar el servicio de estado del dashboard
builder.Services.AddScoped<DashboardState>();

// Agregar logging
builder.Services.AddLogging();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();