using System;

namespace MaPremiereApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage("Valentine", 22);
            double valeur = LongueurHypotenuse(1, 3);
            Console.WriteLine(valeur);
            valeur = LongueurHypotenuse(10, 10);
            Console.WriteLine("Le résultat est : " + valeur);
        }

        static void AffichageBienvenue()
        {
            Console.WriteLine("Bonjour Valentine");
            Console.WriteLine("-------" + Environment.NewLine);
            Console.WriteLine("\tBienvenue dans le monde merveilleux du C#");
        }

        static void WelcomeMessage(string name, int age)
        {
            Console.WriteLine("Bonjour " + name);
            Console.WriteLine("Vous avez " + age + " ans");
        }

        static double LongueurHypotenuse(double a, double b)
        {
            double sommeDesCarres = a * a + b * b;
            double resultat = Math.Sqrt(sommeDesCarres);
            return resultat;
        }
    }
}
