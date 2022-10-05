using System.Collections.Generic;
using FoodTruck.Models.Business;
using FoodTruck.Models.Business.Cupboard;
using FoodTruck.Models.Business.Fridge;
using FoodTruck.Models.Business.Properties;
using FoodTruck.Repositories;

namespace FoodTruck.Services;

public interface PastaChef : Chef
{
    IEnumerable<FoodItem> PrepareArrabbiataIngredients();
    IEnumerable<FoodItem> PrepareBologneseIngredients();
    IEnumerable<FoodItem> PrepareCarbonaraIngredients();
}

public class Mario : PastaChef
{
    private readonly Cupboard _cupboard;
    private readonly Fridge _fridge;

    public Mario(Cupboard cupboard, Fridge fridge)
    {
        _cupboard = cupboard;
        _fridge = fridge;
    }

    public IEnumerable<FoodItem> PrepareArrabbiataIngredients()
    {
        var tomatoSauce = _fridge.RetrieveItem<TomatoSauce>();
        var garlic = _cupboard.RetrieveItem<Garlic>();
        var redChilli = _fridge.RetrieveItem<RedChilli>();

        Chop(garlic);
        Crush(redChilli);

        return new List<FoodItem>
        {
            tomatoSauce,
            garlic,
            redChilli,
        };
    }

    public IEnumerable<FoodItem> PrepareBologneseIngredients()
    {
        var tomatoSauce = _fridge.RetrieveItem<TomatoSauce>();
        var beef = _fridge.RetrieveItem<Beef>();
        var onion = _cupboard.RetrieveItem<Onion>();
        var garlic = _cupboard.RetrieveItem<Garlic>();

        Mince(beef);
        Chop(onion);
        Chop(garlic);

        return new List<FoodItem>
        {
            tomatoSauce,
            beef,
            onion,
            garlic,
        };
    }

    public IEnumerable<FoodItem> PrepareCarbonaraIngredients()
    {
        var cheese = _fridge.RetrieveItem<Cheese>();
        var butter = _fridge.RetrieveItem<Butter>();
        var egg = _cupboard.RetrieveItem<Egg>();
        var pancetta = _fridge.RetrieveItem<Pancetta>();
        var garlic = _cupboard.RetrieveItem<Garlic>();

        Grate(cheese);
        Beat(egg);
        Chop(pancetta);
        Chop(garlic);

        return new List<FoodItem>
        {
            cheese,
            butter,
            egg,
            pancetta,
            garlic,
        };
    }

    public void Beat(IBeatable beatableIngredient)
    {
        beatableIngredient.Beat();
    }

    public void Chop(IChoppable choppableIngredient)
    {
        choppableIngredient.Chop();
    }

    public void Crush(ICrushable crushableIngredient)
    {
        crushableIngredient.Crush();
    }

    public void Grate(IGrateable grateableIngredient)
    {
        grateableIngredient.Grate();
    }

    public void Mince(IMinceable minceableIngredient)
    {
        minceableIngredient.Mince();
    }
}
