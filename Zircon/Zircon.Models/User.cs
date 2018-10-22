namespace Zircon.Models
{
    using Common;
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        public User()
        {
            Orders = new List<ProductOrders>();
        }
        [MinLength(Constants.AttributeConstraint.NameMinLenght)]
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(Constants.AttributeConstraint.SurnameMinLenght)]
        public string Surname { get; set; }
        public Address Address { get; set; }

        public ICollection<ProductOrders> Orders { get; set; }
    }
}