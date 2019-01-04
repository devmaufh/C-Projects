using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_programa_Residui
{
    public partial class Form1 : Form
    {
        public int xClick = 0, yClick = 0; //Mover form

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtCantidad.Text) > 0)
            {
                Residuo r = new Residuo(Convert.ToInt32(txtCantidad.Text));
                r.calcula();
                for (int i = 0; i < r.resultado.Length; i++)
                {
                    if (i <= 6)
                    {
                        lvResultado.Items.Add(r.resultado[i] + "\t billete(s) de \t" + r.datos[i] + "$");
                    }
                    else
                        lvResultado.Items.Add(r.resultado[i] + "\t monedas de \t" + r.datos[i] + "$");
                }
            }
            else
                MessageBox.Show("Ingrese un valor válido");
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void txtCantidad_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
