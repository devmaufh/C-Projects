using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_fechas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            txtDia.Text = dia_es(DateTime.Now.DayOfWeek + "");
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
            txtHora.Text = DateTime.Now.Hour.ToString() + ":" +
                DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();

            

        }

        private void dateP2_onValueChanged(object sender, EventArgs e)
        {
            txtNuevaFecha.Text = dateP2.Value.ToLongDateString() + "";

        }

        private void dateP1_onValueChanged(object sender, EventArgs e)
        {
            txtDia.Text = dia_es(dateP1.Value.DayOfWeek + "");
        }
        String dia_es(String n)
        {
            switch (n)
            {
                case "Monday": return "Lunes";
                case "Tuesday":return "Martes";
                case "Wednesday": return "Miercoles";
                case "Thursday": return "Jueves";
                case "Friday": return "Viernes";
                case "Saturday": return "Sábado";
                case "Sunday": return "Domingo";
            }
            return "";
        }
    }
}
