using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LibSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utils.ChangeColorButtons(btnLogin);
            String path = @"c:\images";
            try
            {
                if (!Directory.Exists(path))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String correo = txtCorreo.Text;
            String password = txtPassword.Text;
            if (Operaciones.VerifyString(correo)&&Operaciones.VerifyString(password))
            {
                if (new Operaciones().Login(correo, password))
                {
                    Home h=new Home(correo);
                    h.Show();
                    this.Hide();

                }
                else MessageBox.Show("Datos incorrectos");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public int xClick = 0, yClick = 0;

        private void bunifuGradientPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
