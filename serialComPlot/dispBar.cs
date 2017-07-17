using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serialComPlot
{
    public partial class dispBar : UserControl
    {

        private double _currentValue;
        public double CurrentValue
        {
            get
            {
                return _currentValue;
            }
            set
            {
                _currentValue = value;
            }
        }
        private double _upLimit = 100;
        private double _lowLimit = 0;
        private int _channel = 0;
        private int _totalChannels;
        Bitmap bmp;
        Graphics g;
        Bitmap bmpBase;
        Graphics bB;
        public double UpLimit
        {
            get
            {
                return _upLimit;
            }
            set
            {
                _upLimit = value;
            }
        } 
        public double LowLimit
        {
            get
            {
                return _lowLimit;
            }
            set
            {
                _lowLimit = value;
            }
        }
        public int Channel
        {
            get
            {
                return _channel;
            }
            set
            {
                _channel = value;
            }
        }
        public int TotalChannels
        {
            get
            {
                return _totalChannels;
            }
            set
            {
                _totalChannels = value;
            }
        }
        /* set a flag to note the whether the event key press have happened */
        private bool enterTrigged = false;
        Brush orangeBrush = new SolidBrush(Color.Orange);
        /* define the dash pen */
        Pen penDash = new Pen(Color.Orange, 1);
        /* define the frame pen */
        Pen myPen = new Pen(Color.Orange, 3);
        public dispBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Point middlePoint = new Point(this.myPanel1.BarBackStartPoint.X,
                Convert.ToInt32((this.myPanel1.BarBackStartPoint.Y + 0.5 * this.myPanel1.BarHeight))); 
            this.myPanel1.CreateGraphics().DrawLine(penDash,middlePoint.X, middlePoint.Y, middlePoint.X + myPanel1.Width - 10, middlePoint.Y);
            base.OnPaint(e);
       }
        

        // reload plotBar
        public void plotBar()
        {

            
            // draw the bar
            double truncatedCurrentValue = CurrentValue > UpLimit ? UpLimit : 
                (CurrentValue < LowLimit ? LowLimit : CurrentValue);
            int currentBarHeight =Convert.ToInt32(this.myPanel1.BarHeight * (truncatedCurrentValue - LowLimit)/(UpLimit - LowLimit));

            Point bottomPoint = new Point(this.myPanel1.BarBackStartPoint.X, this.myPanel1.BarBackStartPoint.Y + this.myPanel1.BarHeight);
            g.Clear(myPanel1.BackColor);
            /* draw base frame */
            g.DrawRectangle(myPen,myPanel1.BarBackStartPoint.X, myPanel1.BarBackStartPoint.Y,
                myPanel1.BarWidth, myPanel1.BarHeight);

            Point middlePoint = new Point(this.myPanel1.BarBackStartPoint.X,
                Convert.ToInt32((this.myPanel1.BarBackStartPoint.Y + 0.5 * this.myPanel1.BarHeight)));
            /* draw middle line */
            g.DrawLine(penDash,middlePoint.X, middlePoint.Y, middlePoint.X + myPanel1.Width - 10, middlePoint.Y);
            g.FillRectangle(orangeBrush,bottomPoint.X,bottomPoint.Y - currentBarHeight, 
                this.myPanel1.BarWidth,currentBarHeight);
            myPanel1.CreateGraphics().DrawImage(bmp, 0, 0);
            
            /* dispose */
            
        }


        public void updateCombox()
        {
            this.myComboBox1.updateItems();
            for (int i = 1; i <= TotalChannels; i++)
                this.myComboBox1.Items.Add(i.ToString());
        }
        public void setComboxSelectedItem(int index)
        {
            /* map 1... to 0..., transferring from outer variable to inner variable */
            this.myComboBox1.SelectedIndex = index - 1;
            this.Channel = index;
            this.myComboBox1.SelectedItem = Convert.ToString(index);

        }
        private void dispBar_Load(object sender, EventArgs e)
        {
            bmpBase = new Bitmap(myPanel1.ClientRectangle.Width, myPanel1.ClientRectangle.Height);
            bB = Graphics.FromImage(bmpBase);
            bmp = new Bitmap(myPanel1.ClientRectangle.Width, myPanel1.ClientRectangle.Height);
            g = Graphics.FromImage(bmp);
            penDash.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            penDash.DashPattern = new float[] { 2, 1 };
        }

        public void UpdateTextFromLimit()
        {
            this.myTextBox1.Text = Convert.ToString(LowLimit);
            this.myTextBox2.Text = Convert.ToString(UpLimit);
        }

        private void myComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* map 0... to 1..., transferring inner variable to outer variable tranfer*/
            Channel = myComboBox1.SelectedIndex + 1;
        }
        private bool checkRangeCorrect()
        {
          if (Convert.ToDouble(myTextBox2.Text) <= Convert.ToDouble(myTextBox1.Text))
            {
                MessageBox.Show("The up limit is must greater than low limit");
                return false;
            }
            else
            {
                return true; 
            }
 
        }
        

        

        private void myTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (checkRangeCorrect())
                    UpLimit = Convert.ToDouble(myTextBox2.Text);
                else
                {
                    myTextBox2.Text = Convert.ToString(UpLimit);
                }
                enterTrigged = true;
            }
            
        }

        private void myTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (checkRangeCorrect())
                    LowLimit = Convert.ToDouble(myTextBox1.Text);
                else
                {
                    myTextBox1.Text = Convert.ToString(LowLimit);
                }
                enterTrigged = true;
            }
            
        }

        private void myTextBox2_Leave(object sender, EventArgs e)
        {
            if (enterTrigged)
                enterTrigged = false;
            else
            {
                if (checkRangeCorrect())
                    UpLimit = Convert.ToDouble(myTextBox2.Text);
                else
                {
                    myTextBox2.Text = Convert.ToString(UpLimit);
                }
 
            }
       }

        private void myTextBox1_Leave(object sender, EventArgs e)
        {
            if (enterTrigged)
                enterTrigged = false;
            else
            {
                if (checkRangeCorrect())
                    LowLimit = Convert.ToDouble(myTextBox1.Text);
                else
                {
                    myTextBox1.Text = Convert.ToString(LowLimit);
                }
 
            }
       }
    }
}
