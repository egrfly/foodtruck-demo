using FoodTruck.Models.Business.Properties;

namespace FoodTruck.Models.Business.Fridge;

public class RedChilli : FoodItem, ICrushable
{
    public void Crush()
    {
        Modifiers.Add("crushed");
    }
}
