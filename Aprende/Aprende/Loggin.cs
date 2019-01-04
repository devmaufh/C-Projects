using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprende
{
    public partial class Loggin : Form
    {
        public int xClick = 0, yClick = 0; //Mover form
        public String user = "",pass="";
        void limpiaTodo()
        {
            user = pass = "";
            txtCorreo.ResetText();
            txtPass.ResetText();
        }
        public Loggin()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNoCuenta_Click(object sender, EventArgs e)
        {
            new registro().Show();
            this.Hide();
        }

        public Form1 f1 = new Form1();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            user = txtCorreo.Text;
            pass = txtPass.Text;
            if (verificaCampos(user) && verificaCampos(pass))
            {
                if (new Consultas().validaPass(user, pass))
                {

                    //Logeado
                    f1.user = user;
                    f1.pass = pass;
                    //
                    
                    limpiaTodo();
                    
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    //Error
                    lblError.Text = "Usuario o contraseña incorrectos";
                    lblError.Visible = true;
                }
            }
            else
            {
                //MessageBox.Show("Error");
            }
        }

        private void Loggin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        Boolean verificaCampos(String cadena)
        {
            if (cadena.Length == 0 || cadena.Equals("Nombre completo")
                || cadena.Equals("Escuela") || cadena.Equals("Correo")
                || cadena.Equals("Contraseña"))
            {
                lblError.Text = "Llene correctamente los campos";
                lblError.Visible = true;
                return false;
            }
            else
            {
                lblError.Visible = false;
                return true;
            }
        }
    }
}
