using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5 Hacer un programa que transforme entre
//dólares y euros y que también pida el tipo  de cambio del día.
namespace Programa5
{
    class Program
    {
        double fh, ce;
        void datos()
        {
            Console.WriteLine("Ingrese los grados C°: ");
            ce = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n{0}° Equivalen a {1}°F",ce,calculo(ce));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nIngresa ENTER para continuar");
            Console.ReadLine();
        }
        double calculo(double d)
        {
            return (9*d)/5+32;
        }
        static void Main(string[] args)
        {
            new Program().datos();
            
        }
    }
}
