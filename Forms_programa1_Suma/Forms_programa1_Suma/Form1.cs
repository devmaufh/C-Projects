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

namespace Forms_programa1_Suma
{
    public partial class Form1 : Form
    {
        public int xClick = 0, yClick = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNum1.Text = "";
            this.txtNum2.Text = "";
            this.txtResul.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        double ObtieneNum(Bunifu.Framework.UI.BunifuMetroTextbox txt)
        {
            return Convert.ToDouble(txt.Text);
        }


       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click_1(object sender, EventArgs e)
        {

            try
            {
                double r = ObtieneNum(txtNum1) + ObtieneNum(txtNum2);
                txtResul.Text = r + "";
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que los datos ingresados sean validos");
            }
        }

        private void btnResta_Click_1(object sender, EventArgs e)
        {
            try
            {
                double r = ObtieneNum(txtNum1) - ObtieneNum(txtNum2);
                txtResul.Text = r + "";
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que los datos ingresados sean validos");
            }
        }

        private void btnMultiplicacion_Click_1(object sender, EventArgs e)
        {
            try
            {
                double r = ObtieneNum(txtNum1) * ObtieneNum(txtNum2);
                txtResul.Text = r + "";
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que los datos ingresados sean validos");
            }
        }






        private void btnDivision_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                if (ObtieneNum(txtNum2) != 0)
                {
                    double r = ObtieneNum(txtNum1) / ObtieneNum(txtNum2);
                    txtResul.Text = r + "";
                }
                else
                {
                    MessageBox.Show("Verifique el dividendo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que los datos ingresados sean validos");
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        Func<double, double, double> operaciones;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
