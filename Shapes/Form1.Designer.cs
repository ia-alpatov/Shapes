using Shapes.Shapes;

namespace Shapes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            shapesControl = new ShapesControl();
            addShape = new Button();
            SuspendLayout();
            // 
            // shapesControl
            // 
            shapesControl.Location = new Point(0, 0);
            shapesControl.Name = "shapesControl";
            shapesControl.Shapes = null;
            shapesControl.Size = new Size(803, 355);
            shapesControl.TabIndex = 0;
            // 
            // addShape
            // 
            addShape.Location = new Point(344, 361);
            addShape.Name = "addShape";
            addShape.Size = new Size(131, 40);
            addShape.TabIndex = 1;
            addShape.Text = "Add Shapes";
            addShape.UseVisualStyleBackColor = true;
            addShape.Click += addShape_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addShape);
            Controls.Add(shapesControl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ShapesControl shapesControl;
        private Button addShape;
    }
}
