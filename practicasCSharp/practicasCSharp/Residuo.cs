using System;
namespace Resudio
{
    class residuos
    {
        public int[] datos = {1000,500,200,100,50,20,10,5,2,1 };
        public int numero = 0;
        public int b=0,m=0;
        public residuos(int num)
        {
            numero = num;
        }
        public void calcula()
        {
           int auxDiv;
            for (int i = 0; i < datos.Length; i++)
            {
                if (i <= 5)
                {
                    b += numero / datos[i];
                    numero = numero % datos[i];
                }
                if (i > 5)
                {
                    m += numero / datos[i];
                    numero = numero % datos[i];
                }
            }
        }
        
    }

}