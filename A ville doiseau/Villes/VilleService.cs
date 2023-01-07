using System.Xml.Serialization;

namespace A_villes_d_oiseau.Villes
{
    public class VilleService: IDisposable
    {
        private readonly XmlSerializer serialiseur = new XmlSerializer(typeof(Ville[]));
        private readonly HttpClient client = default!;
        private bool disposedValue;

        public VilleService(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task<Ville[]> ChargerVilles()
        {
            using var lecteur = await client.GetStreamAsync("donnees.xml");
            var villes = (Ville[])serialiseur.Deserialize(lecteur)!;

            return villes;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    client.Dispose();
                }
                
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
