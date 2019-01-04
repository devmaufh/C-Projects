using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprende
{
    class Consultas
    {
        String datos = "Server=localhost;Uid=root;Pwd=12345678;Database=aprende;";//Datos de la BD
        MySqlConnection conn;

        public Consultas()























        {
            conn = new MySqlConnection(datos);
        }
        public void AbreBD()
        {
            try {
                conn.Open();
                //   MessageBox.Show("Conexion exitosa");
            } catch (Exception e) {
                MessageBox.Show("Error intente más tarde");
            }
        }
        public void CierraBD()
        {
            conn.Close();
        }
        
        public void Inserta(String Query)
        {
            //Query = "insert into usuarios(nombre, escuela, contraseña, user) values('Test01','TestSchool','pass','Maincasra');";
            try
            {
                AbreBD();
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                CierraBD();
            }
            catch (Exception)
            {
                MessageBox.Show("Error , contacte al Administrador");

            }

        } //Sirve también para actualizar  y eliminar :v
        
        public String retornaDatos(String user, String columna)//Devuelve datos cuando la consulta arroja un solo resultado
        { 
          //User es la condición de la consulta (modificar en caso de reutilizar este metodo), columna es el nombre de la columna que devolverá la consulta  
            String query = "Select "+columna+" from usuarios where user='"+user+"';";

            String resultado = "";
            AbreBD();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("user", user);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                //MessageBox.Show(Convert.ToString(row["count(*)"]));
                resultado =row[columna].ToString();
            }
            CierraBD();
            return resultado;
        }
        public String retornaDatos_video(int id_video, String columna)
        {
            String r = "";
            String query = "Select " + columna + " from videos where id_video=" + id_video + ";";
            AbreBD();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_video", id_video);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                //MessageBox.Show(Convert.ToString(row["count(*)"]));
                r = row[columna].ToString();
            }
            CierraBD();
            return r;
        }//Incompleto :V

        public Boolean validaUser(String user)
        {
            Boolean r =false;
            int x = 0;
            String Query = "Select count(*) from usuarios where user='"+user+"';";
            //String Query = "Select nombre from usuarios where user='maincra'";
            AbreBD();
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("user",user);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                DataRow row = dt.Rows[0];
                //MessageBox.Show(Convert.ToString(row["count(*)"]));
                x = Convert.ToInt32(row["count(*)"]);
                }
            if (x == 0) r = false;
            else r = true;
            CierraBD();
            return r;
        }
        public Boolean validaPass(String user,String pass)
        {
            Boolean r = false;
            int x = 0;
            String Query = "Select count(*) from usuarios where user='" + user + "' and contraseña='"+pass+"';";
            //String Query = "Select nombre from usuarios where user='maincra'";
            AbreBD();
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("user", user);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                //MessageBox.Show(Convert.ToString(row["count(*)"]));
                x = Convert.ToInt32(row["count(*)"]);
            }
            if (x == 0) r = false;
            else r = true;
            CierraBD();
            return r;
        }
        public List<String> tabla(String consulta,String campo)
        {
            List<String> tabla = new List<String>();
            AbreBD();
            MySqlCommand cmd = new MySqlCommand(consulta,conn);
            MySqlDataReader lector = cmd.ExecuteReader();
            while(lector.Read())
            {
                tabla.Add(lector[campo].ToString());
            }
            return tabla;

        }//Regresa una tabla completa
    }
}
