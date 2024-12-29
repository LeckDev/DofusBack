using System.ComponentModel.DataAnnotations;

public class Item
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    public int StackAmount { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    [Required]
    public DateTime LastUpdatedAt { get; set; }
}