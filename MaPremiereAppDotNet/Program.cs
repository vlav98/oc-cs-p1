using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MaPremiereAppDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculSommeEntier(1,10);
            List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6 };
            CalculMoyenne(liste);
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
    }
}
