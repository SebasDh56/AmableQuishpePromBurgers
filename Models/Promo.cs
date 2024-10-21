namespace AmableQuishpePromBurgers.Models
{
    public class Promo
    {
        public int Promoid { get; set; }

        public string? Descripcion { get; set; }
        public DateTime FechaPromo { get; set; }
        public int Burgerid { get; set; }
        public Burger? Burger { get; set; }
    }
}
