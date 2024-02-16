using Demo_Encapsulation.Structs;

namespace Demo_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour veuillez vous identifier :");
            Login login = new Login();
            Console.Write("Votre email : ");
            login.email = Console.ReadLine();

            Console.Write("Votre mot de passe : ");
            login.DefinirMotDePasse(Console.ReadLine());

            Console.WriteLine("Vous avez comme email : " + login.email + "; et comme mot de passe : ****** ");

            Console.WriteLine("Veuillez vous connecter :");
            Console.Write("Quel est votre email : ");
            string mail = Console.ReadLine();
            Console.Write("Et votre mot de passe : ");
            string mot = Console.ReadLine();

            bool sontCorrect = login.VerifierConnexion(mail, mot);

            if (sontCorrect) Console.WriteLine("Bienvenu utilisateur!");
            else Console.WriteLine("Aïe, je ne vous ai pas reconnu!");
        }
    }
}
