using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
namespace Notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            int x = 30;
            for (int i = 0; i < 14; i++)
            {
                card(x);
                x = x + 160;
            }
            
        }
        private void circulaButton1_MouseHover(object sender, EventArgs e)
        {
        }

        private void circulaButton1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        Bunifu.Framework.UI.BunifuCards card(int x)
        {
            Bunifu.Framework.UI.BunifuCards nota = new Bunifu.Framework.UI.BunifuCards();
            nota.color = colorA();
            nota.LeftSahddow = true;
            nota.ShadowDepth = 50;
            nota.SetBounds(20,x,260,150);
            Controles.Controls.Add(nota);
            return nota;
        }
        Color colorA()
        {
            Random r = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor rColorName = names[r.Next(names.Length)];
            Color rColor = Color.FromKnownColor(rColorName);
            return rColor;
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
