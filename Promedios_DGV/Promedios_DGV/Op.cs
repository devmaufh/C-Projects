using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Promedios_DGV
{
    class Op
    {
        public Op() { }
        int pMax = 0;
        int pMin = 0;
        public double prom(List<int> arr)
        {
                int x = 0;
                for (int i = 0; i < arr.Count; i++)
                    x += arr[i];
                return x / arr.Count;
            
        }
        public double max(List<int> arr)
        {
           
            double x = arr[0];
            for (int i = 0; i < arr.Count; i++)
                if (x < arr[i])
                {
                    x = arr[i];
                    pMax = i;
                }
            return x;
        }
        public double min(List<int> arr)
        {
            double x = arr[0];
            for (int i = 0; i < arr.Count; i++)
                if (x > arr[i])
                {
                    x = arr[i];
                    pMin = i;
                }
            return x;
        }
        public int getPositionMax()
        {
            return pMax;
        }
        public int getPositionMin()
        {
            return pMin;
        }
        public double varianza(List<int> arr, double promedio)
        {
            double aux = 0;
            for(int i = 0; i < arr.Count; i++)
            {
                aux+=Math.Pow((arr[i] - promedio), 2);
            }
            return aux / arr.Count;
        }
        public double d_estandar(double var)
        {
            return Math.Sqrt(var);
        }
    }
}
