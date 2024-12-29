using System.ComponentModel.DataAnnotations;
using System.IO;

public class Price
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public int Value { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    [Required]
    public DateTime LastUpdatedAt { get; set; }

    public SoldingItem? SellingItem { get; set; }
    public SoldingItem? CostingItem { get; set; }

}