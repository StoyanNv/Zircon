using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
using Microsoft.AspNetCore.Identity;

namespace Zircon.Models
{
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