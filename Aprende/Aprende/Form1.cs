using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprende
{
    public partial class Form1 : Form
    {

        public String user = "",pass="";
        public int xClick = 0, yClick = 0; //Mover form
        public Form1()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTABperfil_Click(object sender, EventArgs e)
        {
            panelAccount.Visible = true;

        }

        private void btnTABsubir_Click(object sender, EventArgs e)
        {
            panelAccount.Visible = false;
        }

        private void btnTabHome_Click(object sender, EventArgs e)
        {
            panelAccount.Visible = false;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoggout_Click(object sender, EventArgs e)
        {
            user = "";
            pass = "";
            this.Visible = false;
            new Loggin().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("FORM1");
            this.CenterToScreen();
            //MessageBox.Show("User: "+user+ "\nPass: "+pass);
            GetSetPerfil();
           


        }

        private void panelAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        //Variables y metodos para PERFIL ////////////////////////////////////////////////////////////////
        List<String> perfil_idVideos = new List<string>();
        List<String> perfil_nombreVideos = new List<string>();

        private void cbVideosSubidos_onItemSelected(object sender, EventArgs e)
        {
            //25 letras
            int id = Convert.ToInt32(perfil_idVideos.ElementAt(cbVideosSubidos.selectedIndex));
            String descripcion = new Consultas().retornaDatos_video(id, "descripcion");

            String x = "";
            for (int i = 0; i < descripcion.Length; i++)
            {
                if (x.Length==45||x.Length==90||x.Length==135)
                {
                    x = x + "\n";
                }
                x = x + descripcion.ElementAt(i);
            }
            descripcion = x;

            p_lblDescripcionVideo.Text = descripcion;
            p_gaugeClificacionVideo.Value = Convert.ToInt32(new Consultas().retornaDatos_video(id,"calificacion"));
            VisibilidadPerfil(true);
        }

        public void GetSetPerfil()
        {
            //IZQ
            lblNombre.Text = new Consultas().retornaDatos(user, "nombre");
            lblEscuela.Text = new Consultas().retornaDatos(user, "escuela");
            lblCorreo.Text = new Consultas().retornaDatos(user, "user");
            
            //DER

            perfil_idVideos = new Consultas().tabla("select id_video from videos where user='"+user+"';","id_video");
            perfil_nombreVideos = new Consultas().tabla("select nombre from videos where user='" + user + "';", "nombre");
            List<String> temp = new List<string>();
            for (int i = 0; i < perfil_nombreVideos.Count; i++)
            {
                temp.Add(perfil_idVideos.ElementAt(i)+".- "+perfil_nombreVideos.ElementAt(i));
            }
            llenaCombo(cbVideosSubidos, temp);
        }
        public void llenaCombo(Bunifu.Framework.UI.BunifuDropdown combo, List<String> lista)
        {
            foreach(String i in lista)
            {
                combo.AddItem(i);
            }
        }
        public void VisibilidadPerfil(Boolean f)
        {
           p_lblCalificacion.Visible=p_gaugeClificacionVideo.Visible=P_lblDescric.Visible=p_lblDescripcionVideo.Visible= f;
            
        }
        // END PERFIL     ///////////////////////////////////////////////////////////////
    }
}
