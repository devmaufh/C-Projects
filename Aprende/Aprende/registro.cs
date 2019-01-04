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
    public partial class registro : Form
    {
        public int xClick = 0, yClick = 0; //Mover form
        String nombre = "", escuela = "", correo = "", pass = "";

        void limpiaCampos()
        {
            nombre = escuela = correo = pass = "";
            txtCorreo.ResetText();
            txtEscuela.ResetText();
            txtNombre.ResetText();
            txtPass.ResetText();
        }
        Boolean verificaCampos(String cadena)
        {
            if (cadena.Length == 0||cadena.Equals("Nombre completo")
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

        public registro()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Loggin().Show();
        }

        private void registro_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            escuela = txtEscuela.Text;
            correo = txtCorreo.Text;
            pass = txtPass.Text;

            if (verificaCampos(nombre) && verificaCampos(escuela) &&
                verificaCampos(correo) && verificaCampos(pass)) //condición
            {
                if(new Consultas().validaUser(correo))
                {
                    lblError.Text = "Ya existe un usuario con ese correo";
                    lblError.Visible = true;
                    txtCorreo.Text = "";
                }
                else
                {
                    //Si registra
                    //Query = "insert into usuarios(nombre, escuela, contraseña, user) values('Test01','TestSchool','pass','Maincasra');";
                    String query = "insert into usuarios(nombre,escuela,contraseña,user) values ('" + nombre + "','" + escuela + "','" + pass + "','" + correo + "');";
                    new Consultas().Inserta(query);

                    Form1 f1 = new Form1();
                    f1.user = correo;
                    f1.pass = pass;

                    limpiaCampos();
                    f1.Show();
                }

            }
            


        }
    }
}
