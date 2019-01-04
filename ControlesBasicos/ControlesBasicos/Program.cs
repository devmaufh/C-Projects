using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 0,c=0;
            int[] arr = {10,20,34,1,3,56,4,6,3,5 };
            Boolean flag = false;
            while (!flag)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length-1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            aux = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = aux;
                            c++;
                        }
                        else flag = true;
                    }
                }

            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********************\n"+c);
            Console.ReadKey();
        }
    }
}
