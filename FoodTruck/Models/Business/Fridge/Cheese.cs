using FoodTruck.Models.Business.Properties;

namespace FoodTruck.Models.Business.Fridge;

public class Cheese : FoodItem, IGrateable
{
    public void Grate()
    {
        Modifiers.Add("grated");
    }
}
