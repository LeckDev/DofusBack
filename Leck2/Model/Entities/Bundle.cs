using Leck2.Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Bundle
{
    [Key]
    public Guid Id { get; set; }

    public DateTime Date { get; set; }

    [Required]
    [MaxLength(20)]
    public string State { get; set; }  // Peut être un enum ou string en BDD

    public int ExpectedTotalSoldAmount { get; set; }

    public ICollection<Transaction> Transactions { get; set; }

    public Guid UserId { get; set; }

    public User User { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime LastUpdatedAt { get; set; }
}