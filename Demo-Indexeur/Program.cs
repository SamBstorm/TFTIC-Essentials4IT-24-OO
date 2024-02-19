using Demo_Indexeur.Models;

namespace Demo_Indexeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paquet paquet1 = new Paquet();
            paquet1.InitialiserPaquet();
            Carte c3 = paquet1[3];
            Console.WriteLine( c3 );
            
            Carte cSupplementaire = new Carte() { Couleur = Couleurs.Coeur, Valeur = Valeurs.As};
            paquet1[3] = cSupplementaire;

            Carte roiCarreau = paquet1[Valeurs.Roi, Couleurs.Carreau];
            Console.WriteLine( roiCarreau );
            roiCarreau.Valeur = Valeurs.Reine;
            Console.WriteLine(paquet1[38]);
        }
    }
}
