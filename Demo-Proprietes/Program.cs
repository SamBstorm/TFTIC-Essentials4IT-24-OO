using Demo_Proprietes.Models;

namespace Demo_Proprietes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            login.Email = "sam@fait.rire";
            login.MotDePasse = "Test1234=";

            Console.WriteLine("L'adresse email est " + login.Email + " et le mot de passe n'est pas accessible car le getter est private");
        }
    }
}
