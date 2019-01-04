using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_programa2_Triangulo
{
    public partial class Form1 : Form
    {
        public int xClick = 0, yClick = 0;
        double bas = 0, altura = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public double calculaLado()
        {
            
            double a = bas / 2;
            double resultado = Math.Sqrt(a * a + altura * altura);
            return resultado;//Math.Pow(a,2)+Math.Pow(bas,2)
        }
        public Double Perimetro()
        {
            return (calculaLado() * 2) + bas;
        }
        public Double area()
        {
            return (bas * altura) / 2;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Separador.Visible = true;
                bas = Convert.ToDouble(txtBase.Text);
                altura = Convert.ToDouble(txtAltura.Text);
                lblArea.Text = Math.Truncate(area() * 100) / 100 + "";
                lblPerimetro.Text =Math.Truncate(Perimetro()*100)/100 + "";
                Triangulo((int)bas,(int)altura);

                lblError.Visible = false;
                lblA.Visible = true;
                lblP.Visible = true;


            }
            catch (Exception)
            {
                lblError.Text = "Rellene correctamente los campos de texto";
                lblError.Visible = true;
                                
            }
        }

        void Limpia()
        {
            bas = altura = 0;
            lblArea.Text = "";
            lblPerimetro.Text = "";
            txtAltura.Text = "";
            txtBase.Text = "";
            lblA.Visible = false;
            lblP.Visible = false;
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
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpia();
            pbImagen.Image = null;
            Separador.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }

        private void pbImagen_Paint(object sender, PaintEventArgs e)
        {
            //REFRESCAAAAA :v
            Triangulo((int)bas, (int)altura);
        }
        
        
        public void Triangulo(int x, int altura)
        {
            Graphics g;
            g = pbImagen.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.SeaGreen);
            Point[] P = {new Point((150-x),180),new Point((150+x),180), new Point(150,200-altura)};
            g.FillPolygon(brush,P);
            g.DrawString("Base: " + x, txtAltura.Font, brush, 120, 185);

        }
    }
}
