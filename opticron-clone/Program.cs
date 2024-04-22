using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using opticron_clone.Data;
using opticron_clone.Models;

var builder = WebApplication.CreateBuilder(args);

// Get and assign connection string for feature model context
builder.Services.AddDbContext<FeatureModelContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("FeatureModelContext") ?? throw new InvalidOperationException("Connection string 'FeatureModelContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
