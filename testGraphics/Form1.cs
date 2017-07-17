using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace testGraphics
{
    public partial class Form1 : Form
    {
        Graphics gc;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(100, 100);
            gc = Graphics.FromImage(bmp);
        }
        GraphicsPath newPath = new GraphicsPath();
        private void button1_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Black, 3);
            newPath.AddLine( 2, 2, 20, 20);
            newPath.AddArc(20, 20, 30, 30, 20, 90);
            newPath.AddEllipse(40, 40, 20, 20);
            gc.DrawPath(new Pen(Color.Black,2),newPath);
            pictureBox1.CreateGraphics().DrawImage(bmp, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawRectangle(new Pen(Color.Red),20,20,10,10);
            this.CreateGraphics().DrawLine(new Pen(Color.Blue), 0, 20, 100, 100);
        }
    }
}
