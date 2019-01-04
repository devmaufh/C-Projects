using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_6
{
    class Program
    {
        float dolar, peso, euro;
        void datos()
        {
            Console.WriteLine("Ingresa el valor del dolar en pesos: ");
            dolar = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingresa el valor del Euro en pesos: ");
            euro = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingresa el valor a convertir: ");
            peso = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("{0} pesos, equivalen a:\n{1} Dolares\n{2} Euros",peso,peso_Dolar(peso),peso_Euro(peso));
            Console.ReadLine();
        }
        float peso_Dolar(double valor)
        {
            return Convert.ToSingle((valor / dolar));
        }
        float peso_Euro(double valor)
        {
            return Convert.ToSingle((valor / euro));
        }
        static void Main(string[] args)
        {
           new Program().datos();
            new Program().datos2();
        }
        delegate float conversion(float valor, float tasa); //Lambda Expression
        void datos2()
        {
            conversion r=(c,t)=>c/t;// Lambda Expresion
            Console.WriteLine("Valor dolar: ");
            float d = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Valor Euro: ");
            float e = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Valor a convertir: ");
            float x = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Dolar: "+r(x,d));
            Console.WriteLine("Euro: " + r(x,e));
            Console.ReadLine();
        }

    }
}
