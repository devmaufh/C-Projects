using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    class Program
    {
        String Saludo = "";
        void MostrarSaludo()
        {
            Console.WriteLine(Saludo);
            Console.ReadLine();
        }
        void cambiaSaludo(String saludo)
        {
            Saludo = saludo;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hola mundo Ci sharp :v");
            Console.WriteLine("Escribe un saludo :v ");
            String saludo = Console.ReadLine();
            Console.Write("El nuevo saludo es: ");
            p.cambiaSaludo(saludo);
            Console.Write("El nuevo saludo es: ");
            p.MostrarSaludo();
            Console.WriteLine("*************************************");
            Console.WriteLine("Escribe tu nombre: ");
            String nom = Console.ReadLine();
            Console.WriteLine("{0} Bienvenido a c#, {1}",nom,p.Saludo);
            Console.ReadLine();


        }
    }
}
