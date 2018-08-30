using System.ComponentModel.DataAnnotations;

namespace Zircon.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        public string Town { get; set; }

        [Required]
        public string District { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public int Postcode { get; set; }

        public int? Floor { get; set; }

        public int? Block { get; set; }

        public string Apartment { get; set; }

        public string Bell { get; set; }
    }
}