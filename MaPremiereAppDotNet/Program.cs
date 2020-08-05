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

            for (int i = 3; i <= end; i += 3)
            {
                multiple3.Add(i);
            }
            for (int i = 5; i <= end; i += 5)
            {
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
