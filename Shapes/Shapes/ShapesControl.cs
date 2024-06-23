using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes.Shapes
{
    public partial class ShapesControl : Control
    {
        public List<Shape> Shapes { get; set; }

        public ShapesControl()
        {
            InitializeComponent();
        }

        public void AddShape(Shape shape)
        {
            if(Shapes == null)
                Shapes = new List<Shape>();
            shape.Invalidate += ()=> Invalidate();
            Shapes.Add(shape);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if(Shapes != null)
                foreach (Shape shape in Shapes)
                {
                    shape.Draw(pe.Graphics);
                }
        }
    }
}
