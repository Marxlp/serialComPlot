namespace serialComPlot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSerialComNum = new System.Windows.Forms.Label();
            this.lblBaudrate = new System.Windows.Forms.Label();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.cbSerialComNum = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gpHexChar = new System.Windows.Forms.GroupBox();
            this.rBChar = new System.Windows.Forms.RadioButton();
            this.rBHex = new System.Windows.Forms.RadioButton();
            this.chkSave = new System.Windows.Forms.CheckBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fbdSaveData = new System.Windows.Forms.FolderBrowserDialog();
            this.txtReceiveData = new System.Windows.Forms.RichTextBox();
            this.btnPlot = new System.Windows.Forms.Button();
            this.gpHexChar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSerialComNum
            // 
            this.lblSerialComNum.AutoSize = true;
            this.lblSerialComNum.Location = new System.Drawing.Point(14, 38);
            this.lblSerialComNum.Name = "lblSerialComNum";
            this.lblSerialComNum.Size = new System.Drawing.Size(62, 18);
            this.lblSerialComNum.TabIndex = 0;
            this.lblSerialComNum.Text = "串口号";
            // 
            // lblBaudrate
            // 
            this.lblBaudrate.AutoSize = true;
            this.lblBaudrate.Location = new System.Drawing.Point(14, 88);
            this.lblBaudrate.Name = "lblBaudrate";
            this.lblBaudrate.Size = new System.Drawing.Size(62, 18);
            this.lblBaudrate.TabIndex = 0;
            this.lblBaudrate.Text = "波特率";
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbBaudrate.Location = new System.Drawing.Point(91, 85);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(128, 26);
            this.cbBaudrate.TabIndex = 1;
            this.cbBaudrate.TextChanged += new System.EventHandler(this.cbBaudrate_TextChanged);
            // 
            // cbSerialComNum
            // 
            this.cbSerialComNum.FormattingEnabled = true;
            this.cbSerialComNum.Location = new System.Drawing.Point(93, 37);
            this.cbSerialComNum.Name = "cbSerialComNum";
            this.cbSerialComNum.Size = new System.Drawing.Size(125, 26);
            this.cbSerialComNum.TabIndex = 2;
            this.cbSerialComNum.DropDown += new System.EventHandler(this.cbSerialComNum_DropDown);
            this.cbSerialComNum.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cbSerialComNum_MouseDoubleClick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // gpHexChar
            // 
            this.gpHexChar.Controls.Add(this.rBChar);
            this.gpHexChar.Controls.Add(this.rBHex);
            this.gpHexChar.Location = new System.Drawing.Point(17, 140);
            this.gpHexChar.Name = "gpHexChar";
            this.gpHexChar.Size = new System.Drawing.Size(218, 61);
            this.gpHexChar.TabIndex = 4;
            this.gpHexChar.TabStop = false;
            // 
            // rBChar
            // 
            this.rBChar.AutoSize = true;
            this.rBChar.Checked = true;
            this.rBChar.Location = new System.Drawing.Point(117, 26);
            this.rBChar.Name = "rBChar";
            this.rBChar.Size = new System.Drawing.Size(69, 22);
            this.rBChar.TabIndex = 0;
            this.rBChar.TabStop = true;
            this.rBChar.Text = "字符";
            this.rBChar.UseVisualStyleBackColor = true;
            // 
            // rBHex
            // 
            this.rBHex.AutoSize = true;
            this.rBHex.Location = new System.Drawing.Point(23, 26);
            this.rBHex.Name = "rBHex";
            this.rBHex.Size = new System.Drawing.Size(60, 22);
            this.rBHex.TabIndex = 0;
            this.rBHex.Text = "Hex";
            this.rBHex.UseVisualStyleBackColor = true;
            this.rBHex.CheckedChanged += new System.EventHandler(this.rBHex_CheckedChanged);
            // 
            // chkSave
            // 
            this.chkSave.AutoSize = true;
            this.chkSave.Location = new System.Drawing.Point(18, 21);
            this.chkSave.Name = "chkSave";
            this.chkSave.Size = new System.Drawing.Size(70, 22);
            this.chkSave.TabIndex = 5;
            this.chkSave.Text = "保存";
            this.chkSave.UseVisualStyleBackColor = true;
            this.chkSave.CheckedChanged += new System.EventHandler(this.chkSave_CheckedChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(82, 63);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(128, 28);
            this.txtFileName.TabIndex = 6;
            this.txtFileName.Enter += new System.EventHandler(this.txtFileName_Enter);
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(106, 19);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(103, 36);
            this.btnSavePath.TabIndex = 7;
            this.btnSavePath.Text = "路径";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(12, 67);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(62, 18);
            this.lblFileName.TabIndex = 8;
            this.lblFileName.Text = "文件名";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Cyan;
            this.btnStart.Location = new System.Drawing.Point(46, 380);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(157, 50);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "打开串口";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Controls.Add(this.btnSavePath);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.chkSave);
            this.groupBox1.Location = new System.Drawing.Point(12, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 110);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtReceiveData
            // 
            this.txtReceiveData.EnableAutoDragDrop = true;
            this.txtReceiveData.Enabled = false;
            this.txtReceiveData.Location = new System.Drawing.Point(257, 19);
            this.txtReceiveData.Name = "txtReceiveData";
            this.txtReceiveData.ReadOnly = true;
            this.txtReceiveData.Size = new System.Drawing.Size(771, 468);
            this.txtReceiveData.TabIndex = 12;
            this.txtReceiveData.TabStop = false;
            this.txtReceiveData.Text = "";
            this.txtReceiveData.TextChanged += new System.EventHandler(this.txtReceiveData_TextChanged);
            // 
            // btnPlot
            // 
            this.btnPlot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlot.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlot.Location = new System.Drawing.Point(47, 441);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(157, 51);
            this.btnPlot.TabIndex = 13;
            this.btnPlot.Text = "绘图";
            this.btnPlot.UseVisualStyleBackColor = false;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1047, 518);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.txtReceiveData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gpHexChar);
            this.Controls.Add(this.cbSerialComNum);
            this.Controls.Add(this.cbBaudrate);
            this.Controls.Add(this.lblBaudrate);
            this.Controls.Add(this.lblSerialComNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.gpHexChar.ResumeLayout(false);
            this.gpHexChar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerialComNum;
        private System.Windows.Forms.Label lblBaudrate;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.ComboBox cbSerialComNum;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox gpHexChar;
        private System.Windows.Forms.RadioButton rBChar;
        private System.Windows.Forms.RadioButton rBHex;
        private System.Windows.Forms.CheckBox chkSave;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FolderBrowserDialog fbdSaveData;
        private System.Windows.Forms.RichTextBox txtReceiveData;
        private System.Windows.Forms.Button btnPlot;
    }
}

