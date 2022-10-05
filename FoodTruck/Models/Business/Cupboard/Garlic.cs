using FoodTruck.Models.Business.Properties;

namespace FoodTruck.Models.Business.Cupboard;

public class Garlic : FoodItem, IChoppable
{
    public void Chop()
    {
        Modifiers.Add("chopped");
    }
}
