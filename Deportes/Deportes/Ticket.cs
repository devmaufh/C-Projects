using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deportes
{
    public partial class Ticket : Form
    {
        String name_age, lives, nivel;
        List<String> deportes;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Ticket(String name_age,String lives,List<String> deportes,String nivel)
        {
            InitializeComponent();
            this.name_age = name_age;
            this.lives = lives;
            this.deportes = deportes;
            this.nivel = nivel;
            MessageBox.Show("Datos correctos");
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            lblName_Age.Text = name_age;
            lblLives.Text = lives;
            foreach (var item in deportes)
            {
                l_depo.Items.Add(item);
            }
            lblNivel.Text = nivel;
        }
    }
}
