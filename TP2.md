Le but de ce TP va être de créer 3 méthodes.

La première va servir à calculer la sommes d'entiers consécutifs. 
Si par exemple je veux calculer la somme des entiers de 1 à 10, 
c'est à dire 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10, je vais appeler cette 
méthode en lui passant en paramètres 1 et 10, c'est-à-dire les bornes des 
entiers dont il faut faire la somme.

Quelque chose du genre :

```
Console.WriteLine(CalculSommeEntiers(1, 10));
Console.WriteLine(CalculSommeEntiers(1, 100));
```
Sachant que le premier résultat de cet exemple vaut 55 
(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 = 55) et le deuxième 5050.

La deuxième méthode acceptera une liste de double en paramètres et 
devra renvoyer la moyenne des doubles de la liste. Par exemple :

```
List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6};
Console.WriteLine(CalculMoyenne(liste));
```
Le résultat de cet exemple vaut 5.76.

Enfin, la dernière méthode devra dans un premier temps construire 
une liste d’entiers de 1 à 100 qui sont des multiples de 3 (3, 6, 9, 12, …). 
Dans un second temps, construire une autre liste d’entiers de 1 à 100 
qui sont des multiples de 5 (5, 10, 15, 20, …). Et dans un dernier temps, 
il faudra calculer la somme des entiers qui sont communs aux deux listes … 
vous devez bien sur trouver 630 comme résultat :)

# Solution :

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MaPremiereAppDotNet
{
    class Program
    {
        static void Main(string[] args)
        {            
            CalculSommeEntier(1,10);
            CalculSommeEntier(1,100);
            List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6 };
            CalculMoyenne(liste);
            CalculIntersection(100);
            Console.WriteLine(CalculSommeIntersection());
        }

        static void CalculSommeEntier(int start, int end)
        {
            int sum = 0;
            for(int i = start; i <= end; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }

        static void CalculMoyenne(List<double> list)
        {
            double total = 0;
            for (int i = 0; i < list.Count; i++)
            {
                total = total + list[i];
            }
            double average = total / list.Count;
            Console.WriteLine(average);
        }

        static void CalculIntersection(int end)
        {
            List<int> multiple3 = new List<int>() ;
            List<int> multiple5 = new List<int>() ;

            for (int i = 1; i <= end; i++)
            {
                if (i % 3 == 0)
                    multiple3.Add(i);
                if (i % 5 == 0)
                    multiple5.Add(i);
            }

            int total = 0;
            foreach (int m3 in multiple3)
            {
                foreach (int m5 in multiple5)
                {
                    if (m3 == m5)
                    {
                        total += m3;
                    }
                }
            }
            Console.WriteLine(total);
        }

        // Si on veut 
        static int CalculSommeIntersection()
        {
            List<int> multiplesDe3 = new List<int>();
            List<int> multiplesDe5 = new List<int>();

            for (int i = 3; i <= 100; i += 3)
            {
                multiplesDe3.Add(i);
            }
            for (int i = 5; i <= 100; i += 5)
            {
                multiplesDe5.Add(i);
            }

            int somme = 0;
            foreach (int m3 in multiplesDe3)
            {
                foreach (int m5 in multiplesDe5)
                {
                    if (m3 == m5)
                        somme += m3 + m5;
                }
            }
            return somme;
        }
    }
}

```