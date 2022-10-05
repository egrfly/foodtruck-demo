using FoodTruck.Models.Business.Properties;

namespace FoodTruck.Models.Business.Fridge;

public class Ham: FoodItem, IChoppable
{
    public void Chop()
    {
        Modifiers.Add("chopped");
    }
}
