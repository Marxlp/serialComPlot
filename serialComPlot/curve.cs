using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Drawing2D;

namespace serialComPlot
{

    public partial class curve : Form
    {
        
        /* the index of data to be plot */
        private int[] _dataIndex;
        public int[] DataIndex
        {
            get
            {
                return _dataIndex;
            }
            set
            {
                _dataIndex = value;
            }
        }
        /* time index */
        private int _tIndex;
        public int TIndex
        {
            get
            {
                return _tIndex;
            }
            set
            {
                _tIndex = value;
            }
        } 
        /* the uplimit of the axis */
        private double _upLimit = 0;
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
        /* the low limit of the axis */
        private float _lowLimit = 0;
        public float LowLimit
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
        private int _curveDataLength = 200;
        public int CurveDataLength
        {
            get
            {
                return _curveDataLength;
            }
            set
            {
                _curveDataLength = value;
            }
        }
        private bool _axisAutoScale = true;
        public bool AxisAutoScale
        {
            get
            {
                return _axisAutoScale;
            }
            set
            {
                _axisAutoScale = value;
            }
        }
        private string[] _curveLabels;
        public string[] CurveLabels
        {
            get
            {
                return _curveLabels;
            }
            set
            {
                _curveLabels = value;
            }
        }
        Graphics g;
        /* Bitmap to be plotted on */
        Bitmap bmp;
        /* the width and height of PictureBox */
        int PictureBoxWidth;
        int PictureBoxHeight;
        /* curves and curve pens */
        Curve[] curves;
        Pen[] curvePens;
        /* legend Point */
        Point[] legendPointStart;
        Point[] legendPointEnd;
        String[] legendString;
        /* point value every y tick,and default is 10 */
        int[] yAxis = new int[11];
        Pen axisPen = new Pen(Color.Black, 1);
        Font axisFont = new Font("SimSun", 12, FontStyle.Regular);
        SolidBrush axisBrush = new SolidBrush(Color.Black);
        Random colorRnd = new Random();
        int fontHeight = 20;
        int fontWidth = 45;
        public curve()
        {
            InitializeComponent();
        }

        private void curve_Load(object sender, EventArgs e)
        {
            curves = new Curve[DataIndex.Length];
            for(int i=0;i < DataIndex.Length;i++)
            {
                curves[i] = new Curve(CurveDataLength);
            }
            curvePens = new Pen[DataIndex.Length];
            for(int i = 0;i < DataIndex.Length; i++)
            {
                curvePens[i] = new Pen(Color.FromArgb(colorRnd.Next(0, 200), colorRnd.Next(0, 200), colorRnd.Next(0, 200)),2);
            }
            PictureBoxWidth = this.pictureBox1.ClientRectangle.Width;
            PictureBoxHeight = this.pictureBox1.ClientRectangle.Height;
            legendPointStart= new Point[DataIndex.Length];
            legendPointEnd = new Point[DataIndex.Length];
            int dHLegend = 20;
            for(int i = 0;i < DataIndex.Length;i++)
            {
                legendPointStart[i] = new Point(PictureBoxWidth - 50,20 + dHLegend * i);
                legendPointEnd[i] = new Point(PictureBoxWidth - 5, 20 + dHLegend * i);
            }
            bmp = new Bitmap(PictureBoxWidth, PictureBoxHeight);
            g = Graphics.FromImage(bmp);
            DrawAxis(g);
        }

        public void updateHistoryData(ArrayList lastReceiveData)
        {
            for(int i = 0;i < DataIndex.Length;i++)
            {
                curves[i].updateData(new PointF((float)Convert.ToDouble(lastReceiveData[TIndex]), (float)Convert.ToDouble(lastReceiveData[DataIndex[i] - 1])));
                /* update the UpLimit and LowLimit*/
                
                if(AxisAutoScale)
                {
                    float temp = (float)Convert.ToDouble(lastReceiveData[DataIndex[i]]);
                    if (UpLimit < temp)
                         UpLimit = temp;
                    if (LowLimit > temp) 
                        LowLimit = temp;
                }
            }
            
        }

        public void updatePlot()
        {
            g.Clear(pictureBox1.BackColor);
            DrawAxis(g);
            DrawLines(g);
            DrawLegend(g);
            this.pictureBox1.CreateGraphics().DrawImage(bmp,0,0);
        } 

        public void DrawLines(Graphics g)
        {
            if (curves[0].TimeSpan > 0)
            {
                for (int i = 0; i < DataIndex.Length; i++)
                {
                    PointF[] tempPoint = curves[i].CurveData;
                    for (int j = 0; j < tempPoint.Length; j++)
                    {
                        tempPoint[j].X = (float) (1.0 * PictureBoxWidth * j / CurveDataLength  + fontWidth);
                        tempPoint[j].Y = (float) (PictureBoxHeight - (tempPoint[j].Y - LowLimit)/(UpLimit - LowLimit) * PictureBoxHeight - fontHeight + 12);
                    }
                       g.DrawCurve(curvePens[i], tempPoint);
                }
            }
        }

        public void DrawLegend(Graphics g)
        {
            for(int i = 0;i<DataIndex.Length;i++)
            {
                if(CurveLabels.Length > DataIndex[i] - 1)
                    g.DrawString(CurveLabels[DataIndex[i] - 1], axisFont, axisBrush, legendPointStart[i].X - 10, legendPointStart[i].Y);
                else
                    g.DrawString(Convert.ToString(DataIndex[i]), axisFont, axisBrush, legendPointStart[i].X - 10, legendPointStart[i].Y);
                g.DrawLine(curvePens[i],legendPointStart[i],legendPointEnd[i]);
            }
        }

        public void DrawAxis(Graphics g)
        {
            /* y axis */
            g.DrawLine(axisPen, fontWidth, PictureBoxHeight - 2 , fontWidth, 5);
            g.DrawLine(axisPen, fontWidth, 5, fontWidth - 3, 9);
            g.DrawLine(axisPen, fontWidth, 5, fontWidth + 3, 9);
            /* x axis  with 5 to correct the some offset */
            g.DrawLine(axisPen, fontWidth,PictureBoxHeight - 5, PictureBoxWidth, PictureBoxHeight - 5);
             
            for(int i=0;i <= 10;i++)
            {
                yAxis[i] = (int)(PictureBoxHeight - fontHeight - i * (PictureBoxHeight - fontHeight) / (float)10.0);
                /* add ticks */
                g.DrawString("_", axisFont, axisBrush, fontWidth, yAxis[i]);
            }
            int yOffSet = 4;
            for(int i = 0;i <= 10;i++)
            {
                g.DrawString(string.Format("{0:.00}",(LowLimit + i * (UpLimit - LowLimit) / 10)), axisFont, axisBrush, 0, (int)yAxis[i] + yOffSet);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DrawAxis(g);
            pictureBox1.CreateGraphics().DrawImage(bmp,0,0);
        }
    }
    /// <summary>
    /// Curve data class, which item's type is PointF
    /// </summary>
    public class Curve
    {
        private int _dataSaveLength = 200;
        public int DataSaveLength
        {
            get
            {
                return _dataSaveLength;
            }
            set
            {
                _dataSaveLength = value;
            }
        }
        /* use ring structure to limit the data */
        private int currentIndex = 0;
        /* curveData item is PointF type (t,value) */
        private PointF oldestPoint;
        private int count;
        private float _timeSpan;

        public float TimeSpan
        {
            get
            {
                return _timeSpan;
            }
            set
            {
                _timeSpan = value;
            }
        }
            
       
        private PointF[] _curveData;
        public PointF[] CurveData
        {
            get
            {
                int uplimit = Math.Min(count, DataSaveLength);
                PointF[] returnData = new PointF[uplimit];
                for (int i = 0;i < uplimit; i++)
                {
                    PointF temp = _curveData[(currentIndex - (uplimit - i)+ DataSaveLength) % DataSaveLength];
                    returnData[i] = new PointF(temp.X - oldestPoint.X,temp.Y) ;
                }
                return returnData;
        } 
            set
            {
                _curveData = value;
            }
        }
        public  Curve()
        {
            _curveData = new PointF[DataSaveLength];
        }
        public Curve(int length)
        {
            DataSaveLength = length;
            _curveData = new PointF[DataSaveLength];
            
        }
        
        public void updateData(PointF data)
        {
            
            _curveData[currentIndex] = data;
            count++;
           
            if (currentIndex < DataSaveLength - 1)
            {
                if(count == 1)
                {
                    oldestPoint = data;
                }
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
            }
            /* update time span */
            TimeSpan = data.X - oldestPoint.X; 
        }
        
    }
}
