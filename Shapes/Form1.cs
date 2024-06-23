namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addShape_Click(object sender, EventArgs e)
        {
            this.shapesControl.AddShape(new Shapes.Rectangle() { X = 100, Y = 200 });
            this.shapesControl.AddShape(new Shapes.Circle() { X = 200, Y = 200 });
            this.shapesControl.AddShape(new Shapes.Triangle() { X = 300, Y = 200, Angle = 90 });
        }
    }
}
