using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestingApp.Data;
using TestingApp.Models;
using TestingApp.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TestingAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TestingAppContext") ?? throw new InvalidOperationException("Connection string 'TestingAppContext' not found.")));

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IPlanningRepository, PlanningRepository>();

var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;

//    SeedData.Initialize(services);
//}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
