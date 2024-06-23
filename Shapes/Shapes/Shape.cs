using System;
using System.Linq;

namespace Shapes.Shapes
{
    public abstract class Shape : IDisposable
    {
        private static readonly Color DefaultFillColor = Color.Red;
        private static readonly Color DefaultBorderColor = Color.Black;

        public Color FillColor { get { return _FillColor; } set { _FillColor = value; Invalidate?.Invoke(); } }
        public Color BorderColor { get { return _BorderColor; } set { _BorderColor = value; Invalidate?.Invoke(); } }

        public float Width { get { return _Width; } set { _Width = value; Invalidate?.Invoke(); } }
        public float Height { get { return _Height; } set { _Height = value; Invalidate?.Invoke(); } }
        public float X { get { return _X; } set { _X = value; Invalidate?.Invoke(); } }
        public float Y { get { return _Y; } set { _Y = value; Invalidate?.Invoke(); } }


        private Color _FillColor = DefaultFillColor;
        private Color _BorderColor = DefaultBorderColor;

        private float _Width = 100;
        private float _Height = 100;
        private float _X = 0;
        private float _Y = 0;


        private Pen FillPen = new Pen(DefaultFillColor);
        private Pen BorderPen = new Pen(DefaultBorderColor);
        internal Action Invalidate;

        public bool IsPointInShape(PointF point)
        {
            return X <= point.X && point.X < X + Width && Y <= point.Y && point.Y < Y + Height;
        }

        public void Draw(Graphics graphics)
        {
            FillPen.Color = FillColor;
            BorderPen.Color = BorderColor;

            this.DrawShape(graphics, FillPen);
            this.DrawBorder(graphics, BorderPen);
        }

        protected abstract void DrawBorder(Graphics graphics, Pen borderPen);
        protected abstract void DrawShape(Graphics graphics, Pen fillPen);

        public void Dispose()
        {
            FillPen.Dispose();
            BorderPen.Dispose();
        }
        /*
        public static bool IsPointInPolygon(PointF[] polygon, PointF testPoint)
        {
            bool result = false;
            int j = polygon.Length - 1;
            for (int i = 0; i < polygon.Length; i++)
            {
                if (polygon[i].Y < testPoint.Y && polygon[j].Y >= testPoint.Y ||
                    polygon[j].Y < testPoint.Y && polygon[i].Y >= testPoint.Y)
                {
                    if (polygon[i].X + (testPoint.Y - polygon[i].Y) /
                       (polygon[j].Y - polygon[i].Y) *
                       (polygon[j].X - polygon[i].X) < testPoint.X)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }
        */
    }
}
