using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebArchi.Data.DTOs
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [ForeignKey("ShoppingCart")]
        public Guid ShoppingCart_Id { get; set; }
        public ShoppingCart? ShoppingCart { get; set; }
    }
}
