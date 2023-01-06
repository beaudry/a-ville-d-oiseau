
using GeoCoordinatePortable;

namespace A_ville_doiseau.Villes
{
    public class Ville
    {
        public string Nom { get; set; } = default!;
        public string Image { get; set; } = default!;
        public GeoCoordinate Coordonnees { get; set; } = default!;
        public string LienWikipedia { get; set; } = default!;
    }
}
