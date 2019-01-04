using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
namespace Segundo_Programa1_Estacionamiento
{
    public partial class Form1 : Form
    {
       
        operaciones calculos;
        public int xClick = 0, yClick = 0;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToShortDateString() + "";
        }
       
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                calculos = new operaciones(Convert.ToDouble(txtEn.Text), Convert.ToDouble(txtS.Text));
                if (calculos.validado()&&!(calculos.entrada>calculos.salida))
                {
                    calculos.calcula();
                    lblResul.Text = "$" + calculos.monto;
                    lblEntrada.Text = "Hora de entrada:\nHora de salida:";
                    lblSalida.Text = calculos.entrada + "\n" + calculos.salida;
                    lblEstancia.Text = "Duración: " + calculos.hora_Estancia() + " " + calculos.minutos_Estancia();
                    HideElements(true);
                }
                else
                {
                    MessageBox.Show("Ingrese datos válidos.");
                }

            }
            catch (Exception)
            {
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
        }

        private void bunifuGauge1_Load(object sender, EventArgs e)
        {

        }

        private void switchTema_Click(object sender, EventArgs e)
        {
        // Tema(Color.FromArgb(47, 44, 56), Color.FromArgb(240, 96, 96), Color.FromArgb(55, 52, 66));
        }

        private void Barra_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Barra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HideElements(false);
            txtEn.Text = "";
            txtS.Text = "";
            txtEn.HintText = "Entrada";
            txtS.HintText = "Salida";
        }
        
        void HideElements(Boolean valor)
        {
            lblEntrada.Visible = valor;
            lblEstancia.Visible = valor;
            lblPPagar.Visible = valor;
            lblResul.Visible = valor;
            lblSalida.Visible = valor;
            btnNuevo.Visible = valor;
            lblFecha.Visible = valor;
        }
    }
}
