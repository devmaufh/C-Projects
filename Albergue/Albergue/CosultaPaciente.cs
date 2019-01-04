using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;

namespace Albergue
{
    public partial class CosultaPaciente : UserControl

    {
        //Conexiones:v
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        MySqlConnection conn;
        DataTable tabla;
        MySqlDataAdapter mdaDatos;
        String consulta = "Select curp as 'Curp', nombre as 'Nombre', " +
            "apellido_p as 'Primer apellido', apellido_m as 'Segundo apellido', domicilio as 'Domicilio', telefono as " +
            "'Telefono', genero as 'Genero', fecha_ingreso as 'Fecha' from pacientes;";

        public CosultaPaciente()
        {
            InitializeComponent();
        }



        private void CosultaPaciente_Load(object sender, EventArgs e)
        {
            //LOAAAAD
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "12345678";
            builder.Database = "albergue"; // nombre de base de datos

            conn = new MySqlConnection(builder.ToString());
            consultaTodo(consulta);

        
        }
        
        public void consultaTodo(String consulta)
        {
            try
            {
                conn.Open();

                tabla = new DataTable();
                mdaDatos = new MySqlDataAdapter(consulta, conn);
                mdaDatos.Fill(tabla);
                dataGridViewPacientes.DataSource = tabla;
                conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                conn.Close();
                consultaTodo(this.consulta);

            }

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMetroTextbox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            

        }

        private void bunifuMaterialTextbox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            
                txtNombre.Text = "";
            
        }

        private void txtNombre_OnValueChanged(object sender, EventArgs e)
        {
            txtApellidoPaterno.Text = "";
            txtApellidoMAterno.Text = "";
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscaApellido_Click(object sender, EventArgs e)
        {
            String consulta = "";
            try
            {
                
                if (cadenaVacia(txtApellidoMAterno.Text) && cadenaVacia(txtApellidoPaterno.Text) && !cadenaVacia(txtNombre.Text))
                {
                    //Solo nombre lleno :'v
                    consulta = "Select curp as 'Curp', nombre as 'Nombre', apellido_p as 'Primer apellido', apellido_m as 'Segundo apellido', domicilio as 'Domicilio', telefono as 'Telefono', genero as 'Genero', fecha_ingreso as 'Fecha' from pacientes where nombre like '%" + txtNombre.Text + "%' ";
                    Console.WriteLine("NOMBREEEEe");
                }
                if( cadenaVacia(txtNombre.Text)&&cadenaVacia(txtApellidoMAterno.Text)&&!cadenaVacia(txtApellidoPaterno.Text))
                {
                    //Solo apellido >:v
                    consulta = "Select curp as 'Curp', nombre as 'Nombre', apellido_p as 'Primer apellido', apellido_m as 'Segundo apellido', domicilio as 'Domicilio', telefono as 'Telefono', genero as 'Genero', fecha_ingreso as 'Fecha' from pacientes where apellido_p like '%" + txtApellidoPaterno.Text + "%' ";
                }
                if (cadenaVacia(txtNombre.Text) && cadenaVacia(txtApellidoPaterno.Text) && !cadenaVacia(txtApellidoMAterno.Text))
                {
                    //Solo apellido >:v
                    consulta = "Select curp as 'Curp', nombre as 'Nombre', apellido_p as 'Primer apellido', apellido_m as 'Segundo apellido', domicilio as 'Domicilio', telefono as 'Telefono', genero as 'Genero', fecha_ingreso as 'Fecha' from pacientes where apellido_m like '%" + txtApellidoMAterno.Text + "%' ";
                }

                if (!cadenaVacia(txtNombre.Text) && !cadenaVacia(txtApellidoPaterno.Text) && cadenaVacia(txtApellidoMAterno.Text))
                {
                    consulta = "Select curp as 'Curp', nombre as 'Nombre', apellido_p as 'Primer apellido', apellido_m as 'Segundo apellido', " +
                        "domicilio as 'Domicilio', telefono as 'Telefono', genero as 'Genero', fecha_ingreso as 'Fecha' from pacientes" +
                        " where nombre like '%" + txtNombre.Text + "%' and apellido_p like '%"+txtApellidoPaterno.Text+"%'";
                }
                if (!cadenaVacia(txtNombre.Text) && !cadenaVacia(txtApellidoMAterno.Text) && cadenaVacia(txtApellidoPaterno.Text))
                {
                    consulta = "Select curp as 'Curp', nombre as 'Nombre', apellido_p as 'Primer apellido', apellido_m as 'Segundo apellido', " +
                        "domicilio as 'Domicilio', telefono as 'Telefono', genero as 'Genero', fecha_ingreso as 'Fecha' from pacientes" +
                        " where nombre like '%" + txtNombre.Text + "%' and apellido_m like '%" + txtApellidoMAterno.Text + "%'";
                }
                if (cadenaVacia(txtNombre.Text) && !cadenaVacia(txtApellidoPaterno.Text) && !cadenaVacia(txtApellidoMAterno.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre al menos");
                }




                consultaTodo(consulta);

            }
            catch (Exception)
            {
                consultaTodo(consulta);
                MessageBox.Show("Error verifique los campos");
            }

        }
        Boolean cadenaVacia(String texto)
        {
            
            return texto.Length == 0;
            
        }

        private void dataGridViewPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            consultaTodo(consulta);
        }

        private void btnBuscaCurp_Click(object sender, EventArgs e)
        {
            String consulta = "";
            try
            {
                if (!cadenaVacia(txtCurp.Text))
                {
                    consulta = "Select curp as 'Curp', nombre as 'Nombre', apellido_p as 'Primer apellido', apellido_m as 'Segundo apellido', domicilio as 'Domicilio', telefono as 'Telefono', genero as 'Genero', fecha_ingreso as 'Fecha' from pacientes where curp = '" + txtNombre.Text + "' ";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Llene correctamente el campo");
            }
        }
    }
    
}
