using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Conexion
{
    class funciones
    {
        SqlConnection conn;
         //OleDbConnection conn;
        SqlCommand cmd;

        //OleDbCommand cmd;
        SqlDataReader dr;
        // OleDbDataReader dr;
        public void connect()
        {
            try
            {
                String cadena = "Server=MAURICIO;Database=agenda;Trusted_Connection=True;";
                conn = new SqlConnection(cadena);
                conn.Open();
                MessageBox.Show("Conexión abierta");
            }
            catch (Exception e)
            {

                MessageBox.Show("Error conectando con el servidor: "+e.ToString());
            }
        }
        public void cierra()
        {
            try
            {
                conn.Close();
                MessageBox.Show("Conexión cerrada");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error, se debe abrir la conexión con el servidor: " + e.ToString());
            }
        }
        public void registra(String name, String usr,string pass)
        {
            try
            {
                if (name.Length > 0 && usr.Length > 0 && pass.Length > 0)
                {
                    String Query = "insert into usuarios(nombre,usuario,contraseña) values('" + name + "','" + usr + "','" + pass + "');";
                    cmd = new SqlCommand(Query, conn);
                    int status = cmd.ExecuteNonQuery();
                    if (status > 0) MessageBox.Show("Usuario registrado correctamente");
                    else MessageBox.Show("No se ha registrado el usuario");
                }
                else
                { //Nothig}
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error con el servidor\n"+ex);
            }
        }
        public int Busca()
        {
            return 0;

        }

        public int Existe(String name)
        {
            int counter = 0;
            try
            {
                cmd = new SqlCommand("Select * from usuarios where usuario='"+name+"';",conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    counter++;
                }
                dr.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error con la base de datos     EXISTE|\n"+e);
            }
            return counter;
        }
        public void buscar(String user, String pass)
        {
            if (user.Length > 0 && pass.Length > 0)
            {
                cmd = new SqlCommand("Select * from usuarios where usuario='" + user + "' AND contraseña='" + pass + "'", conn);
            }
            else
            {
                cmd = new SqlCommand("Select * from usuarios", conn);
            }


            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MessageBox.Show("User: " + dr["usuario"] + "\ncontraseña: " + dr["contraseña"]);
                    }
                }
                
                else
                {
                    MessageBox.Show("El usuario no existe");
                }
                dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error con la BD");
            }

        }
    }
}
