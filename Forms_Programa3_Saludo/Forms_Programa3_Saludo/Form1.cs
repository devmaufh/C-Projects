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
namespace Forms_Programa3_Saludo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            

        }

        private void txtEdad_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtEdad_OnValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(txtEdad.Text) < 18 && Convert.ToInt16(txtEdad.Text) >= 16)
                {
                    checkPermiso.Visible = true;
                    lblPermiso.Visible = true;
                }
                else
                {
                    checkPermiso.Visible = false;
                    lblPermiso.Visible = false;
                }

            }
            catch (Exception)
            {

            }
        }
        int aux = 0;
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            aux++;
            if (aux % 2 == 0)
                checkPermiso.Checked = true;
            else
                checkPermiso.Checked = false;

        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            try
            {
                int edad = (int)Math.Truncate(Convert.ToDouble(txtEdad.Text));
                if (edad > 0 && edad <= 130)
                {
                    if (ver(Convert.ToInt32(edad)))
                    {
                        MessageBox.Show(txtName.Text + " sí puede conducir");
                    }
                }
                else
                    MessageBox.Show(txtName.Text + "Ingrese una edad válida y apta para conducir");
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese valores válidos");
            }


        }
        Boolean ver(int edad)
        {
            if (edad >= 16 && edad < 18&&checkPermiso.Checked)
            {
                return true;
            }

            else
            {
                if (edad >= 19)
                    return true;
                else return false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
