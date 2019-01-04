using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms4_Conversión
{
    public partial class Form1 : Form
    {
        String t;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSAlir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConversión.Text = "";
            txtR.Text = "";
            lblUnidades.Text = "";
            rbKilómetros.Checked = false;
            rbCen.Checked = false;
            rbMilimetro.Checked = false;
            rbMilla.Checked = false;

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                txtR.Text =calcula(txtConversión)+"" ;
                lblUnidades.Text = t;
                
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese solamente valores numericos");
            }
        }

        private void txtConversión_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int conversion = 0;

        private void rbMilimetro_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbMilimetro_Click(object sender, EventArgs e)
        {
            conversion = 1;
        }

        private void rbMetros_Click(object sender, EventArgs e)
        {
            conversion = 2;
        }

        private void rbKilómetros_Click(object sender, EventArgs e)
        {
            conversion = 3;
        }

        private void rbMilla_Click(object sender, EventArgs e)
        {
            conversion = 4;
        }

        Double calcula(TextBox txt)
        {
            Double x = Convert.ToDouble(txt.Text);
            double r = 0;
            switch (conversion)
            {
                case 1:t = "Milimetros"; r = x * 1000;break;
                case 2:t = "Centimetros"; r = x * 100;break;
                case 3:t = "Kilometros"; r = x / 1000;break;
                case 4:t = "Millas"; r = x / 1609;break;
                
            }
            return r;

        }
    }
}
