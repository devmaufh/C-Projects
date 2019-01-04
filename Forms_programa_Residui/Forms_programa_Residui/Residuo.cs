using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_programa_Residui
{
    class Residuo
    {
        public int[] datos = { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        public int[] resultado = new int[10];
        public int numero = 0;
        public Residuo(int num)
        {
            numero = num;
        }
        public void calcula()
        {
            for (int i = 0; i < datos.Length; i++)
            {
                resultado[i] += numero / datos[i];
                numero = numero % datos[i];
            }
        }

    }
}
