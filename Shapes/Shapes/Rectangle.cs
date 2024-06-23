using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    public class Rectangle : Shape
    {
        protected override void DrawBorder(Graphics graphics, Pen borderPen)
        {
            graphics.DrawRectangle(borderPen, X, Y, Width, Height);
        }

        protected override void DrawShape(Graphics graphics, Pen fillPen)
        {
            graphics.FillRectangle(fillPen.Brush, X, Y, Width, Height);
        }
    }
}
