using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Programa_MENU
{
    public partial class Form1 : Form
    {
        public int xClick = 0, yClick = 0;
        Operaciones op = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Operaciones().num(17);
            new Operaciones().num(31);
            new Operaciones().num(45);
            new Operaciones().num(87);
            new Operaciones().num(48);
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lblAccion.Text = "Factorial: ";
                lblResultado.Text = op.factorial(Convert.ToInt32(txtNum.Text)) + "";

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese datos validos");
            }
        }

        private void cubiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lblAccion.Text = "Cubo: ";
                lblResultado.Text = op.cubo(Convert.ToInt32(txtNum.Text)) + "";

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese datos validos");
            }
        }

        private void primoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                lblAccion.Text = "El número que ingresó es: ";
                int n = Convert.ToInt32(txtNum.Text);
                if (n == 2 | !op.primo(n))
                {
                    lblResultado.Text = "Número primo";
                }
                else
                {
                    lblResultado.Text = "Número par";
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese datos validos");
            }
        }

        private void númeroALetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lblAccion.Text = "Número a letra: ";
                lblResultado.Text = op.letra(Convert.ToInt32(txtNum.Text)) + "";
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese datos válidos");
            }
        }

        private void seaGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            indigoToolStripMenuItem.Checked = false;
            darkSlateBlueToolStripMenuItem.Checked = false;
            tema(Color.SeaGreen);
        }

        private void indigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seaGreenToolStripMenuItem.Checked = false;
            darkSlateBlueToolStripMenuItem.Checked = false;
            tema(Color.Indigo);
        }

        private void darkSlateBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seaGreenToolStripMenuItem.Checked = false;
            indigoToolStripMenuItem.Checked = false;
            tema(Color.DarkSlateBlue);
        }

        private void txtNum_Click(object sender, EventArgs e)
        {
        }

        private void btnSalit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void binarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblAccion.Text="Binario";
            lblResultado.Text = op.bin(Convert.ToInt32(txtNum.Text)); 
        }

        void tema(Color x)
        {
            menuStrip1.BackColor = x;

            txtNum.LineFocusedColor = x;
            txtNum.LineIdleColor = x;
            txtNum.LineMouseHoverColor = x;
            txtNum.ForeColor = x;

            bunifuCards1.color = x;

            lblAccion.ForeColor = x;
            lblResultado.ForeColor = x;
        }
        
    }
}
