using System.ComponentModel.DataAnnotations;

namespace Zircon.Models
{
    public class GiftCard
    {
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public int Discount { get; set; }
    }
}