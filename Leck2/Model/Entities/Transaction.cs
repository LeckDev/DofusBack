using Leck2.Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Transaction
{
    [Key]
    public Guid Id { get; set; }

    public int SpentAmount { get; set; }

    public int SoldAmount { get; set; }

    [Required]
    public SoldingItem SoldingItem { get; set; }

    [Required]
    [MaxLength(20)]
    public string State { get; set; }

    [Required]
    public Bundle Bundle { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime LastUpdatedAt { get; set; }
}