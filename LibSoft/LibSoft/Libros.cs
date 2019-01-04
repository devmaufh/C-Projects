using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibSoft
{
    public partial class Libros : Form
    {
        public int xClick = 0, yClick = 0;
        String username;
        SqlDataAdapter Adaptador;        DataSet Ds = new DataSet();        SqlConnection Cn = new SqlConnection("Server=MAURICIO;Database=libreria;Trusted_Connection=True;");
        public Libros(String username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void refresh()
        {
            try
            {
                
                String query = "Select id_libro as Número, titulo as Titulo, " +
                    "descripcion as Descripcion, autor as Autor, disponibilidad as Disponibilidad,genero from libros;";
                Adaptador = new SqlDataAdapter(query, Cn);
                Adaptador.Fill(Ds, "NomLog"); // carga en el dataset el resultado de la consulta
                dgvLibros.DataSource = Ds.Tables["NomLog"]; // AL DataGridView le asignamos la tabla de dataset
                dgvLibros.Columns[1].Width = 350; // Un ancho más grande al Nombre de laroveedor
            }
            catch (Exception)
            {
                MessageBox.Show("Error conectando al servidor");
            }
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            Utils.ChangeColorButtons(btnSearch);
            Utils.ChangeColorButtons(btnHelp);
            Utils.ChangeColorButtons(btnSaveCHanges);
            refresh();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Insertar datos: Agregue columna por columna cada dato sin exceptuar ninguna celda, y presione el botón Guardar\n\n" +
                "2. Actualizar datos: Haga doble click en la celda que desea editar y modifique el texto, al terminar presione el botón Guardar\n\n" +
                "3. Eliminar datos: Seleccione todo el registro que desea eliminar y presione 'Suprimir'.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder CB = new SqlCommandBuilder(Adaptador);
                Adaptador.Update(Ds, "NomLog");
                Adaptador.Update(Ds, "NomLog"); // Guarda los cambios efectuados en el DataGridView
                Ds.Tables["NomLog"].AcceptChanges(); // Retira la bandera de los registrosmodificados
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique los campos");
            }
        }
    }
}
