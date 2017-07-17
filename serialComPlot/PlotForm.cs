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
using System.IO;


namespace serialComPlot
{
    public partial class PlotForm : Form
    {
        private ArrayList _barData;
        public ArrayList BarData
            {
            set
            {
                _barData = value;
            }
            get
            {
                return _barData;
            }

            }
        /* the length of the data received */
        private int _dataLength;
        public int DataLength
        {
            set
            {
                _dataLength = value;
            }
            get
            {
                return _dataLength;
            }
        }

        private dispBar[] bars = new dispBar[10];
        private bool _followParent = true;
        public bool FollowParent
        {
            set
            {
                _followParent = value;
            }
            get
            {
                return _followParent;
            }
        }
        private Point mousePos;
        private int _oldDataLength;
        public int OldDataLength
        {
            get
            {
                return _oldDataLength;
            }
            set
            {
                _oldDataLength = value;
            }
        }
        private static bool mouseDown = false;
        private string configFilename = "plotConfig.ini";
        public bool dataLengthChange()
        {
            if (OldDataLength != DataLength)
                return true;
            else
                return false;
        }

        private ArrayList _comboxList;
        public ArrayList ComboxList
        {
            set
            {
                _comboxList = value;
            }
            get
            {
                return _comboxList;
            }
        }
        private Point _initLocation;
        public Point InitLocation
        {
            get
            {
                return _initLocation;
            }
            set
            {
                _initLocation = value;
            }
        }
        public bool plotNowIsOn = false;
        public curve[] curvePlots;
        char curvePlotSplit = '|';
        char curveSplit = ',';
        string[] curveLabels;
        public void updateDataLen(ArrayList lastReceiveData)
        {
            DataLength = lastReceiveData.Count;
            OldDataLength = Convert.ToInt32(this.label3.Text);
            this.label3.Text = Convert.ToString(DataLength);
        }
        /* update the bar plot */
        public void updateBar()
        {
            foreach(dispBar item in bars)
            {
                if(item.Channel != 0)
                {
                    item.CurrentValue = Convert.ToDouble(BarData[item.Channel - 1]);
                    item.plotBar();
                }
                
            }            

        }
        public void updateComboxBox()
        {
            if(this.dataLengthChange())
            {
                foreach(dispBar item in bars)
                {
                    item.TotalChannels = DataLength;
                    item.updateCombox();
                }
     
            }
       }

        public void update(ArrayList lastReceiveData)
        {
            this.BarData = lastReceiveData;
            this.updateBar();
            this.updateDataLen(lastReceiveData);
            this.updateComboxBox();
        }
        
        public PlotForm()
        {
            InitializeComponent();
            int i = 0; 
            foreach(Control ctrl in this.groupBox1.Controls)
            {
                if (ctrl is dispBar)
                {
                    bars[i] = (dispBar) ctrl;
                    i++;
                }
                
           }
            
        }

        private void PlotForm_Load(object sender, EventArgs e)
        {
            
        }

        private void PlotForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnPlotNow_Click(object sender, EventArgs e)
        {
            if (plotNowIsOn)
            {
                plotNowIsOn = false;
            }
            else
            {
                string[] curvePlotConfig = this.txtPlotGroup.Text.Split(curvePlotSplit);
                curvePlots = new curve[curvePlotConfig.Length];
                curveLabels = txtDataLabel.Text.Split(curveSplit);
                for(int i = 0;i<curvePlotConfig.Length;i++)
                {
                    string[] temp = curvePlotConfig[i].Split(curveSplit);
                    int[] tempDataIndex = new int[temp.Length];
                    for(int j = 0;j < temp.Length; j++)
                    {
                        if (Convert.ToInt32(temp[j]) <= DataLength)
                            tempDataIndex[j] = Convert.ToInt32(temp[j]);
                        else
                            MessageBox.Show("The index is out of range", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning); 
                    }
                    curvePlots[i] = new curve();
                    curvePlots[i].DataIndex = tempDataIndex;
                    curvePlots[i].CurveLabels = curveLabels;
                    curvePlots[i].Show();
                }
                plotNowIsOn = true;
            }

            //
            // wait to be finished
            //
        }

        private void roundButton1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            FollowParent = false;
            mousePos = new Point(e.X, e.Y);
        }

        private void roundButton1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void roundButton1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mouseDown)
                {
                    this.Location = Point.Add(this.Location,new Size(e.X - mousePos.X,e.Y - mousePos.Y));
                }
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            StreamWriter configWriter = new StreamWriter(configFilename, true);
            // write comment in the config file
            configWriter.WriteLine("#BarName:UpLimit LowLimit Channel");
            foreach(dispBar item in bars)
            {
                configWriter.WriteLine(item.Name +":" +  Convert.ToString(item.UpLimit) + " " 
                    + Convert.ToString(item.LowLimit) + " " + Convert.ToString(item.Channel));
            }
            configWriter.WriteLine("#t channel");
            configWriter.WriteLine(this.txtTimeIndex.Name + ":" + this.txtTimeIndex.Text);
            configWriter.WriteLine("#plot group");
            configWriter.WriteLine(this.txtPlotGroup.Name + ":" + this.txtPlotGroup.Text);
            configWriter.Close();
            MessageBox.Show("Your Config has been saved","prompt",MessageBoxButtons.OK);
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            if(File.Exists(configFilename))
            {
                StreamReader configRead = new StreamReader(configFilename);
                string line;
                string[] config;
                char[] split = { ':', ' ' };
                while( true)
                {
                    try
                    {
                        line = configRead.ReadLine(); 
                        if(line[0] != '#' && line[0] != '\n')
                            {
                                config = line.Split(split);
                                if(config.Length < 2)
                                {
                                    break;
                                }
                                else
                                {
                                    
                                    switch(config[0])
                                    {
                                        case "dispBar1":
                                            dispBar1.UpLimit = Convert.ToDouble(config[1]);
                                            dispBar1.LowLimit = Convert.ToDouble(config[2]);
                                            dispBar1.UpdateTextFromLimit();
                                            if(Convert.ToInt32(config[3]) > DataLength)
                                            {
                                                dispBar1.setComboxSelectedItem( Convert.ToInt32(config[3])); 
                                            }
                                            break;
                                        case "dispBar2":
                                            dispBar2.UpLimit = Convert.ToDouble(config[1]);
                                            dispBar2.LowLimit = Convert.ToDouble(config[2]);
                                            dispBar2.UpdateTextFromLimit();
                                            if(Convert.ToInt32(config[3]) > DataLength)
                                            {
                                                dispBar2.setComboxSelectedItem( Convert.ToInt32(config[3])); 
                                            }
                                            break;
                                        case "dispBar3":
                                            dispBar3.UpLimit = Convert.ToDouble(config[1]);
                                            dispBar3.LowLimit = Convert.ToDouble(config[2]);
                                            dispBar3.UpdateTextFromLimit();
                                            if(Convert.ToInt32(config[3]) > DataLength)
                                            {
                                                dispBar3.setComboxSelectedItem( Convert.ToInt32(config[3])); 
                                            }
                                            break;
                                        case "dispBar4":
                                            dispBar4.UpLimit = Convert.ToDouble(config[1]);
                                            dispBar4.LowLimit = Convert.ToDouble(config[2]);
                                            dispBar4.UpdateTextFromLimit();
                                             if(Convert.ToInt32(config[3]) > DataLength)
                                            {
                                                dispBar4.setComboxSelectedItem( Convert.ToInt32(config[3])); 
                                            }
                                            break;
                                        case "dispBar5":
                                            dispBar5.UpLimit = Convert.ToDouble(config[1]);
                                            dispBar5.LowLimit = Convert.ToDouble(config[2]);
                                            dispBar5.UpdateTextFromLimit();
                                             if(Convert.ToInt32(config[3]) > DataLength)
                                            {
                                                dispBar5.setComboxSelectedItem( Convert.ToInt32(config[3])); 
                                            }
                                            break;
                                        case "dispBar6":
                                            dispBar6.UpLimit = Convert.ToDouble(config[1]);
                                            dispBar6.LowLimit = Convert.ToDouble(config[2]);
                                            dispBar6.UpdateTextFromLimit();
                                             if(Convert.ToInt32(config[3]) > DataLength)
                                            {
                                                dispBar6.setComboxSelectedItem( Convert.ToInt32(config[3])); 
                                            }
                                            break;
                                        case "dispBar7":
                                            dispBar7.UpLimit = Convert.ToDouble(config[1]);
                                            dispBar7.LowLimit = Convert.ToDouble(config[2]);
                                            dispBar7.UpdateTextFromLimit();
                                             if(Convert.ToInt32(config[3]) > DataLength)
                                            {
                                                dispBar7.setComboxSelectedItem( Convert.ToInt32(config[3])); 
                                            }
                                            break;
                                        case "dispBar8":
                                            dispBar8.UpLimit = Convert.ToDouble(config[1]);
                                            dispBar8.LowLimit = Convert.ToDouble(config[2]);
                                            dispBar8.UpdateTextFromLimit();
                                             if(Convert.ToInt32(config[3]) > DataLength)
                                            {
                                                dispBar8.setComboxSelectedItem( Convert.ToInt32(config[3])); 
                                            }
                                            break;
                                        case "dispBar9":
                                            dispBar9.UpLimit = Convert.ToDouble(config[1]);
                                            dispBar9.LowLimit = Convert.ToDouble(config[2]);
                                            dispBar9.UpdateTextFromLimit();
                                             if(Convert.ToInt32(config[3]) > DataLength)
                                            {
                                                dispBar9.setComboxSelectedItem( Convert.ToInt32(config[3])); 
                                            }
                                            break;
                                        case "dispBar10":
                                            dispBar10.UpLimit = Convert.ToDouble(config[1]);
                                            dispBar10.LowLimit = Convert.ToDouble(config[2]);
                                            dispBar10.UpdateTextFromLimit();
                                             if(Convert.ToInt32(config[3]) > DataLength)
                                            {
                                                dispBar10.setComboxSelectedItem( Convert.ToInt32(config[3])); 
                                            }
                                            break;
                                        case "txtTimeIndex":
                                            txtTimeIndex.Text = config[1];
                                            break;
                                        case "txtPlotGroup":
                                            txtPlotGroup.Text = config[1];
                                            break;
                                        default:
                                            break;
                                        }
                                        
                                    }
                              
                                }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("end of file");
                        break;
                    }
                    
                }
            }
        }

        /* add drag support */
        private void PlotForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mousePos = new Point(e.X, e.Y);
        }

        private void PlotForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void PlotForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown && FollowParent == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Location = Point.Add(this.Location,new Size(e.X - mousePos.X,e.Y - mousePos.Y));
                }

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            PlotForm_MouseDown(sender, e);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown && FollowParent == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Location = Point.Add(this.Location,new Size(e.X - mousePos.X,e.Y - mousePos.Y));
                }
            }
        }

        private void btnClearConfig_Click(object sender, EventArgs e)
        {
            this.txtPlotGroup.Text = "";
            this.txtTimeIndex.Text = "";
            foreach(Control ctrl in this.groupBox1.Controls)
            {
                if (ctrl is dispBar)
                {
                    (ctrl as dispBar).UpLimit = 100;
                    (ctrl as dispBar).LowLimit = 0;
                    (ctrl as dispBar).UpdateTextFromLimit();
                }
            }

        }

        private void btnCloseCurve_Click(object sender, EventArgs e)
        {
            foreach (curve item in curvePlots)
            {
                item.Close();
                plotNowIsOn = false;
            }
        }
    }
}
