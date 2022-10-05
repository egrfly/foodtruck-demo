using FoodTruck;
using FoodTruck.Repositories;
using FoodTruck.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddTransient<PastaChef, Mario>();
builder.Services.AddTransient<PizzaChef, Luigi>();

builder.Services.AddTransient<Cupboard, WoodenCupboardInTheBackLeftCorner>();
builder.Services.AddTransient<Fridge, SilverFridgeInTheBackRightCorner>();

builder.Services.AddDbContext<FoodTruckDbContext>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
