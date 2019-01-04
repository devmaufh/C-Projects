using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa3SI
{
    class triangulo
    {
        String tipo = "Isósceles";
        double bas = 0,altura=0;
        public triangulo(double b,double alt)
        {
            bas = b;
            altura = alt;
        }

        public double calculaLado()
        {
            double a = bas / 2;
            double resultado = Math.Sqrt(a*a+altura*altura);
            return resultado;//Math.Pow(a,2)+Math.Pow(bas,2)
        }
        public Double Perimetro()
        {
            return (calculaLado() * 2) + bas;
        }
        public Double area()
        {
            return (bas * altura) / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa base: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa Altura: ");            
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            triangulo t = new triangulo(b,h);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Perimetro= "+t.Perimetro());
            Console.WriteLine("Area= "+t.area());
            Console.ReadLine();
        }
    }
}
