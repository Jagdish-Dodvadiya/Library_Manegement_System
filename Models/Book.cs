using System.ComponentModel.DataAnnotations.Schema;
namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Author { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        public int PublicationYear { get; set; }
    }
}
