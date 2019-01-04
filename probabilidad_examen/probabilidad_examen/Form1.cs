using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probabilidad_examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int entrada, salida; //Variables para guardar la entrada y la salida
            entrada = Convert.ToInt32(txtEntrada.Text);//Convierte el valor de la caja de texto de la entrada y lo almacena en variable
            salida = Convert.ToInt32(txtSalida.Text);//Hace lo mismo que la linea de arriba pero con la salida
            double horas_aux = (salida - entrada); //Hace el calculo de las horas de estadía
            //MessageBox.Show(horas_aux/100 + "");
            int totalHoras = Convert.ToInt32(Math.Ceiling(horas_aux/100));
            //MessageBox.Show(totalHoras+"");
            //La linea de arriba, lo que hace es que redondea al decimal más proximo, es decir, si en horas sale de resultado
            // 1.7, entonces ya redondeado es igual a 2, ya que el problema dice "Inicializada una hora, se cuenta"

            if (totalHoras > 1)//Si las horas son mayores a 1 se tomará la primera hora en 10 pesos y las demas en 6 pesos
            {
                int costo = totalHoras - 1;//Se le resta ya que como son más de 1 hora, este valor se multiplicará por 6
                //y se le sumarán los 10 pesos de la hora incial, (por eso se hizo la resta de una hora que fue la inicial)
                int total = costo * 6 + 10;
                txtResultado.Text = total + "";//Se muestra en el resultado
            }
            else
            {
                int to = totalHoras * 10;
                txtResultado.Text = to + "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
