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
    public partial class Porcentajes : Form
    {
        int ap = 0;int r = 0;
        public Porcentajes(int aprobacion, int reprobacion)
        {
            InitializeComponent();
            ap = aprobacion;r = reprobacion;
        }

        private void Porcentajes_Load(object sender, EventArgs e)
        {
            aprobacion.Value = ap;
            reprobacion.Value = r;
            
        }
    }
}
