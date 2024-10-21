using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace AmableQuishpePromBurgers.Models
{
    public class Burger
    {

        public int Burgerid { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool Withcheese { get; set; }
        [Range(0.01, 99.99)]
        public decimal Price { get; set; }
        public List<Promo>? Promos { get; set; }

    }
}
