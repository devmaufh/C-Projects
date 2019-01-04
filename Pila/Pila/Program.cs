using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    class Program
    {
        static void menu()
        {
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("Ingresa el tamaño de la pila: ");
            int tamaño = Convert.ToUInt16(Console.ReadLine());
            new Pila(tamaño).Options();
        }
        static void Main(string[] args)
        {
            menu();

        }
    }
}
