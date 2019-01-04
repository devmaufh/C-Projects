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
    public partial class Peticiones : Form
    {
        public int xClick = 0, yClick = 0;
        String username;
        SqlDataAdapter Adaptador;        DataSet Ds = new DataSet();        SqlConnection Cn = new SqlConnection("Server=MAURICIO;Database=libreria;Trusted_Connection=True;");
        public Peticiones()
        {
            InitializeComponent();
        }

        private void Peticiones_Load(object sender, EventArgs e)
        {
            Utils.ChangeColorButtons(btnDelete);
            Utils.ChangeColorButtons(btnNewRequest);
            refresh();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            //new Peticiones().Show();
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            new newRequest().Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new deleteRequest().Show();
        }
        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void refresh()
        {
            try
            {
                String query = "Select * from vista_peticion;";
                Adaptador = new SqlDataAdapter(query, Cn);
                Adaptador.Fill(Ds, "NomLog"); // carga en el dataset el resultado de la consulta
                dgvPeticiones.DataSource = Ds.Tables["NomLog"]; // AL DataGridView le asignamos la tabla de dataset
                dgvPeticiones.Columns[1].Width = 350; // Un ancho más grande al Nombre de laroveedor
            }
            catch (Exception)
            {
                MessageBox.Show("Error conectando al servidor");
            }
        }
    }
}
