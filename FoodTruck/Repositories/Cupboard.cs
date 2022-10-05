using System.Linq;
using FoodTruck.Models.Business;

namespace FoodTruck.Repositories;

public interface Cupboard : FoodStorageUnit
{
}

public class WoodenCupboardInTheBackLeftCorner : Cupboard
{
    private readonly FoodTruckDbContext _context;

    public WoodenCupboardInTheBackLeftCorner(FoodTruckDbContext context)
    {
        _context = context;
    }

    public TItem RetrieveItem<TItem>() where TItem : FoodItem, new()
    {
        var itemStock = _context.CupboardStock.Single(cupboardStock => cupboardStock.Item == typeof(TItem).Name);
        if (!(itemStock.Quantity > 0))
        {
            ReplenishStock<TItem>();
        }
        itemStock.Quantity--;
        _context.SaveChanges();

        return new TItem();
    }

    public void ReplenishStock<TItem>()
    {
        var itemStock = _context.CupboardStock.Single(cupboardStock => cupboardStock.Item == typeof(TItem).Name);
        itemStock.Quantity = 50;
        _context.SaveChanges();
    }
}
