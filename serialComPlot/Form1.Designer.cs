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
            this.lblSerialComNum.Location = new System.Drawing.Point(9, 25);
            this.lblSerialComNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSerialComNum.Name = "lblSerialComNum";
            this.lblSerialComNum.Size = new System.Drawing.Size(41, 12);
            this.lblSerialComNum.TabIndex = 0;
            this.lblSerialComNum.Text = "串口号";
            // 
            // lblBaudrate
            // 
            this.lblBaudrate.AutoSize = true;
            this.lblBaudrate.Location = new System.Drawing.Point(9, 59);
            this.lblBaudrate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaudrate.Name = "lblBaudrate";
            this.lblBaudrate.Size = new System.Drawing.Size(41, 12);
            this.lblBaudrate.TabIndex = 0;
            this.lblBaudrate.Text = "波特率";
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbBaudrate.Location = new System.Drawing.Point(61, 57);
            this.cbBaudrate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(87, 20);
            this.cbBaudrate.TabIndex = 1;
            this.cbBaudrate.TextChanged += new System.EventHandler(this.cbBaudrate_TextChanged);
            // 
            // cbSerialComNum
            // 
            this.cbSerialComNum.FormattingEnabled = true;
            this.cbSerialComNum.Location = new System.Drawing.Point(62, 25);
            this.cbSerialComNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSerialComNum.Name = "cbSerialComNum";
            this.cbSerialComNum.Size = new System.Drawing.Size(85, 20);
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
            this.gpHexChar.Location = new System.Drawing.Point(11, 93);
            this.gpHexChar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpHexChar.Name = "gpHexChar";
            this.gpHexChar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpHexChar.Size = new System.Drawing.Size(145, 41);
            this.gpHexChar.TabIndex = 4;
            this.gpHexChar.TabStop = false;
            // 
            // rBChar
            // 
            this.rBChar.AutoSize = true;
            this.rBChar.Checked = true;
            this.rBChar.Location = new System.Drawing.Point(78, 17);
            this.rBChar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBChar.Name = "rBChar";
            this.rBChar.Size = new System.Drawing.Size(47, 16);
            this.rBChar.TabIndex = 0;
            this.rBChar.TabStop = true;
            this.rBChar.Text = "字符";
            this.rBChar.UseVisualStyleBackColor = true;
            // 
            // rBHex
            // 
            this.rBHex.AutoSize = true;
            this.rBHex.Location = new System.Drawing.Point(15, 17);
            this.rBHex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBHex.Name = "rBHex";
            this.rBHex.Size = new System.Drawing.Size(41, 16);
            this.rBHex.TabIndex = 0;
            this.rBHex.Text = "Hex";
            this.rBHex.UseVisualStyleBackColor = true;
            this.rBHex.CheckedChanged += new System.EventHandler(this.rBHex_CheckedChanged);
            // 
            // chkSave
            // 
            this.chkSave.AutoSize = true;
            this.chkSave.Location = new System.Drawing.Point(12, 14);
            this.chkSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSave.Name = "chkSave";
            this.chkSave.Size = new System.Drawing.Size(48, 16);
            this.chkSave.TabIndex = 5;
            this.chkSave.Text = "保存";
            this.chkSave.UseVisualStyleBackColor = true;
            this.chkSave.CheckedChanged += new System.EventHandler(this.chkSave_CheckedChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(55, 42);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(87, 21);
            this.txtFileName.TabIndex = 6;
            this.txtFileName.Enter += new System.EventHandler(this.txtFileName_Enter);
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(71, 13);
            this.btnSavePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(69, 24);
            this.btnSavePath.TabIndex = 7;
            this.btnSavePath.Text = "路径";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(8, 45);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(41, 12);
            this.lblFileName.TabIndex = 8;
            this.lblFileName.Text = "文件名";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Cyan;
            this.btnStart.Location = new System.Drawing.Point(31, 253);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 33);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(149, 73);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtReceiveData
            // 
            this.txtReceiveData.EnableAutoDragDrop = true;
            this.txtReceiveData.Enabled = false;
            this.txtReceiveData.Location = new System.Drawing.Point(171, 13);
            this.txtReceiveData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReceiveData.Name = "txtReceiveData";
            this.txtReceiveData.ReadOnly = true;
            this.txtReceiveData.Size = new System.Drawing.Size(634, 313);
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
            this.btnPlot.Location = new System.Drawing.Point(31, 294);
            this.btnPlot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(105, 34);
            this.btnPlot.TabIndex = 13;
            this.btnPlot.Text = "绘图";
            this.btnPlot.UseVisualStyleBackColor = false;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(816, 374);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

