using System.ComponentModel.DataAnnotations;

namespace TestWebArchi.Data.DTOs
{
    public class ShoppingCart
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
