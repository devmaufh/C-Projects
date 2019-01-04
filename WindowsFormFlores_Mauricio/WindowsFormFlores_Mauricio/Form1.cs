using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace WindowsFormFlores_Mauricio
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

        double valor_raiz(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
        
       double resultado(double a, double b, double raiz)
        {
            return (-b + raiz) / (2 * a);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double a = convierteCaja(txtA);
                double b = convierteCaja(txtB);
                double c = convierteCaja(txtC);
                if (valor_raiz(a, b, c) > 0)
                {
                    txtX1.Text = resultado(a, b, Math.Sqrt(valor_raiz(a, b, c)))+"";
                    txtX2.Text = resultado(a, b,-Math.Sqrt(valor_raiz(a, b, c))) + "";
                }
                else
                {
                    //No hay solucion
                    MessageBox.Show("No hay solucion real");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese valores válidos");
            }
        }
        double convierteCaja(Bunifu.Framework.UI.BunifuMetroTextbox txt)
        {
            return Convert.ToDouble(txt.Text);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
