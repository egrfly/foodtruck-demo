using FoodTruck.Models.View;
using FoodTruck.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodTruck.Controllers;

[Route("pasta")]
public class PastaMenu : Controller
{
    private readonly PastaChef _pastaChef;

    public PastaMenu(PastaChef pastaChef)
    {
        _pastaChef = pastaChef;
    }

    [HttpGet("arrabbiata")]
    public IActionResult ArrabbiataRecipe()
    {
        return View("~/Views/Pasta/Base.cshtml", new IngredientsBowl
        {
            Ingredients = _pastaChef.PrepareArrabbiataIngredients(),
        });
    }

    [HttpGet("bolognese")]
    public IActionResult BologneseRecipe()
    {
        return View("~/Views/Pasta/Base.cshtml", new IngredientsBowl
        {
            Ingredients = _pastaChef.PrepareBologneseIngredients(),
        });
    }

    [HttpGet("carbonara")]
    public IActionResult CarbonaraRecipe()
    {
        return View("~/Views/Pasta/Base.cshtml", new IngredientsBowl
        {
            Ingredients = _pastaChef.PrepareCarbonaraIngredients(),
        });
    }
}
