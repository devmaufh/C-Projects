using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSoft
{
    public partial class Search : Form
    {
        SqlDataAdapter Adaptador;        DataSet Ds= new DataSet();        SqlConnection Cn = new SqlConnection("Server=MAURICIO;Database=libreria;Trusted_Connection=True;");
        public Search()
        {
            InitializeComponent();
        }

        private void txtNombre_OnTextChange(object sender, EventArgs e)
        {
            //          
            if (txtNombre.text.Length > 0)
            {
                clearData();
                txtAutor.text = "";
                refresh("titulo", txtNombre.text);
            }
            else clearData();
            
        }

        private void txtAutor_OnTextChange(object sender, EventArgs e)
        {
            if (txtAutor.text.Length > 0)
            {
                clearData();
                txtNombre.text = "";
                refresh("autor", txtAutor.text);
            }
            else clearData();
        }
        private void refresh(String parametro,String valor)
        {try
            {
               

                String query = "Select id_libro as Número, titulo as Titulo, " +
                    "descripcion as Descripcion, autor as Autor, disponibilidad as Disponibilidad,genero from libros where " + parametro+" like '%"+valor+"%' ;";
                Adaptador = new SqlDataAdapter(query, Cn);
                Adaptador.Fill(Ds, "NomLog"); // carga en el dataset el resultado de la consulta
                dgvLibros.DataSource = Ds.Tables["NomLog"]; // AL DataGridView le asignamos la tabla de dataset
                dgvLibros.Columns[1].Width = 350; // Un ancho más grande al Nombre de laroveedor
            }
            catch (Exception)
            {
                //MessageBox.Show("Error conectando al servidor");
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            Utils.ChangeColorButtons(btnSaveCHanges);
        }

        private void btnBucar_Click(object sender, EventArgs e)
        {
            if (txtAutor.text.Length > 0&&txtNombre.text.Length==0)
            {
                refresh("autor", txtAutor.text);
                
            }
            if (txtNombre.text.Length > 0 && txtAutor.text.Length == 0)
            {
                refresh("titulo", txtNombre.text);
            }
            if (txtAutor.text.Length == 0 && txtNombre.text.Length == 0)
            {
                MessageBox.Show("Debe ingresar al menos un criterio de busqueda");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
        }
        private void clearData()
        {
            Ds = new DataSet();
            Adaptador = null;
            dgvLibros.DataSource = null;
            dgvLibros.Refresh();
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.text = "";
        }

        private void txtAutor_Click(object sender, EventArgs e)
        {
            txtAutor.text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            new Libros("").Show();
        }

        private void btnSaveCHanges_Click(object sender, EventArgs e)
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
        public int xClick = 0, yClick = 0;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
