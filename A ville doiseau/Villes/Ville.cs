
namespace A_ville_doiseau.Villes
{
    public class Ville
    {
        public string Nom { get; set; } = default!;
        public string? Image { get; set; }
        public int Distance { get; set; }
        public double Latitutde { get; set; }
        public double Longitude { get; set; }
        public string LienWikipedia { get; set; } = default!;
    }
}
