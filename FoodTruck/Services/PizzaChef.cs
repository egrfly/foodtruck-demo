using System.Collections.Generic;
using FoodTruck.Models.Business;
using FoodTruck.Models.Business.Fridge;
using FoodTruck.Models.Business.Properties;
using FoodTruck.Repositories;

namespace FoodTruck.Services;

public interface PizzaChef : Chef
{
    IEnumerable<FoodItem> PrepareHawaiianIngredients();
    IEnumerable<FoodItem> PrepareMargheritaIngredients();
    IEnumerable<FoodItem> PreparePepperoniIngredients();
}

public class Luigi : PizzaChef
{
    private readonly Fridge _fridge;

    public Luigi(Fridge fridge)
    {
        _fridge = fridge;
    }

    public IEnumerable<FoodItem> PrepareHawaiianIngredients()
    {
        var tomatoSauce = _fridge.RetrieveItem<TomatoSauce>();
        var cheese = _fridge.RetrieveItem<Cheese>();
        var ham = _fridge.RetrieveItem<Ham>();
        var pineapple = _fridge.RetrieveItem<Pineapple>();

        Grate(cheese);
        Chop(ham);
        Chop(pineapple);

        return new List<FoodItem>
        {
            tomatoSauce,
            cheese,
            ham,
            pineapple,
        };
    }

    public IEnumerable<FoodItem> PrepareMargheritaIngredients()
    {
        var tomatoSauce = _fridge.RetrieveItem<TomatoSauce>();
        var cheese = _fridge.RetrieveItem<Cheese>();

        Grate(cheese);

        return new List<FoodItem>
        {
            tomatoSauce,
            cheese,
        };
    }

    public IEnumerable<FoodItem> PreparePepperoniIngredients()
    {
        var tomatoSauce = _fridge.RetrieveItem<TomatoSauce>();
        var cheese = _fridge.RetrieveItem<Cheese>();
        var pepperoni = _fridge.RetrieveItem<Pepperoni>();

        Grate(cheese);

        return new List<FoodItem>
        {
            tomatoSauce,
            cheese,
            pepperoni,
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
