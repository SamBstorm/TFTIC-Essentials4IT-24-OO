using Test2;

namespace Demo_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] noms = new string[]{ 
                "Amandine",
                "Ayoub"
            };
            Console.WriteLine(noms); //Ne nous affiche pas le contenu, juste le nom complet du type

            TestNameSpace tns = new TestNameSpace();
            tns.nom = noms[0];
            Console.WriteLine(tns); //Ne nous affiche pas le contenu, juste le nom complet du type
            Console.WriteLine(tns.nom); //Nous affiche le contenu car par defaut un string en Console.WriteLine est défini pour

            Test.NouvelleStructure test = new Test.NouvelleStructure(); //Utilisation du Namespace.NomObject car Namespace différent
            Console.WriteLine(test);

            EncoreNouvelleStructure test2 = new EncoreNouvelleStructure(); //Plus besoin de citer le namespace si using en haut du fichier
            Console.WriteLine(test2);
        }
    }

    public struct TestNameSpace
    {
        public string nom;
    }
}

namespace Test
{
    public struct NouvelleStructure
    {

    }
}


namespace Test2
{
    public struct EncoreNouvelleStructure
    {

    }
}
