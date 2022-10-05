using FoodTruck.Models.Business.Properties;

namespace FoodTruck.Models.Business.Fridge;

public class Beef : FoodItem, IMinceable
{
    public void Mince()
    {
        Modifiers.Add("minced");
    }
}
