using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convierte
{
    public partial class Convert : Form
    {

        public Convert()
        {
            InitializeComponent();
        }

        private void txtConversion_OnTextChange(object sender, EventArgs e)
        {
            
            try
            {
                double euro = Double.Parse(txtTasaEuro.text);
                double dolar = Double.Parse(txtTasaDolar.text);
                lblDolar.Text = Math.Truncate(convierte(Double.Parse(txtConversion.text), dolar)*100)/100 +"";
                lblEuro.Text = Math.Truncate(convierte(Double.Parse(txtConversion.text), euro)*100)/100 + "";

            }
            catch (Exception)
            {
                lblDolar.Text = "";
                lblEuro.Text = "";
              
            }
        }
        double convierte(double peso, double moneda)
        {
            return peso / moneda;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
