using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedios_DGV
{
    public partial class Grafico_2 : Form
    {
        List<int> calif = new List<int>();
        public Grafico_2(List<int> promedios)
        {
            InitializeComponent();
            calif = promedios;
        }
        //680/calif.count;
        //68-225
        private void Grafico_2_Load(object sender, EventArgs e)
        {
            txt10.Width = n_10(calif,10)*30;
            txt9.Width = n_10(calif, 9)*30;
            txt8.Width = n_10(calif, 8)*30;
            txt7.Width = n_10(calif, 7)*30;
            txtNA.Width = na(calif)*30;
            for (int i = 1; i < mayor; i++)
            {
                lbln.Text += "  "+(i+1) ;
            }
          
            
            
           // MessageBox.Show(mayor + ": Mayor");
        }
        int mayor = 0;
        int n_10(List<int> lista, int n)
        {
            
            int c = 0;
            for (int i = 0; i < lista.Count; i++)
                if (Math.Floor(Convert.ToDouble(lista[i]/10))>=n&& Math.Floor(Convert.ToDouble(lista[i]/10)) <= n)
                    c++;
            if (c > mayor)
                mayor = c;
            return c;
        }
        int na(List<int> l)
        {
            int c = 0;
            for (int i = 0; i <l.Count; i++)
            {
                if (Math.Floor((double)l[i]/10) < 7)
                    c++;
            }
            if (c > mayor)
                mayor = c;
            return c;
        }

        private void txt10_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt9_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt8_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
