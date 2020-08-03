using System;

namespace MaPremiereApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage("Valentine", 22);
            AffichageBienvenue();
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
    }
}
