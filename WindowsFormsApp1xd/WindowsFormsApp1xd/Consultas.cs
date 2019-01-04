using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1xd
{
    class Consultas
    {
        Boolean conStatus = false;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dataReader;
        DataTable dt;
        public void conecta()
        {
            try
            {
                conn = new SqlConnection("Server=Mauricio;Database=libreria;Trusted_Connection=True;");
                conn.Open();
                MessageBox.Show("Conexión open");
            }
            catch (Exception)
            {

                MessageBox.Show("Erro conectando al servidor");
                conStatus = false;
            }
            
        }
        public void cierra_conexion()
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cerrar la conexión");
            }
        }
        public void inserta_autores(String name, String apellidos, String ruta)
        {
            
            try
            {
                conecta();
                String consulta = "exec insert_autor'" + name + "', '" + apellidos + "','"+ruta+"';";
                cmd = new SqlCommand(consulta, conn);
                int status = cmd.ExecuteNonQuery();
                if (status > 0)
                    MessageBox.Show("Autor registrado correctamente");
                else
                    MessageBox.Show("Error al registrar Autor");
                cierra_conexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error con el servidor");
            }
        }
        public void carga_combo_estantes(ComboBox cb)
        {
            try
            {
                conecta();
                String sql = "Select * from estante;";
                dt = new DataTable();
                cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cb.DisplayMember = "ubicacion";
                cb.ValueMember = "id_estante";
                cb.DataSource = dt;
                cierra_conexion();

            }
            catch (Exception)
            {

                MessageBox.Show("Error con el servidor");
            }
        }
        public void carga_combo_categorias(ComboBox cb)
        {

            try
            {
                conecta();
                String sql = "Select id_categoria,nombre from categorias;";
                dt = new DataTable();
                cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cb.DisplayMember = "nombre";
                cb.ValueMember = "id_categoria";
                cb.DataSource = dt;
                cierra_conexion();
            }
            catch (Exception)
            {

                MessageBox.Show("Error con el servidor");
            }
        }



    }
}
