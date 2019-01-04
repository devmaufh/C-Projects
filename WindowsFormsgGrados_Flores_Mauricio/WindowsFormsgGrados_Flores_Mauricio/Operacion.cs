using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsgGrados_Flores_Mauricio
{
    class Operacion
    {
        double grado;
        public Operacion(double g)
        {
            grado = g;
        }
        public double fa()
        {
            return (9 * grado / 5) + 32;
        }
    }
}
