using Invest.Infrastructure.Configurations;
using Invest.Infrastructure.DataAccess;
using Invest.Web.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.Configure<Database>(
    builder.Configuration.GetSection("Database"));

builder.Services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
{
    var dbSettings = serviceProvider.GetRequiredService<IOptions<Database>>().Value;
    options.UseNpgsql(dbSettings.GetConnectionString, x =>
    {
        x.MigrationsAssembly("Invest.Infrastructure");
        x.MigrationsHistoryTable("invest_migrations_history", "DataAccess");
    });
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
