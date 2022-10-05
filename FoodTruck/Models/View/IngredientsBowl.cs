using System.Collections.Generic;
using FoodTruck.Models.Business;

namespace FoodTruck.Models.View;

public class IngredientsBowl
{
    public IEnumerable<FoodItem> Ingredients { get; set; }
}
