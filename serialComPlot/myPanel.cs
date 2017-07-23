using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace serialComPlot
{
    class myPanel:Panel
    {
        private int _barHeight = 113;
        private int _barWidth = 20;
        private Point _barBackStartPoint = new Point(6, 0);
        public Point BarBackStartPoint
        {
            get
            {
                return _barBackStartPoint;
            }
           
        }
        public  int BarHeight
        {
            get
            {
                return _barHeight;
            }
            
        }
        public int BarWidth
        {
            get
            {
                return _barWidth;
            }
            
        }
       protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gc = this.CreateGraphics();
            Pen myPen = new Pen(Color.Orange, 3);
            gc.DrawRectangle(myPen, BarBackStartPoint.X, BarBackStartPoint.Y, BarWidth, BarHeight);

        } 
    }
}
