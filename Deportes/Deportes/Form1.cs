using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deportes
{
    public partial class Form1 : Form
    {
        private String deportes = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCiudad.Items.Add("Celaya");
            cbCiudad.Items.Add("Juventino Rosas");
            cbCiudad.Items.Add("Salamanca");
            cbCiudad.Items.Add("Apaseo el alto");
            cbCiudad.Items.Add("Cortazar");
            cbCiudad.Items.Add("León");
            cbCiudad.Items.Add("Apaseo el grande");
            cbCiudad.Items.Add("Abasolo");
            cbCiudad.Text = "Seleccione una ciudad";
        }
        private String name_age(TextBox name, TextBox age)
        {
            return name.Text + " tiene " + age.Text + " años.";
        }
        private String lives(RadioButton men,RadioButton women,ComboBox ciudad)
        {
            if (men.Checked) return "Él vive en " + ciudad.SelectedItem.ToString();
            else if (women.Checked) return "Ella viven en " + ciudad.SelectedItem.ToString();
            else
            {
                return "Vive en " + ciudad;
            }
        }
        private List<String> Deportes()
        {
            List<String> deportes = new List<string>();
            if (checkNatacion.Checked) deportes.Add("Natación");
            if (checkFutbol.Checked) deportes.Add("Fútbol");
            if (checkBeis.Checked) deportes.Add("BeisBol");
            if (checkBasket.Checked) deportes.Add("Basquetbol");
            if (checkCiclismo.Checked) deportes.Add("Ciclismo");
            if (checkTenis.Checked) deportes.Add("Tenis");
            if (checkGolf.Checked) deportes.Add("Golf");
            if (!checkNatacion.Checked && !checkFutbol.Checked && !checkBeis.Checked &&
                !checkBasket.Checked && !checkCiclismo.Checked && !checkTenis.Checked && !checkGolf.Checked) deportes.Add("Ninguno");
            return deportes;
        }
        private String nivel(RadioButton prin,RadioButton inter, RadioButton avan) {
            if (prin.Checked) return "Nivel deportivo: Principiante.";
            if (inter.Checked) return "Nivel deportivo: Intermedio.";
            if (avan.Checked) return "Nivel deportivo: Avanzado";
            else
            {
                return "";
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

           Ticket t= new Ticket(name_age(txtCliente,txtEdad),lives(rbSex_Masculino,rb_SexFem,cbCiudad),Deportes(),nivel(rbNivel,rbMedio,rb_NivelAvanzado));
            t.Show();


            clear();
        }

        private void checkNinguno_CheckedChanged(object sender, EventArgs e)
        {
            if(checkNinguno.Checked)
                checkNatacion.Checked = checkFutbol.Checked = checkBeis.Checked = checkBasket.Checked = checkCiclismo.Checked = checkTenis.Checked = checkGolf.Checked =  false;

        }
        private void clear()
        {
            txtCliente.Clear();
            txtEdad.Clear();
            cbCiudad.SelectedItem = null;
            checkNatacion.Checked = checkFutbol.Checked = checkBeis.Checked = checkBasket.Checked = checkCiclismo.Checked = checkTenis.Checked = checkGolf.Checked = checkNinguno.Checked = false;
            rbSex_Masculino.Checked = rb_SexFem.Checked = rb_NivelAvanzado.Checked = rbMedio.Checked = rbNivel.Checked = false;
        }
    }
}
