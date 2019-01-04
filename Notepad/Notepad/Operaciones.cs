using System;
using System.IO;
using System.Windows.Forms;
using System.Collections;
namespace Notepad
{
    class Operaciones
    {
        public ArrayList  getText(String ruta)
        {
            String line = "";
            ArrayList arrText = new ArrayList();
            try
            {
                StreamReader sr = new StreamReader(ruta);
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                        arrText.Add(line);
                }
                sr.Close();
                return arrText;

            }
            catch (Exception)
            {

                MessageBox.Show("Error al abrir archivo, verifique que no esté corrupto.");
                return null;
            }

            
        }
        public String ruta()
        {
            String ruta = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Abrir";
            dialog.Filter = "TXT files|*.txt";
            dialog.InitialDirectory = "@C:/Users/Public/Documents";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ruta = dialog.FileName;
            }
            return ruta;
        }
        public void guarda(String texto)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text files (*.txt)|.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFile.FileName);
                sw.Write(texto);
                sw.Close();
               
            }
        }
        public int no_palabras(TextBox txt)
        {
            int c = 0;
            for (int i = 0; i < txt.Text.Length-1; i++)
            {
            }

            return c;
        }
        public int no_p(TextBox txt)
        {
            int c = 1;
            for (int i = 0; i < txt.Text.Length; i++)
            {
                if ((txt.Text[i] == ' ' || txt.Text[i] == 00 || txt.Text[i] == 10) && i > 0 && txt.Text[i - 1] != ' ')
                    c++;
            }
            return c;
        }
    }
}
