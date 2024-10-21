namespace AmableQuishpePromBurgers.Models
{
    public class Promo
    {

        public int PromoId { get; set; }

        public string? Descrpcion{ get; set; }

        public DateTime FechaPromo  { get; set; }

        public int BurgesId {  get; set; }

        public Burges? Burges { get; set;}
    }
}
