using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertirTemperatura
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vScroll.Value = 100;
            vScroll.MaximumValue = 200;

            txtFare.Text = "32";
            txtCentigrados.Text = "0";
        }

        //farenheit 9/5*centigradp+32
        private void vScroll_ValueChanged(object sender, EventArgs e)
        {
            if (vScroll.Value <= 100)
            {
                txtCentigrados.Text = -1*(vScroll.Value - 100)+"";
            }
            else
                txtCentigrados.Text = -1* (vScroll.Value - 100) + "";


            
            txtFare.Text =((9.0 / 5.0) *(Double.Parse(txtCentigrados.Text)))+32+"";
           
        }
    }
}
