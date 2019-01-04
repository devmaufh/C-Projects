using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Promedios_DGV
{
    public partial class Grafico : Form
    {
        List<String> names;
        List<int> promedio;
        public Grafico(List<int> calif, List<String> name)
        {
            InitializeComponent();
            names =name;
            promedio = calif;
        }

        private void c_graf_Click(object sender, EventArgs e)
        {

        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            G_Desv_Est.Series.Clear();
            G_Desv_Est.Titles.Clear();
            G_Desv_Est.Titles.Add("Promedios");
            for (int i = 0; i<promedio.Count; i++)
            {

                Series series = G_Desv_Est.Series.Add(names[i]);
                series.ChartType = SeriesChartType.RangeColumn;
                series.Label = promedio[i] + "";
                series.Points.Add(promedio[i]);
            }
           
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            G_Desv_Est.Printing.PrintPreview();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
