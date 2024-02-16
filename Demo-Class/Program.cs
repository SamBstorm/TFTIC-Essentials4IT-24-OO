using Demo_Class.Models;

namespace Demo_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture maFerrari = new Voiture()
            {
                couleur = Couleur.Rouge,
                immatriculation = "2-ABC-123",
                moteur = "Essence",
                peutRouler = true
            };

            Console.WriteLine("Voici ma voiture, elle est " + maFerrari.couleur + " et roule avec de " + maFerrari.moteur);

            Voiture deMonFrere = new Voiture()
            {
                couleur = Couleur.Bleu,
                immatriculation = "2-XYZ-789",
                moteur = "Electrique",
                peutRouler = true
            };

            Console.WriteLine("Voici la voiture de mon frère, elle est " + deMonFrere.couleur + " et roule avec de " + deMonFrere.moteur);

            Voiture laFraise = maFerrari;

            Console.WriteLine("Je présente ma voiture à ma mère, elle l'appelle la fraise...");

            Console.WriteLine("Je roule comme un taré et plante ma ferrari...");
            maFerrari.peutRouler = false;

            if (laFraise.peutRouler)
            {
                Console.WriteLine("La ferrari et la fraise sont deux voitures distinctes.");
            }
            else
            {
                Console.WriteLine("La ferrari et la fraise sont la même et unique voiture.");
            }

        }
    }
}
