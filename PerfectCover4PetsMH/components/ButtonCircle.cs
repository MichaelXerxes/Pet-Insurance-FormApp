using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PerfectCover4PetsMH.components
{
    class ButtonCircle:Button
    {

        
            protected override void OnPaint(PaintEventArgs pevent)
            {// 
                GraphicsPath graphics = new GraphicsPath();//Initializes a new instance of the GraphicsPath class 

                graphics.AddEllipse(1, 1, ClientSize.Width-4, ClientSize.Height-4);//Adds an ellipse to the current path.
           // p.AddEllipse(1, 1, button1.Width - 4, button1.Height - 4);
            this.Region = new System.Drawing.Region(graphics);//Describes the interior of a graphics shape composed of rectangles and paths. This class cannot be inherited
                base.OnPaint(pevent);//call base.OnPaint() when  override the OnPaint() method of the form:
            }
        

    }
}
