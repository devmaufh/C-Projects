using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Programa4_Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        long factorial(long n)
        {
            if (n == 0)
                return 1;
            else {
                return factorial(n - 1) * n;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtFact_OnValueChanged(object sender, EventArgs e)
        {
           
        }
        void fact(int n, ListBox lb)
        {
            long x = 1;
            String aux =n+"";
            for (int i=n;i>=1;i--)
            {
                x *= i;
                if (i == n)
                {
                   // aux = n + " x ";
                }
                else
                {
                    aux = aux + " x " + i;
                    if (n == 1)
                    {
                        aux = aux + i;
                    }
                    lb.Items.Add(aux + " = " + Math.Abs(x));
                }
                
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("Kionda puerkita, este es el factorial :v"+lista.SelectedItem);
        }

        private void btnAcepta_Click(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(txtFact.Text) <= 40)
                {
                    lista.Items.Clear();
                    fact(Convert.ToInt32(txtFact.Text), lista);
                    
                }
                else
                {
                    MessageBox.Show("Error de desbordamiento, ingrese valores menores a 40");
                }
            }
            catch (Exception)
            {
            }
        }

        private void cbTema_onItemSelected(object sender, EventArgs e)
        {
            if (cbTema.selectedIndex == 1)
                tema(Color.DarkSlateBlue);

            
            if (cbTema.selectedIndex == 2)
                tema(Color.SeaGreen);
            if (cbTema.selectedIndex == 3)
                tema(Color.Teal);
            

        }

        void tema(Color primary)
        {
            btnAcepta.Activecolor = primary;
            btnAcepta.Normalcolor = primary;
            btnAcepta.OnHovercolor = primary;

            txtFact.ForeColor = primary;
            txtFact.LineFocusedColor = primary;
            txtFact.LineIdleColor =primary;

            lista.ForeColor = primary;
            panel1.BackColor = primary;
            cierrfac.BackColor = primary;

            cbTema.NomalColor = primary;
            cbTema.onHoverColor = primary;
        }
    }
}
