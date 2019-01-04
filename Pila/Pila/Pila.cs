using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    class Pila
    {
        public void Options()
        {
            Console.WriteLine("Selecciona una opción: ");
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Eliminar");
            Console.WriteLine("3. Mostrar datos");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                default: Console.WriteLine("Ingrese una opción valida"); break;
                case 1: Add();break;
                case 2: Delate();break;
                case 3: mostrar();break;
            }
            Options();
        }
        String[] datos;
        int top = -1;
        public Pila(int tamaño)
        {
            datos = new String[tamaño];
            Console.WriteLine("El tamaño de la pila es: "+datos.Count()+"\n");
        }
        public Pila()
        {
            datos= new String[10];
        }
        public Boolean isFull()
        {
            return top == datos.Count() - 1;
        }
        public void Add()
        {
            if (!isFull())
            {
                top++;
                Console.WriteLine("Inserte el elemento: ");
                datos[top] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Pila llena");
            }
        }
        public void Delate()
        {
            if (top != -1)
                top--;
            else
                Console.WriteLine("Pila vacia, no es posible eliminar :)");
        }
        public void mostrar()
        {
            for (int i = top; i >=0 ; i++)
            {
                Console.WriteLine(datos[i]);
            }
        }
    }
}
