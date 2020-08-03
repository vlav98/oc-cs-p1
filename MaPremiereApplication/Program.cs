using System;

namespace MaPremiereApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AffichageBienvenue();
        }

        static void AffichageBienvenue()
        {
            Console.WriteLine("Bonjour Valentine");
            Console.WriteLine("-------" + Environment.NewLine);
            Console.WriteLine("\tBienvenue dans le monde merveilleux du C#");
        }
    }
}
