using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Programa2_xd
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       void TablaM(ListBox x, int n)
        {
            List<String> lista = new List<string>();

            for(int i = 1; i <= 10; i++)
            {
                x.Items.Add(n+" * "+i+" ="+(n*i)+"");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                lblMulti.Items.Clear();
                int n = Convert.ToInt32(txtTabla.Text);
                TablaM(lblMulti, n);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            int x=(int)MessageBox.Show("¿Seguro que deseas salir?", "SALIR", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (x == 6) Application.Exit();
            
        }

    }
}
