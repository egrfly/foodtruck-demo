using FoodTruck.Models.Business;

namespace FoodTruck.Repositories;

public interface FoodStorageUnit
{
    TItem RetrieveItem<TItem>() where TItem : FoodItem, new();
    void ReplenishStock<TItem>();
}
