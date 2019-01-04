using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1xd
{
    public partial class Libros : UserControl
    {
        public Libros()
        {
            InitializeComponent();
        }

        private void pbImage_libro_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                pbImage_libro.Image = Image.FromFile(Abrir.FileName);

            }
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            new Consultas().carga_combo_estantes(cbEstantes);
            new Consultas().carga_combo_categorias(cbCategoria);

        }

        private void rbNuevo_CheckedChanged(object sender, EventArgs e)
        {
            cbAutores.Enabled = false;
            txtApellidos_Autor.Enabled = true;
            txtNameAutor.Enabled = true;
        }

        private void rbExistente_CheckedChanged(object sender, EventArgs e)
        {
            txtApellidos_Autor.Enabled = false;
            txtNameAutor.Enabled = false;
            cbAutores.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                String name_lib = txtName_libro.Text;
                String descripcion = txtDescripcion_libro.Text;
                String name_autor = txtNameAutor.Text;
                String apellido_autor = txtApellidos_Autor.Text;


            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese datos válidos");
            }

        }
       void imagen_picture()
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        String  cadena_aleatoria()
        {
            Random r = new Random();
            String []al = { "A", "B", "C", "D", "E", "F", "G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X" +
                    "","Y","Z","1","2","3","4","5","6","7","8","9"};
            String cadena = "C:/imagenes_libros/";
            for (int i = 0; i < al.Length; i++)
            {
                cadena +=al[r.Next(al.Length-1)];
            }
            return cadena+".jpg";
        }
    }
}
