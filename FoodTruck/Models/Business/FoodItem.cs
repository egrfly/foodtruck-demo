using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FoodTruck.Models.Business;

public class FoodItem
{
    public ISet<string> Modifiers { get; set; }

    public FoodItem()
    {
        Modifiers = new HashSet<string>();
    }

    public string GetDescriptor()
    {
        var itemName = Regex.Replace(GetType().Name, "([A-Z])", " $1").Trim();
        var itemModifiers = string.Join(", ", Modifiers);
        return itemModifiers.Length > 0 ? $"{itemName} ({itemModifiers})" : itemName;
    }
}
