using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsgGrados_Flores_Mauricio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void celsiusFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void celsiusFahrenheitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToInt16(txtGrado.Text);
                txtResult.Text = new Operacion(x).fa() + "";
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese valores válidos a las cajas de texto");
            }
        }
    }
}
