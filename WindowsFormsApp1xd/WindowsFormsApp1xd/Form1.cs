using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1xd
{
    public partial class Form1 : Form
    {
        Consultas consulta = new Consultas();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            consulta.conecta();
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistroLibros_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {

        }

        private void btnAutores_Click(object sender, EventArgs e)
        {

        }
    }
}
