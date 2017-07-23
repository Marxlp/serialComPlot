using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Collections;

namespace serialComPlot
{
    public partial class Form1 : Form
    {
        /* the SerialClass defined in the com.cs was not used now */
        //static SerialClass newSerialObject = new SerialClass();
        //public void sc_DataReceived(object sender,SerialDataReceivedEventArgs e, string bits)
        //{
        //    this.txtReceiveData.Text += bits; 
        //}
        public int maxLine = 100;
        public int maxChar = 20000;
        public int currentLine = 0;
        private bool Listening = false;
        private bool serialClosing = false;
        private string filePath;
        private string fileName;
        private bool _hexFlag = false;
        private byte[] byteBuf;
        public delegate void MyInvoke();
        public ArrayList lastReceiveData = new ArrayList();
        private StreamWriter fileData;
        private StreamReader configFile;
        private PlotForm newPlotForm = new PlotForm();
        private char[] splitChar = { ' ', '\t',',' };
        Thread updateDispData;
        public bool HexFlag
        {
            get { return _hexFlag; }
            set
            {
                if (value.GetType() == typeof(bool))
                    _hexFlag = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set the default value of baudrate
            cbBaudrate.SelectedIndex = 0;

            string[] str = SerialPort.GetPortNames();
            if(str.Length == 0)
            {
               
                return;
            }
            foreach(string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cbSerialComNum.Items.Add(s); 
                
            }
            // set the default com port according to current hardware
            cbSerialComNum.SelectedIndex = 0;
            // initial the thread
            this.updateDispData = new Thread(new ThreadStart(doWork));
            this.txtFileName.Text = "data.txt";
            filePath = AppDomain.CurrentDomain.BaseDirectory;
            fileName = this.txtFileName.Text;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialClosing = true;
                while (Listening) Application.DoEvents();
                serialPort1.Close();
                serialClosing = false;
                this.btnStart.Text = "打开串口";
                this.btnStart.BackColor = Color.Cyan;
                if (chkSave.Checked)
                {
                    fileData.Close();
                }
            }
            else 
            {
                int baudrate = Convert.ToInt32(this.cbBaudrate.Text);
                string comPort = this.cbSerialComNum.Text;
                serialPort1.PortName = comPort;
                serialPort1.BaudRate = baudrate;
                try
                {
                    if(chkSave.Checked)
                    {
                        if (fileName == string.Empty || filePath == string.Empty)
                            throw new Exception("please check the filename and the path");
                        else
                        {
                            string fileFullPath = filePath + "\\" + fileName;
                            if (File.Exists(fileFullPath))
                                /* if the file already exist warning */
                                if (MessageBox.Show("The file have been exist. Do you want overlay it ",
                                    "Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)
                                    == DialogResult.No)
                                    return;
                            fileData = new StreamWriter(filePath + "\\" + fileName);
                        }
                    }
                    serialPort1.Open();
                    this.btnStart.Text = "关闭串口";
                    this.btnStart.BackColor = Color.Red;
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           }
            
       }

        private void chkSave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSave.Checked)
            {
                btnSavePath.Enabled = true;
                txtFileName.Enabled = true;
            }
            else
            {
                btnSavePath.Enabled = false;
                txtFileName.Enabled = false;
            }
        }

        private void rBHex_CheckedChanged(object sender, EventArgs e)
        {
            txtReceiveData.Text = "";
            if (rBHex.Enabled)
                this.HexFlag = true;
            else
                this.HexFlag = false; 
        }

         void doWork()

        {
            MyInvoke mi = new MyInvoke(UpdateText);
            this.BeginInvoke(mi);
        }

        public  void UpdateText()
        {
            for (int i = 0; i < this.byteBuf.Length; i++)
            {
                txtReceiveData.AppendText(this.byteBuf[i].ToString("X2") + " ");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialClosing) return;
            try
            {
                Listening = true;
                if (this.HexFlag == true)
                {
                    int n = serialPort1.BytesToRead;
                    
                    this.BeginInvoke(
                        new MethodInvoker
                        (
                            delegate
                            {
                                if (txtReceiveData.Text.Length > maxChar)
                                    if (n < txtReceiveData.Text.Length)
                                        txtReceiveData.Text = txtReceiveData.Text.Remove(0, n);
                                byte[] buf = new byte[n];
                                serialPort1.Read(buf, 0, n);
                                for (int i = 0; i < buf.Length; i++)
                                {
                                    if (chkSave.Checked)
                                        fileData.Write(buf[i].ToString("x2"));
                                    txtReceiveData.AppendText(buf[i].ToString("X2") + " ");
                                }

                            }

                        ));

                }
                else
                {
                    this.txtReceiveData.Invoke(
                       new MethodInvoker(
                            delegate
                            {
                                string tempData = serialPort1.ReadLine();
                                lastReceiveData.Clear();
                                foreach(string s in tempData.Split(splitChar))
                                {
                                    if (s.Length >0)
                                        try
                                        {
                                            
                                        lastReceiveData.Add(Convert.ToDouble(s));

                                        }
                                        catch
                                        {
                                            lastReceiveData.Add(0.0);

                                        }
                                }
                                // update the newPlotForm according to new received data
                                if(newPlotForm.Visible)
                                {
                                    newPlotForm.update(lastReceiveData);
                                    if(newPlotForm.plotNowIsOn)
                                    {
                                        foreach(curve item in newPlotForm.curvePlots)
                                        {
                                            item.updateHistoryData(lastReceiveData);
                                            item.updatePlot();
                                        }
                                    }
                                }
                                if (this.currentLine == this.maxLine)
                                {
                                    string receiveData = this.txtReceiveData.Text.Remove(0, this.txtReceiveData.Text.IndexOf('\n')+1);
                                    this.txtReceiveData.Clear();
                                    this.txtReceiveData.AppendText(receiveData + tempData + "\n");
                                    
                                }
                                else
                                {
                                    this.currentLine++;
                                    string currentData = tempData;
                                    this.txtReceiveData.AppendText(currentData + "\n");
                                    if (chkSave.Checked)
                                        fileData.WriteLine(currentData);
                                }


                            }
                           )
                        );
                }
            }
            finally
            {
                Listening = false;
            }
            
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            if(fbdSaveData.ShowDialog() == DialogResult.OK)
                filePath = fbdSaveData.SelectedPath;
        }

        private void txtFileName_Enter(object sender, EventArgs e)
        {
            fileName = txtFileName.Text;
        }

        private void cbSerialComNum_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //do nothing
       }

        private void cbSerialComNum_DropDown(object sender, EventArgs e)
        {
            string[] str = SerialPort.GetPortNames();
            if(str == null)
            {
                MessageBox.Show("本机没有串口", "Error");
                return;
            }
            cbSerialComNum.Items.Clear();
            foreach(string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cbSerialComNum.Items.Add(s); 
                
            }
            // set the default com port according to current hardware
            cbSerialComNum.SelectedIndex = 0;

        }

        private void txtReceiveData_TextChanged(object sender, EventArgs e)
        {
            this.txtReceiveData.SelectionStart = this.txtReceiveData.TextLength;
            this.txtReceiveData.ScrollToCaret();
        }

        private void cbBaudrate_TextChanged(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialClosing = true;
                while (Listening) Application.DoEvents();
                serialPort1.Close();
                serialClosing = false;
                this.txtReceiveData.Clear();
                try
                {
                    serialPort1.BaudRate = Convert.ToInt32(cbBaudrate.Text);
                    serialPort1.Open();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            if (btnPlot.Text == "绘图")
            {

                newPlotForm.Show();
                newPlotForm.Size = this.txtReceiveData.Size;
                newPlotForm.Location = Point.Add(this.Location, new Size(180, 45));
                btnPlot.Text = "关闭绘图";
            }
            else
            {
                newPlotForm.Hide();
                btnPlot.Text = "绘图";
            }

        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            if(newPlotForm.FollowParent)
            {
                newPlotForm.Location = Point.Add(this.Location, new Size(180, 45));
            }
            
        }
    }
}
