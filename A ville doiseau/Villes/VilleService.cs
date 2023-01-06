using A_ville_doiseau.Properties;
using GeoCoordinatePortable;
using System.Xml.Serialization;

namespace A_ville_doiseau.Villes
{
    public class VilleService
    {
        private static readonly string lienWikipediaArticle = "https://fr.wikipedia.org/wiki/{0}";
        private static readonly string lienWikipediaPourImages = "https://fr.wikipedia.org/w/api.php?action=query&format=json&titles={0}&prop=pageimages&pithumbsize=800";
        private static readonly string lienWikipediaPourCoordonnees = "https://fr.wikipedia.org/w/api.php?action=query&format=json&titles={0}&prop=coordinates";
        private static readonly string caracteresPourJoindre = "%7C";
        private static readonly string ajouterQuebecALaFin = "{0} (Québec)";
        private static readonly string ajouterVilleALaFin = "{0} (ville)";
        private static readonly XmlSerializer serialiseur = new XmlSerializer(typeof(Ville[]));

        public async Task ChargerVillesDepuisInternet()
        {
            var nomsVilles = Resources.villes.Split('\n');
            var nomsVillesAvecQuebecEntreParentheses = nomsVilles.Select(nomVille => string.Format(ajouterQuebecALaFin, nomVille));
            var nomsVillesAvecVilleEntreParentheses = nomsVilles.Select(nomVille => string.Format(ajouterVilleALaFin, nomVille));

            Dictionary<string, string> imagesParVille = await ObtenirImagesParVille(nomsVilles);
            Dictionary<string, string> imagesParVilleAvecQuebecEntreParentheses = await ObtenirImagesParVille(nomsVillesAvecQuebecEntreParentheses);
            Dictionary<string, string> imagesParVilleAvecVilleEntreParentheses = await ObtenirImagesParVille(nomsVillesAvecVilleEntreParentheses);

            Dictionary<string, Coordinates> coordonneesParVille = await ObtenirCoordonneesParVille(nomsVilles);
            Dictionary<string, Coordinates> coordonneesParVilleAvecQuebecEntreParentheses = await ObtenirCoordonneesParVille(nomsVillesAvecQuebecEntreParentheses);
            Dictionary<string, Coordinates> coordonneesParVilleAvecVilleEntreParentheses = await ObtenirCoordonneesParVille(nomsVillesAvecVilleEntreParentheses);

            var villes = nomsVilles.Select(nomVille =>
            {
                imagesParVille.TryGetValue(nomVille, out string? image);
                coordonneesParVille.TryGetValue(nomVille, out Coordinates? coord);
                var lienWikipedia = string.Format(lienWikipediaArticle, nomVille);

                if (image == null)
                {
                    var villeAvecQuebecALaFin = string.Format(ajouterQuebecALaFin, nomVille);

                    imagesParVilleAvecQuebecEntreParentheses.TryGetValue(villeAvecQuebecALaFin, out image);
                    coordonneesParVilleAvecQuebecEntreParentheses.TryGetValue(villeAvecQuebecALaFin, out coord);

                    lienWikipedia = string.Format(lienWikipediaArticle, villeAvecQuebecALaFin);
                }

                if (image == null)
                {
                    var villeAvecVilleEntreParenthses = string.Format(ajouterVilleALaFin, nomVille);
                    imagesParVilleAvecVilleEntreParentheses.TryGetValue(villeAvecVilleEntreParenthses, out image);
                    coordonneesParVilleAvecVilleEntreParentheses.TryGetValue(villeAvecVilleEntreParenthses, out coord);

                    lienWikipedia = string.Format(lienWikipediaArticle, villeAvecVilleEntreParenthses);
                }

                return new Ville
                {
                    Nom = nomVille,
                    Image = image!,
                    Coordonnees = coord != null ? new GeoCoordinate(coord.Lat, coord.Lon) : new GeoCoordinate(0, 0),
                    LienWikipedia = lienWikipedia.Replace(" ", "%20"),
                };
            }).ToArray();

            using TextWriter ecriveur = new StreamWriter("donnees.xml");
            serialiseur.Serialize(ecriveur, villes);
        }

        public Ville[] ChargerVilles()
        {
            using TextReader lecteur = new StreamReader("donnees.xml");
            var villes = (Ville[])serialiseur.Deserialize(lecteur)!;

            return villes;
        }

        private static async Task<Dictionary<string, string>> ObtenirImagesParVille(IEnumerable<string> nomsVilles)
        {
            string lienImages1 = CreerLienWikipediaImages(nomsVilles.Take(50));
            ResultatWikipedia imagesDeWikipedia1 = await ObtenirResultatWikipedia(lienImages1);

            string lienImages2 = CreerLienWikipediaImages(nomsVilles.Skip(50));
            ResultatWikipedia imagesDeWikipedia2 = await ObtenirResultatWikipedia(lienImages2);

            var pages = imagesDeWikipedia1.Query.Pages.Values.Concat(imagesDeWikipedia2.Query.Pages.Values);

            return pages.Where(page => page.Thumbnail != null).ToDictionary(page => page.Title, page => page.Thumbnail!.Source);
        }


        private static async Task<Dictionary<string, Coordinates>> ObtenirCoordonneesParVille(IEnumerable<string> nomsVilles)
        {
            string lienCoordonnees1 = CreerLienWikipediaCoordonnees(nomsVilles.Take(50));
            ResultatWikipedia coordonneesDeWikipedia1 = await ObtenirResultatWikipedia(lienCoordonnees1);

            string lienCoordonnees2 = CreerLienWikipediaCoordonnees(nomsVilles.Skip(50));
            ResultatWikipedia coordonneesDeWikipedia2 = await ObtenirResultatWikipedia(lienCoordonnees2);

            var pages = coordonneesDeWikipedia1.Query.Pages.Values.Concat(coordonneesDeWikipedia2.Query.Pages.Values);

            return pages.Where(page => page.Coordinates != null).ToDictionary(page => page.Title, page => page.Coordinates!.First());
        }


        private static async Task<ResultatWikipedia> ObtenirResultatWikipedia(string lien)
        {
            using var client = new HttpClient();

            return await client.GetFromJsonAsync<ResultatWikipedia>(lien);
        }

        private static string CreerLienWikipediaImages(IEnumerable<string> nomsVilles)
        {
            return CreerLienWikipedia(lienWikipediaPourImages, nomsVilles);
        }

        private static string CreerLienWikipediaCoordonnees(IEnumerable<string> nomsVilles)
        {
            return CreerLienWikipedia(lienWikipediaPourCoordonnees, nomsVilles);
        }

        private static string CreerLienWikipedia(string lien, IEnumerable<string> nomsVilles)
        {
            return string.Format(lien, string.Join(caracteresPourJoindre, nomsVilles));
        }
    }

    public class ResultatWikipedia
    {
        public Query Query { get; set; } = default!;
    }

    public class Query
    {
        public Dictionary<string, Page> Pages { get; set; } = default!;
    }

    public class Page
    {
        public string Title { get; set; } = default!;
        public List<Coordinates>? Coordinates { get; set; } = default!;
        public Thumbnail? Thumbnail { get; set; }
    }

    public class Coordinates
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    public class Thumbnail
    {
        public string Source { get; set; } = default!;
    }
}
