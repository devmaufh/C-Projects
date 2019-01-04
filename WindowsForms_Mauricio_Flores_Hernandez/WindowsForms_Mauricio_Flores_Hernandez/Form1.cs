using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Mauricio_Flores_Hernandez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            listad.Items.Clear();//Limpia el listbox
            int a = Convert.ToInt32(txtA.Text); //Guarda el valor del textbox txtA en variable llamada A
            int b = Convert.ToInt32(txtB.Text);//Hace lo mismo que la linea de arriba pero con el textBox txtB
            if (a >= 0 && b >= 0)
            {
                if (a > b)//Verifica si a es mayor a b
                { //Si entra a esta parte, entonces a es mayor a b
                    int x = a; //guarda elvalor de a en una varibale auxiliar llamada X
                    a = b; //Guardo el valor de b en la variable A
                    b = x; //GUardo el valor de la variable x en b(Osea el valor de x era el que tenía a inicialmente), graciasa esto, es posible hacer el intercambio

                }
                int suma=0;
                for (int i = a; i <= b; i++)//Inicia un ciclo for desde la variable a, y termina cuando llega al valor de la variable b
                {
                    if (i % 5 == 0)
                    {//Verifica que si divide el valor que va tomando i entre 5 y el residuo da 0, quiere decir que sí es un miltiplo
                     //Si el residuo da algún valor diferente a cero,no es multiplo
                        suma += i;
                     listad.Items.Add(i + "");
                        //Cuado entra a esta condición, ya tiene por hecho aue el valor de i es multiplo de 5
                        //Así que lo guarda en el listbox llamado listad
                       
                    }
                    txtSuma.Text = "" + suma;
                }
            }
            else MessageBox.Show("No puedes ingresar valores negativos");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtA.Text = ""; //Limpia los textbox y el listbox
            txtB.Text = "";
            listad.Items.Clear();
        }
    }
}
