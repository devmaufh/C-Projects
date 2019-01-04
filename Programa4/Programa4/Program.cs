using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa4
{
    class Program
    {
        int Ra=0, Rm=0, Rd=0;
        int año(int nacimiento)
        {
            return Convert.ToInt32(DateTime.Now.Year) - nacimiento;
        }
        int mesdia(int nacimiento, int diferencia)
        {
            int r = 0;
            if (diferencia == 12)
                r = Convert.ToInt32(DateTime.Now.Month) - nacimiento;
            else r = Convert.ToInt32(DateTime.Now.Day) - nacimiento;
            return r;
        }
        String edad(int añ, int me, int di)
        {
            Ra = año(añ);
            Rm = mesdia(me, 12);
            Rd = mesdia(di, 30);
            if (Rm < 0) {
                Ra -= 1;
                Rm+= 12;
            }
            if (Rd < 0){
                Rm -= 1;
                Rd += 30;
            }
            return Ra+" años, "+Rm+" meses, "+Rd+" días";
            
        }
        Boolean verificaAño(int a)
        {
            return a > Convert.ToInt16(DateTime.Now.Year);
        }
        Boolean verificaMes(int a)
        {
            return a > Convert.ToInt16(DateTime.Now.Month);
        }
        Boolean verificaDia(int a)
        {
            return a > Convert.ToInt16(DateTime.Now.Day);
        }
        void verifica(int d, int m, int a)
        {
            if (d > 30)
            {
                Console.WriteLine("KEEFecha incorrecta");

            }
            else
            {
                if (!verificaAño(a))
                {
                    //Correcto
                    if (!verificaMes(m))
                    {
                        Console.WriteLine("Mes correcto");
                        if (! verificaDia(d))
                        {
                            Console.WriteLine(this.edad(a, m, d));
                        }
                        else
                        {
                            Console.WriteLine("Fecha incorrectaD");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Fecha incorrectaM");
                    }
                }
                else
                {
                    Console.WriteLine("Fecha incorrectaA");
                }
            }
        }
        static void Main(string[] args)
        {

            Program p = new Program();

            Console.WriteLine("Día: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Año: ");
            int año = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkRed;
           // p.verifica(dia, mes, al);
            Console.WriteLine(p.edad(año,mes,dia));
            Console.ReadLine();
        }
    }
}
