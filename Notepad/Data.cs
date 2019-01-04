using System.IO;
using System;

public class Class1
{
	public Class1()
	{
        
        String ruta()
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
    }
}
