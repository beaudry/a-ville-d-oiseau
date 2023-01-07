using GeoCoordinatePortable;

namespace A_villes_d_oiseau.Villes
{
    public class Ville
    {
        public string Nom { get; set; } = default!;
        public string Image { get; set; } = default!;
        public GeoCoordinate Coordonnees { get; set; } = default!;
        public string LienWikipedia { get; set; } = default!;
    }
}
