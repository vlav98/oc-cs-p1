using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(0, 100);

            Console.WriteLine("Bienvenue dans le \"Guess my secret number !\". " +
                "Le but du jeu est simple, il suffit de deviner le numéro " +
                "aléatoire que je génère. Prêt ? Commençons sans tarder !");
            bool secretNumberFound = false;
            int guess;
            int tries = 0;
            while (!secretNumberFound)
            {
                Console.WriteLine("Saisissez un nombre compris entre 0 et 100 (exclu)");
                string input = Console.ReadLine();
                if (int.TryParse(input, out guess))
                {
                    if (guess == secretNumber)
                    {
                        secretNumberFound = true;
                        Console.WriteLine("Félicitations ! Le numéro que vous avez saisi " +
                            "correspond bien au numéro secret " + secretNumber);
                    }
                    else
                    {
                        if (guess < secretNumber)
                            Console.WriteLine("Trop petit !");
                        else
                            Console.WriteLine("Trop grand !");
                    }
                    tries++;
                }
                else
                    Console.WriteLine("Vous n'avez pas saisi de chiffres...");                
            }
            Console.WriteLine("Vous avez réussi à deviner le nombre " +
                secretNumber + " en " +
                tries + " coups !");
        }
    }
}
