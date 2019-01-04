using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Bunifu.Framework.UI;
namespace Notes
{
    class CirculaButton: Bunifu.Framework.UI.BunifuFlatButton
    {
        
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pevent);
        }
        protected override void OnMouseHover(EventArgs e)
        {
        }
    }

}
