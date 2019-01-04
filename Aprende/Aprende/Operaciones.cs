using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Aprende
{
    class Operaciones
    {
        String user = "",pass="",id="";
        Boolean logeado=false;
        public void setFoto(PictureBox pb, Image foto)
        {
            pb.Image = foto;
        }

        public Boolean getLogeado()
        {
            return logeado;
        }
        public void setLogeado(Boolean log)
        {
            logeado = log;
        }

    }
}
