using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Notepad
{
    public partial class Form1 : Form
    {
        Operaciones op = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String ruta = op.ruta();
            if (ruta.Length > 0)
            {
                foreach (String  item in op.getText(ruta))
                {
                    
                    txtTexto.Text = txtTexto.Text + item + "\r\n";
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text.Length > 0)
            {
                op.guarda(txtTexto.Text);

            }
            else
            {
                MessageBox.Show("El archivo está vacío");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea guardar el archivo antes de salir?", "Salir",
                MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    op.guarda(txtTexto.Text);
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtTexto.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea guardar el archivo antes de salir?", "Salir",
                MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    op.guarda(txtTexto.Text);
                }
                else if (result == DialogResult.No) { }

            }
            
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fuentes_dialog.ShowDialog() != DialogResult.Cancel)
            {
                txtTexto.Font = fuentes_dialog.Font;
            }            
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Colores.ShowDialog() != DialogResult.Cancel)
            {
                txtTexto.ForeColor = Colores.Color;
            }
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            //Count palabras, letras
            lblPalabras.Text = "Palabras: " + op.no_p(txtTexto);
            lblLetra.Text = "Letras: " + txtTexto.Text.Length;
        }
    }
}
