using FoodTruck.Models.View;
using FoodTruck.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodTruck.Controllers;

[Route("pizza")]
public class PizzaMenu : Controller
{
    private readonly PizzaChef _pizzaChef;

    public PizzaMenu(PizzaChef pizzaChef)
    {
        _pizzaChef = pizzaChef;
    }

    [HttpGet("hawaiian")]
    public IActionResult HawaiianRecipe()
    {
        return View("~/Views/Pizza/Base.cshtml", new IngredientsBowl
        {
            Ingredients = _pizzaChef.PrepareHawaiianIngredients(),
        });
    }

    [HttpGet("margherita")]
    public IActionResult MargheritaRecipe()
    {
        return View("~/Views/Pizza/Base.cshtml", new IngredientsBowl
        {
            Ingredients = _pizzaChef.PrepareMargheritaIngredients(),
        });
    }

    [HttpGet("pepperoni")]
    public IActionResult PepperoniRecipe()
    {
        return View("~/Views/Pizza/Base.cshtml", new IngredientsBowl
        {
            Ingredients = _pizzaChef.PreparePepperoniIngredients(),
        });
    }
}
