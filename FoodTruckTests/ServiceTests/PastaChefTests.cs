using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using FluentAssertions;
using FoodTruck.Models.Business.Cupboard;
using FoodTruck.Models.Business.Fridge;
using FoodTruck.Repositories;
using FoodTruck.Services;
using Xunit;

namespace FoodTruckTests.ServiceTests;

public class PastaChefTests
{
    private readonly Cupboard _infiniteCapacityCupboard;
    private readonly Fridge _infiniteCapacityFridge;

    private readonly PastaChef _pastaChef;

    public PastaChefTests()
    {
        _infiniteCapacityCupboard = A.Fake<Cupboard>();
        _infiniteCapacityFridge = A.Fake<Fridge>();

        _pastaChef = new Mario(_infiniteCapacityCupboard, _infiniteCapacityFridge);
    }

    [Fact]
    public void PrepareArrabbiataIngredients_Called_ReturnsArrabbiataIngredients()
    {
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<TomatoSauce>()).Returns(new TomatoSauce());
        A.CallTo(() => _infiniteCapacityCupboard.RetrieveItem<Garlic>()).Returns(new Garlic());
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<RedChilli>()).Returns(new RedChilli());

        var ingredients = _pastaChef.PrepareArrabbiataIngredients();
        var ingredientDescriptors = ingredients.Select(ingredient => ingredient.GetDescriptor());
        ingredientDescriptors.Should().BeEquivalentTo(new List<string>
        {
            "Tomato Sauce",
            "Garlic (chopped)",
            "Red Chilli (crushed)",
        });
    }

    [Fact]
    public void PrepareBologneseIngredients_Called_ReturnsBologneseIngredients()
    {
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<TomatoSauce>()).Returns(new TomatoSauce());
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<Beef>()).Returns(new Beef());
        A.CallTo(() => _infiniteCapacityCupboard.RetrieveItem<Onion>()).Returns(new Onion());
        A.CallTo(() => _infiniteCapacityCupboard.RetrieveItem<Garlic>()).Returns(new Garlic());

        var ingredients = _pastaChef.PrepareBologneseIngredients();
        var ingredientDescriptors = ingredients.Select(ingredient => ingredient.GetDescriptor());
        ingredientDescriptors.Should().BeEquivalentTo(new List<string>
        {
            "Tomato Sauce",
            "Beef (minced)",
            "Onion (chopped)",
            "Garlic (chopped)",
        });
    }

    [Fact]
    public void PrepareCarbonaraIngredients_Called_ReturnsCarbonaraIngredients()
    {
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<Cheese>()).Returns(new Cheese());
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<Butter>()).Returns(new Butter());
        A.CallTo(() => _infiniteCapacityCupboard.RetrieveItem<Egg>()).Returns(new Egg());
        A.CallTo(() => _infiniteCapacityFridge.RetrieveItem<Pancetta>()).Returns(new Pancetta());
        A.CallTo(() => _infiniteCapacityCupboard.RetrieveItem<Garlic>()).Returns(new Garlic());

        var ingredients = _pastaChef.PrepareCarbonaraIngredients();
        var ingredientDescriptors = ingredients.Select(ingredient => ingredient.GetDescriptor());
        ingredientDescriptors.Should().BeEquivalentTo(new List<string>
        {
            "Cheese (grated)",
            "Butter",
            "Egg (beaten)",
            "Pancetta (chopped)",
            "Garlic (chopped)",
        });
    }
}
