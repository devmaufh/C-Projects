using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSoft
{
    public partial class Home : Form
    {
        public int xClick = 0, yClick = 0;
        String username;
        public Home(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Libros lb = new Libros(username);
            lb.Show();
        }

        private void btnPeticiones_Click(object sender, EventArgs e)
        {
            new Peticiones().Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            new reporte1().Show();
        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
