namespace Zircon.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public class User : IdentityUser
    {
        public User()
        {
            Orders = new List<ProductOrders>();
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public Address Address { get; set; }

        public ICollection<ProductOrders> Orders { get; set; }
    }
}