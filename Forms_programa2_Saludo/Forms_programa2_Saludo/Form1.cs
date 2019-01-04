using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_programa2_Saludo
{
    public partial class Form1 : Form
    {
        public int xClick = 0, yClick = 0; //Mover form
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {


        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "Hola "+txtName.Text+" Bienvenido a C#";
            MessageBox.Show(lblMostrar.Text);
            this.BackColor = Color.DimGray;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "";
            txtName.Clear();
            this.BackColor = Color.White;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
