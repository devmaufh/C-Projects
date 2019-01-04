using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Data;
namespace LibSoft
{
    class Operaciones
    {
        SqlConnection conn = new SqlConnection("Server=MAURICIO;Database=libreria;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;
        public Boolean Login(String username,String password)
        {
            Boolean flag = false;
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from usuarios where correo='"+username+"' and contraseña='"+password+ "' OR username='" + username + "' and contraseña='" + password + "'",conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con servidor. Consule al administrador del sistema");
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
        
        public void cargaComboLibros(ComboBox cb)
        {
            try
            {
                conn.Open();
                String query = "Select * from libros;";
                cmd = new SqlCommand(query, conn);
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cb.DisplayMember = "titulo";
                cb.ValueMember = "id_libro";
                cb.DataSource = dt;
                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro con servidor");
            }
        }
        public void cargaComboPeticiones(ComboBox cb)
        {
            try
            {
                conn.Open();
                String query = "Select p.id_peticion,l.titulo,p.nombre_persona " +
                    "from peticiones as p inner join libros as l on p.id_libro=l.id_libro;";
                cmd = new SqlCommand(query, conn);
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cb.DisplayMember ="id_peticion";
                cb.ValueMember = "id_peticion";
                cb.DataSource = dt;
                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro con servidor");
            }
        }
            public static Boolean VerifyString(String cadena)
        {
            Boolean flag = false;
            if (cadena.Length > 0 && cadena != null)
            {
                flag = true;
                for (int i = 0; i < cadena.Length; i++)
                    if (Char.IsWhiteSpace(cadena[i]))
                    {
                        flag = false;
                    }
            }
            else flag = false;
             return flag;
        }
        public void registerRequest(String id_libro,String nameperson)
        {

            try
            {
                conn.Open();
                String query = "insert into peticiones(id_libro,fecha,nombre_persona,status) values" +
                    "('" + id_libro + "', (SELECT CONVERT (date, SYSDATETIME())),'" + nameperson + "','abierta')";
                cmd = new SqlCommand(query, conn);
                int status = cmd.ExecuteNonQuery();
                if (status > 0)
                    MessageBox.Show("Registro exitoso");
                else MessageBox.Show("Registro fallido");
                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error con el servidor");
            }
           
        }
        public void deleteRequest(String id)
        {
            try
            {
                conn.Open();
                String query = "delete from peticiones where id_peticion='"+id+"';";
                cmd = new SqlCommand(query, conn);
                int status = cmd.ExecuteNonQuery();
                if (status > 0) MessageBox.Show("Baja exitosa");
                else //MessageBox.Show("Intente más tarde");
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
