using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lirusisa
{
    public partial class Form1 : Form
    {
        String pan, ingredientes, tamaño, servicio;
        double precion = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            servicio=pan = ingredientes = tamaño = "";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            precion = Convert.ToInt16(txtCantidad.Text)*(tamaño_Pizza()+cost_ingredientes());
            tipo_pan();
            tipo_serv();
            MessageBox.Show("Nombre:  "+txtName.Text+"" +
                "\nCantidad:  "+txtCantidad.Text+"" +
                "\nIngredientes:\t"+ingredientes+"" +
                "\nTipo de pan:  "+pan+"" +
                "\nTamaño:  "+tamaño+"" +
                "\nServicio:  "+servicio+"" +
                "\nTotal a pagar:  $8"+precion);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)&&!char.IsControl(e.KeyChar))
                e.Handled = true;
            else e.Handled = false;

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;

        }
        public int cost_ingredientes()
        {
            ingredientes = "";
            int n =0;
            if (checkCebolla.Checked) { n++;ingredientes += "Cebolla"; }
            if (checkAjo.Checked) { n++; ingredientes += "\n\t\tAjo"; }
            if (checkMorron.Checked) { n++; ingredientes += "\n\t\tMorrón"; };
            if (checkQuesoExtra.Checked) { n++; ingredientes += "\n\t\tQueso extra"; }
            if (checkPeperoni.Checked) { n++; ingredientes += "\n\t\tPeperoni"; }
            if (checkJamon.Checked) { n++; ingredientes += "\n\t\tJamón"; }
            if (checkChampi.Checked) { n++; ingredientes += "\n\t\tChampiñones"; }
            if (checkSalami.Checked) { n++; ingredientes += "\n\t\tSalami"; }

            if (n > 3) return (n - 3) * 10;
            else return 0;
        }
        public int tamaño_Pizza()
        {
            int precio = 0;
            if (rbGrande.Checked)
            {
                precio = 150;
                tamaño = "Grande";
            }
            if (rbMediana.Checked)
            {
                precio = 100;
                tamaño = "Mediana";
            }
            if (rbChica.Checked)
            {
                precio = 80;
                tamaño = "Chica";
            }
            return precio;
        }
        public void tipo_pan()
        {
            if (rbpan_crujiente.Checked)pan="Crujiente";
            if (rbpan_delgado.Checked)pan="Delgado";
            if (rbpan_OrillaQueso.Checked) pan = "Orilla de queso";
        }
        public void tipo_serv()
        {
            if (rbserv_ComerAqui.Checked) servicio = "Para comer aquí";
            if (rbser_Llevar.Checked) servicio = "Para llevar";
        }
    }

}
