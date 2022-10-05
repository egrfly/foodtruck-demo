using FoodTruck.Models.Business.Properties;

namespace FoodTruck.Services;

public interface Chef
{
    void Beat(IBeatable beatableIngredient);

    void Chop(IChoppable choppableIngredient);

    void Crush(ICrushable crushableIngredient);

    void Grate(IGrateable grateableIngredient);

    void Mince(IMinceable minceableIngredient);
}
