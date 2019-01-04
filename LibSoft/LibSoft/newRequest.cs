using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSoft
{
    public partial class newRequest : Form
    {
        public newRequest()
        {
            InitializeComponent();
        }

        private void newRequest_Load(object sender, EventArgs e)
        {
            Utils.ChangeColorButtons(btnRegister);
            new Operaciones().cargaComboLibros(cbLibros);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Operaciones().cargaComboLibros(cbLibros);

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String id_lib = cbLibros.SelectedValue.ToString();
            MessageBox.Show(id_lib);
            if (Operaciones.VerifyString(txtName.Text))
            {
                new Operaciones().registerRequest(id_lib, txtName.Text);
            } else MessageBox.Show("No condicona");
            this.Hide();
            Peticiones p = new Peticiones();
            p.Show();
        }
        public int xClick = 0, yClick = 0;


        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
