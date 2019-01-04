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
   
    public partial class Form1 : Form
    {
        public List<int> promedio = new List<int>();
        public List<String> names = new List<string>();
        Op prueba1 = new Op();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtCalificacion.Text != "")
            {
                try
                {
                    Convert.ToInt16(txtCalificacion.Text);
                    insertar(txtName.Text, txtCalificacion.Text);

                    {
                        //In-time
                        gauge_Promedio.Value = Convert.ToInt32(prueba1.prom(promedio));
                        //_________________
                        Gauge_Max.Value = Convert.ToInt32(prueba1.max(promedio));
                        lblMax_Name.Text = names[prueba1.getPositionMax()];
                        //_________________
                        gauge_Min.Value = Convert.ToInt32(prueba1.min(promedio));
                        lblMin_name.Text = names[prueba1.getPositionMin()];
                        //________________
                        panel_promedio.Visible = false;
                        panel_Max.Visible = false;
                        panel_Min.Visible = false;
                        graf();
                        panel_Desviaci.Visible = true;
                    }
                    txtName.Text = "";
                    txtCalificacion.Text = "";
                   // MessageBox.Show(prueba1.prom());

                }
                catch (Exception)
                {

                    MessageBox.Show("Ingrese valores válidos");
                }
                
            }
            else
            {
                MessageBox.Show("Rellene todos los campos");
            }
        }
        public void insertar(String name, String calif)
        {
            dgvDatos.Rows.Add(name, calif);
            names.Add(name);
            promedio.Add(Convert.ToInt16(calif));
        }

        private void btnProm_Click(object sender, EventArgs e)
        {
            try
            {
                panel_Desviaci.Visible = false;
                panel_Max.Visible = false;
                panel_Min.Visible = false;
                gauge_Promedio.Value = Convert.ToInt32(prueba1.prom(promedio));
                panel_promedio.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Debe ingresar valores primero");
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
           
            try
            {
                panel_Desviaci.Visible = false;
                panel_Min.Visible=false;
                panel_promedio.Visible = false;
                Gauge_Max.Value = Convert.ToInt32(prueba1.max(promedio));
                lblMax_Name.Text = names[prueba1.getPositionMax()];
                panel_Max.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Debe ingresar valores primero");
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            try
            {
                panel_Desviaci.Visible = false;
                panel_promedio.Visible = false;
                panel_Max.Visible = false;
                gauge_Min.Value = Convert.ToUInt16(prueba1.min(promedio));
                lblMin_name.Text = names[prueba1.getPositionMin()];
                panel_Min.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Debe ingresar valores primero");
            }

           
        }

        public void graf()
        {
            G_Desv_Est.Series.Clear();
            G_Desv_Est.Titles.Clear();
            G_Desv_Est.Titles.Add("Promedios");
        
          
          

            for (int i = 0; i < names.Count; i++)
            {
                Series series = G_Desv_Est.Series.Add(names[i]);
                series.Label = promedio[i] + "";
                series.Points.Add(promedio[i]);
                series.ChartType = SeriesChartType.Column;
            }
            
        }
        private void dEst_Click(object sender, EventArgs e)
        {
                panel_promedio.Visible = false;
                panel_Max.Visible = false;
                panel_Min.Visible = false;
                graf();
                panel_Desviaci.Visible = true;
            lbl_Desv_Estandar.Text = "Desviación estandar: "+prueba1.d_estandar(prueba1.varianza(promedio, prueba1.prom(promedio)))+"";
            
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_Desviaci_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGraficoCompleto_Click(object sender, EventArgs e)
        {
            Porcentajes p = new Porcentajes(Ap(),100-Ap());
            p.Visible = true;
        }

        private void G_Desv_Est_Click(object sender, EventArgs e)
        {
            Grafico formgraf = new Grafico(promedio, names);
            formgraf.Visible = true;
        }

        private void btnGrafico2_Click(object sender, EventArgs e)
        {
            Grafico_2 g2 = new Grafico_2(promedio);
            g2.Visible = true;
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                promedio.Add(100 - i);
                names.Add("Dato: " + i);

            }
        }

        private void lbl_Desv_Estandar_Click(object sender, EventArgs e)
        {

        }
        int  Ap()
        {
            int c = 0;
            for (int i = 0; i < promedio.Count; i++)
                if (promedio[i] >= 70)
                    c++;

            return (c * 100) / promedio.Count;
        }
    }
}
