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
            Complex c = Complex.One;
            Console.WriteLine(c);
            Console.WriteLine("Partie réelle : " + c.Real);
            Console.WriteLine("Partie imaginaire : " + c.Imaginary);

            Console.WriteLine(Complex.Conjugate(Complex.FromPolarCoordinates(1.0, 45 * Math.PI / 180)));
        }
    }
}
