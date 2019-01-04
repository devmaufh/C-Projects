using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion
{
    public partial class Form1 : Form
    {
        funciones func= new funciones();
        String cadenaconexion = "Server=localhost;Database=master;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            func.connect();
        }

        private void btnDesconnect_Click(object sender, EventArgs e)
        {
            func.cierra();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(func.Existe(txtUser.Text)==0) func.registra(txtName.Text, txtUser.Text, txtPassword.Text);
            else { MessageBox.Show("User existe"); }
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            func.buscar(txtUser.Text, txtPassword.Text);
        }
    }
}
