using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(100)]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MaxLength(50)]
    public string Username { get; set; }

    public ICollection<Bundle> Bundles { get; set; }
    public ICollection<SoldingItem> SoldingItems { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    [Required]
    public DateTime LastUpdatedAt { get; set; }
}
