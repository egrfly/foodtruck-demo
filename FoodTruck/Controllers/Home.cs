using System.Collections.Generic;
using FoodTruck.Helpers;
using FoodTruck.Models.View;
using Microsoft.AspNetCore.Mvc;

namespace FoodTruck.Controllers;

[Route("")]
public class Home : Controller
{
    private static readonly IEnumerable<string> PastaRecipes = MenuHelper.GetMenuItems<PastaMenu>();
    private static readonly IEnumerable<string> PizzaRecipes = MenuHelper.GetMenuItems<PizzaMenu>();

    [HttpGet("")]
    public IActionResult Index()
    {
        return View(new MenuItems
        {
            PastaMenuItems = PastaRecipes,
            PizzaMenuItems = PizzaRecipes,
        });
    }
}
