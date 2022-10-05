using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using FluentAssertions;
using FoodTruck.Models.Business.Fridge;
using FoodTruck.Repositories;
using FoodTruck.Services;
using Xunit;

namespace FoodTruckTests.ServiceTests;

public class PizzaChefTests
{
    private readonly Fridge _infiniteCapacityFridge;

    private readonly PizzaChef _pizzaChef;

    public PizzaChefTests()
    {
        _infiniteCapacityFridge = A.Fake<Fridge>();

        _pizzaChef = new Luigi(_infiniteCapacityFridge);
    }

    [Fact]
    public void PrepareHawaiianIngredients_Called_ReturnsHawaiianIngredients()
    {
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<TomatoSauce>()).Returns(new TomatoSauce());
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<Cheese>()).Returns(new Cheese());
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<Ham>()).Returns(new Ham());
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<Pineapple>()).Returns(new Pineapple());

        var ingredients = _pizzaChef.PrepareHawaiianIngredients();
        var ingredientDescriptors = ingredients.Select(ingredient => ingredient.GetDescriptor());
        ingredientDescriptors.Should().BeEquivalentTo(new List<string>
        {
            "Tomato Sauce",
            "Cheese (grated)",
            "Ham (chopped)",
            "Pineapple (chopped)",
        });
    }

    [Fact]
    public void PrepareMargheritaIngredients_Called_ReturnsMargheritaIngredients()
    {
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<TomatoSauce>()).Returns(new TomatoSauce());
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<Cheese>()).Returns(new Cheese());

        var ingredients = _pizzaChef.PrepareMargheritaIngredients();
        var ingredientDescriptors = ingredients.Select(ingredient => ingredient.GetDescriptor());
        ingredientDescriptors.Should().BeEquivalentTo(new List<string>
        {
            "Tomato Sauce",
            "Cheese (grated)",
        });
    }

    [Fact]
    public void PreparePepperoniIngredients_Called_ReturnsPepperoniIngredients()
    {
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<TomatoSauce>()).Returns(new TomatoSauce());
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<Cheese>()).Returns(new Cheese());
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<Pepperoni>()).Returns(new Pepperoni());

        var ingredients = _pizzaChef.PreparePepperoniIngredients();
        var ingredientDescriptors = ingredients.Select(ingredient => ingredient.GetDescriptor());
        ingredientDescriptors.Should().BeEquivalentTo(new List<string>
        {
            "Tomato Sauce",
            "Cheese (grated)",
            "Pepperoni",
        });
    }
}
