using FoodTruck.Models.Business.Properties;

namespace FoodTruck.Models.Business.Cupboard;

public class Egg : FoodItem, IBeatable
{
    public void Beat()
    {
        Modifiers.Add("beaten");
    }
}
