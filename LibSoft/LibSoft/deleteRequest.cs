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
    public partial class deleteRequest : Form
    {
        public deleteRequest()
        {
            InitializeComponent();
        }

        private void deleteRequest_Load(object sender, EventArgs e)
        {
            Utils.ChangeColorButtons(btnDelete);
            new Operaciones().cargaComboPeticiones(cbPeticiones);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new Operaciones().deleteRequest(cbPeticiones.SelectedValue.ToString());
            this.Hide();
        }
        public int xClick = 0, yClick = 0;

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
