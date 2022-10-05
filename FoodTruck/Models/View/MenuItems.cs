using System.Collections.Generic;

namespace FoodTruck.Models.View;

public class MenuItems
{
    public IEnumerable<string> PastaMenuItems { get; set; }
    public IEnumerable<string> PizzaMenuItems { get; set; }
}
