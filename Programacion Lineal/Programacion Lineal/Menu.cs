using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_Lineal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 50)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 185;
                animaPanel.ShowSync(sideMenu);
                animalogo.ShowSync(logo);
                
            }
            else
            {
                animalogo.Hide(logo);
                sideMenu.Visible = true;
                sideMenu.Width = 50;
                animaPanel.ShowSync(sideMenu);
            }
            


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if (sideMenu.Width == 50)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 185;
                animaPanel.ShowSync(sideMenu);
                animalogo.ShowSync(logo);
            }
            else
            {
                animalogo.Hide(logo);
                sideMenu.Visible = true;
                sideMenu.Width = 50;
                animaPanel.ShowSync(sideMenu);
            }
            
        }
    }
}
