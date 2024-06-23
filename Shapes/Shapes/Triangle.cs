using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Shapes.Shapes
{
    public class Triangle : Shape
    {
        public float Angle { get; set; }

        protected override void DrawBorder(Graphics graphics, Pen borderPen)
        {
            graphics.TranslateTransform((X + Width / 2), (Y + Height / 2));
            graphics.RotateTransform(Angle);
            graphics.TranslateTransform(-(X + Width / 2), -(Y + Height / 2));
            graphics.DrawPolygon(borderPen, GetPoints());
            graphics.ResetTransform();
        }

        protected override void DrawShape(Graphics graphics, Pen fillPen)
        {
            graphics.TranslateTransform((X + Width/2), (Y + Height  / 2));
            graphics.RotateTransform(Angle);
            graphics.TranslateTransform(-(X + Width / 2), -(Y + Height / 2));
            graphics.FillPolygon(fillPen.Brush, GetPoints());
            graphics.ResetTransform();
        }

        private PointF[] GetPoints()
        {
            float num = (this.X);
            float num2 = (this.Y);
            float num3 = (this.Width) - 1f;
            float num4 = (this.Height) - 1f;
            float num5 = num + num3;
            float num6 = num2 + num4;

            PointF[] points = new PointF[]
                {
                    new PointF(num5, num6),
                    new PointF(num, num6),
                    new PointF(num + num3 / 2f, num2),
                    new PointF(num5, num6)
                };
            return points;
        }
        
    }
}
