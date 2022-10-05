using System.Collections.Generic;
using System.Linq;

namespace FoodTruck.Helpers;

public static class MenuHelper
{
    public static IEnumerable<string> GetMenuItems<TMenu>()
    {
        return typeof(TMenu)
            .GetMethods()
            .Select(method => method.Name)
            .Where(name => name.EndsWith("Recipe"))
            .Select(name => name[..^"Recipe".Length]);
    }
}
