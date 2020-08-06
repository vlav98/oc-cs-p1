using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremiereAppDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            message();
        }

        static void message ()
        {
            DayOfWeek day = DateTime.Now.DayOfWeek;
            int hour = DateTime.Now.Hour;

            if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
            {
                BonWeekEnd();
            } else
            {
                if (hour >= 9 && hour < 18)
                {
                    Bonjour();
                } else
                {
                    if (day == DayOfWeek.Friday)
                    {
                        BonWeekEnd();
                    } else
                    {
                        Bonsoir();
                    }
                }
            }
        }

        static void BonWeekEnd()
        {
            Console.WriteLine("Bon week-end " + Environment.UserName);
        }
        static void Bonjour()
        {
            Console.WriteLine("Bonjour " + Environment.UserName);
        }
        static void Bonsoir()
        {
            Console.WriteLine("Bonsoir " + Environment.UserName);
        }
    }
}