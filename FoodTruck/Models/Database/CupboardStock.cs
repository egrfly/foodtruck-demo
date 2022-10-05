using System.ComponentModel.DataAnnotations;

namespace FoodTruck.Models.Database;

public class CupboardStock
{
    [Key]
    public string Item { get; set; }
    public int Quantity { get; set; }
}
