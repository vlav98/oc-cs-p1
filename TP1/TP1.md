Le but est de créer une petite application qui affiche un message différent en fonction du nom de l’utilisateur et du moment de la journée :
* Bonjour XXX pour la tranche horaire 9h <-> 18h, les lundi, mardi, mercredi, jeudi et vendredi
* Bonsoir XXX pour la tranche horaire 18h <-> 9h, les lundi, mardi, mercredi, jeudi
* Bon week-end XXX pour la tranche horaire vendredi 18h <-> lundi 9h

Instructions :
* DateTime.Now.Hour
* DateTime.Now.DayOfWeek

# Solution :

```
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

```