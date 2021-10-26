using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompleksniBrojeviComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(3, 4);
            Complex c = a + b;

            Console.WriteLine("Sum c.Real = " + c.Real);
            Console.WriteLine("Sum c.Imaginary = " + c.Imaginary);
        }
    }
}
