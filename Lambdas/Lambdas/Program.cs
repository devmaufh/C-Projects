using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        //Estructura:
        //Func<tipo_dato_parametro, tipo_dato_resultado> nombre_expresion=(variable_parametro)=> cuerpo de la expresión;

        Func<int, int, bool> iguales = (x, y) => x == y;//Lambda de expresión
        Func<int, int,int> sumas = (x, x2) => x + x2;

        static void Main(string[] args)
        {

        }
    }
}
