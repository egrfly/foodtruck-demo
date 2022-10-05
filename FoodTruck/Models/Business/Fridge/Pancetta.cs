using FoodTruck.Models.Business.Properties;

namespace FoodTruck.Models.Business.Fridge;

public class Pancetta: FoodItem, IChoppable
{
    public void Chop()
    {
        Modifiers.Add("chopped");
    }
}
