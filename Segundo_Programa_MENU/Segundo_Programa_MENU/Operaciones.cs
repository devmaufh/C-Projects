using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Segundo_Programa_MENU
{
    class Operaciones
    {

        public long factorial(int n)
        {
            if (n == 0)
                return 1;
            else return factorial(n - 1) * n;
        }
        public int cubo(int n)
        {
            return n * n * n;
        }
        public Boolean primo(int n)
        {
            int count = 0;
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    count++;
            if (n == 2) return true;
            return count > 0;
        }
        public String letra(int n)
        {
            String tot = "";
            String[] unidad = { "", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve" };
            String[] decena = { "", "Diez", "Veinte", "Treinta", "Cuarenta", "Cincuenta", "Sesenta", "Ochenta", "Noventa" };
            String[] centena = { "", "Cien", "Docientos", "Tresientos", "Cuatrocientos", "Quinientos", "Seisientos", "Setecientos", "Ochocientos", "Novecientos" };
            String[] especiales = { "", "Once", "Doce", "Trece", "Catorce", "Quince", "Diesiseis", "Diesisiete", "Dieciocho", "Diecinueve" };
            if (n > 10 && n < 20)
                tot = especiales[n % 10];
            else
            { if ((n % 100) % 10 == 0) tot = centena[n / 100] + " " + decena[(n % 100) / 10];
                else tot = centena[n / 100] + " " + decena[((n % 100) / 10)-1] + " y " + unidad[(n % 100) % 10];
            }
            return tot;
        }
        public String tabla(int n)
        {
            String x = "";
            for (int i = 0; i < 10; i++)
                x = n + " x " + i + " = " + (i * n) + "\n";
            return x;

        }
        public String bin(int n)
        {
            String bin = "";
            int aux = n;
            do
            {
                bin = aux % 2 + bin;
                aux = aux / 2;
            } while (aux>0);
            
            return bin;
        }

        public void num(int m)
        {
            String unidad = "";
            String decenta = "";
            
            switch (m%10)
            {
                case 0: unidad= "";
                    break;
                case 1:
                    unidad = "uno";
                    break;
                case 2:
                    unidad = "Dos";
                    break;
                case 3:
                    unidad = "Tres";
                    break;
                case 4:
                    unidad = "cuatro";
                    break;
                case 5:
                    unidad = "cinco";
                    break;
                case 6:
                    unidad = "seis";
                    break;
                case 7:
                    unidad = "siete";
                    break;
                case 8:
                    unidad = "ocho";
                    break;
                case 9:
                    unidad = "nueve";
                    break;
            }//Unidad
            switch (m/10)
            {
                case 0:
                    decenta = "";
                    break;
                case 1:
                    decenta = "Diez";
                    break;
                case 2:
                    decenta = "Veinte";
                    break;
                case 3:
                    decenta = "Treinta";
                    break;
                case 4:
                    decenta = "Cuarenta";
                    break;
                case 5:
                    decenta = "Cincuenta";
                    break;
                case 6:
                    decenta = "Sesenta";
                    break;
                case 7:
                    decenta = "Setenta";
                    break;
                case 8:
                    decenta = "Ochenta";
                    break;
                case 9:
                    decenta = "Noventa";
                    break;
                case 10:
                    decenta = "Cien";
                    break;
            }//Unidad
          
            if (m % 10 != 0)
            {
                if (m > 10 && m < 20)
                {
                    switch (m % 10)
                    {
                        case 1:
                            unidad = "Once";
                            break;
                        case 2:
                            unidad = "Doce";
                            break;
                        case 3:
                            unidad = "Trece";
                            break;
                        case 4:
                            unidad = "Catorce";
                            break;
                        case 5:
                            unidad = "Quince";
                            break;
                        case 6:
                            unidad = "Dieciseis";
                            break;
                        case 7:
                            unidad = "Diecisiete";
                            break;
                        case 8:
                            unidad = "Dieciocho";
                            break;
                        case 9:
                            unidad = "Diecinueve";
                            break;
                    }
                    MessageBox.Show(unidad);
                }
                else
                    MessageBox.Show(decenta + " y " + unidad);

            }
            else  MessageBox.Show(decenta + " " + unidad);
        }



    }
}
