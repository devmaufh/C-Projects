using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;
using System.Drawing;
namespace LibSoft
{
    class Utils
    {
        public static void ChangeColorButtons(BunifuFlatButton button)
        {
            button.Normalcolor =Color.FromArgb(140, 20, 80);
            button.OnHovercolor = Color.FromArgb(130, 76, 103);
            button.Activecolor = Color.FromArgb(66, 8, 37);
        }
    }
}
