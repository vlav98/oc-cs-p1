using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[6];
            int i = 0;

            while (i < tab.Length)
            {
                int random = new Random().Next(1, 49);
                /*
                 * Without additionnal method 
                if (Array.Exists(tab, element => element == random) == false)
                {
                    tab[i] = random;
                    i++;
                }*/
                if (!existInArray(tab, i, random))
                {
                    tab[i] = random;
                    i++;
                }
            }

            displayArray(tab);
            /*tab.ToList().ForEach(j => Console.WriteLine(j.ToString()));*/
        }

        static Boolean existInArray(int[] array, int indice, int random)
        {
            for (int j = 0; j < indice; j++)
            {
                if (array[j] == random)
                {
                    return true;
                }
            }
            return false;
        }

        static void displayArray(int[] array)
        {
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write(array[k] + " ");
            }
            Console.WriteLine();
        }
    }
}
