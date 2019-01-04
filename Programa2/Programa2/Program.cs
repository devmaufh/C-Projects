using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Programa2
{
    class Program
    {
        int n1=0, n2=0,r=0;
        void leeD()
        {
            Console.WriteLine("Ingresa el número 1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el número 2");
            n2 = Convert.ToInt32(Console.ReadLine());
        }
        void sum(int n1,int n2)
        {
            r = n1 + n2;
            mostrar();
        }
        void rest(int n1, int n2)
        {
            r = n1 - n2;
            mostrar();
        }
        void multi(int n1, int n2)
        {
            r = n1 * n2;
            mostrar();
        }
        void div(int n1, int n2)
        {
            if (n2 == 0)
            {
                Console.WriteLine("No es posible dividir entre CERO '0'");
            }
            else
            {
                r = n1 / n2;
                mostrar();
            }
        }
        void mostrar()
        {
            Console.WriteLine("Resultado: "+r);
        }
        void menu()
        {
            Console.WriteLine("");
            Console.WriteLine("Opciones:\n1. Leer datos\n2. Suma\n3. Resta\n4. Multiplicacíón" +
                "\n5. Division");
            String o=Console.ReadLine();
            switch (o)
            {
                case "1": leeD(); break;
                case "2":sum(n1,n2); break;
                case "3": rest(n1, n2);break;
                case "4": multi(n1, n2); break;
                case "5": div(n1, n2); break;
                default: Console.WriteLine("Seleccione una opcion valida");break; 
            }
            menu();
            
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.menu();
            
        }
    }
}