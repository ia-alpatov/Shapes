using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    public class Circle : Shape
    {
        public float Radius
        {
            get
            {
                return Width / 2;
            }
            set
            {
                Width = value * 2;
                Height = value * 2;
            }
        }

        protected override void DrawBorder(Graphics graphics, Pen borderPen)
        {
            graphics.DrawEllipse(borderPen, X, Y,
                      Radius + Radius, Radius + Radius);
        }

        protected override void DrawShape(Graphics graphics, Pen fillPen)
        {
            graphics.FillEllipse(fillPen.Brush, X, Y,
                      Radius + Radius, Radius + Radius);
        }
    }
}

