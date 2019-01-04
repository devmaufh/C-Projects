using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Programa3_Orak
{
    public partial class Form1 : Form
    {
        
        void Tema(Color color, Color primary)
        {
            
            Barra.BackColor = color;
            lbl1.ForeColor = primary;

            txtEntrada.ForeColor = color;
            txtEntrada.LineFocusedColor = color;
            txtEntrada.LineIdleColor = color;
            txtEntrada.LineMouseHoverColor = color;

            btnCalcula.BackColor = color;
            btnCalcula.Normalcolor = color;
            btnCalcula.OnHovercolor = color;
            btnCalcula.Activecolor = color;

            ListaResul.ForeColor = color;

            lblTema.ForeColor = color;

            btnCierra.BackColor = color;

            lblResul.ForeColor = color;
            Temas.BackColor = color;
            Temas.NomalColor = color;
            Temas.onHoverColor = color;
            
        }
    
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Boolean primo(int n)
        {
            int count = 0;
            for(int i = 2; i <n; i++)
                if (n%i == 0)
                    count++;
            return count > 0;
        }

        void Agrega(ListBox lb,int n)
        {
            for (int i = 2; i < n; i++)
                if (n%i == 0)
                    lb.Items.Add(i + "");
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {


                ListaResul.Items.Clear();
                int n = Convert.ToInt32(txtEntrada.Text);
                if (n > 0)
                {
                    if (n==2|!primo(n))
                    {
                        lblResul.Text = "Número primo";
                    }
                    else
                    {
                        Agrega(ListaResul, n);
                        lblResul.Text = "Número par";
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese solo números positivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese datos válidos", "Error",MessageBoxButtons.OK ,MessageBoxIcon.Question);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           int x=(int) MessageBox.Show("¿Seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == 6) Application.Exit();
        }

        int xClick, yClick;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void bunifuCustomLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Temas_onItemSelected(object sender, EventArgs e)
        {
            if (Temas.selectedIndex == 0)
            {
                Tema(Color.Brown, Color.IndianRed);
            }
            if (Temas.selectedIndex == 1)
            {
                Tema(Color.SeaGreen, Color.DarkSeaGreen);
            }
            if (Temas.selectedIndex == 2)
            {
                Tema(Color.Teal,Color.DarkSlateGray);
            }
            if (Temas.selectedIndex == 3)
            {
                Tema(Color.Indigo, Color.BlueViolet);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
