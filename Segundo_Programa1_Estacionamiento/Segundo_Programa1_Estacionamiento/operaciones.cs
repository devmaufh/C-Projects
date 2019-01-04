using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Segundo_Programa1_Estacionamiento
{
    class operaciones
    {
        public String error = "";
        public double entrada, salida, monto=0;
        public operaciones(double entrada, double salida)
        {
            this.entrada = entrada;
            this.salida = salida;
        }
        public Boolean validaMinuto(double dato)
        {
            return dato % 100 >= 60;

           
        }
        public Boolean validaHoras(double dato)
        {
            return dato > 0 && dato < 2400;
        }
        double horas()
        {
            return (salida - entrada) / 100;
        }
        public void calcula()
        {
            if (validado()&&!(entrada>salida))
            {

                double aux = Math.Ceiling(horas());
                if (aux > 1) monto = (aux - 1) * 6 + 10;
                else monto = 10;
            }
            else
            {
                error = "Verifique que los datos sean válidos";
            }
        }
        public Boolean validado()
        {
            return (validaHoras(entrada) && !validaMinuto(entrada)) && (validaHoras(salida) && !validaMinuto(salida));

        }
        public String hora_Estancia()
        {
            return Math.Floor(horas()) + " Horas con";
        }
        public String minutos_Estancia()
        {
            if(entrada%100>salida%100)
                return (Convert.ToInt32((horas() % 1) * 100)-40 + " minutos");
            else
                return (Convert.ToInt32((horas() % 1) * 100) + " minutos");

            
        }
        public  String setMonto()
        {
            return monto+"";
        }
    }
}
