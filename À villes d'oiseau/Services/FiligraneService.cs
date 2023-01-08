using System.Text;

namespace A_villes_d_oiseau.Services
{
    public class FiligraneService
    {
        private const int nombreRepetitions = 20;
        private static readonly string formatFiligrane = new StringBuilder()
            .Insert(0, "À villes d'oiseau édition {0} ", nombreRepetitions)
            .Replace(' ', ' ')
            .ToString();
        private readonly static Dictionary<string, string> filigranesParVille = new();

        public static void DefinirVilles(IEnumerable<string> nomVilles)
        {
            filigranesParVille.Clear();

            foreach (var nomVille in nomVilles)
            {
                filigranesParVille[nomVille] = string.Format(formatFiligrane, nomVille.Replace(' ', ' '));
            }
        }

        public string GenererFiligrane(string nomVille)
        {
            return filigranesParVille[nomVille];
        }
    }
}
