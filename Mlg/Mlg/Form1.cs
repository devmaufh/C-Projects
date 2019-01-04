using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework;


namespace Mlg
{
    public partial class menu : Form
    {
        public int xClick = 0, yClick = 0;
        public menu()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
                if (e.Button != MouseButtons.Left)
                { xClick = e.X; yClick = e.Y; }
                else
                { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
            
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            
        }

        private void menu_Load(object sender, EventArgs e)
        {
            //Load Form
            int[] puntos = {10,50,100 };
            String[] series = {"1 mes","3 meses","más de 3"};
            chart1.


        }

        public void setColorText(Bunifu.Framework.UI.BunifuFlatButton boton) 
        {
            boton.Textcolor = Color.FromArgb(45, 45, 48);
        }
        public void resetColorText(Bunifu.Framework.UI.BunifuFlatButton boton)
        {
            boton.Textcolor = Color.FromArgb(242, 41, 48);
        }

    }
}
