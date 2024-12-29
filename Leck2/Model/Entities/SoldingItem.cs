using Leck2.Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class SoldingItem
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Item Item { get; set; }

    public ICollection<Price> SellingPrices { get; set; }

    public ICollection<Price> CostPrices { get; set; }

    public int LastSellingPrice { get; set; }

    public int LastCostingPrice { get; set; }

    [Required]
    public User User { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime LastUpdatedAt { get; set; }
}
