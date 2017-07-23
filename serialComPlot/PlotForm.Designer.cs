namespace serialComPlot
{
    partial class PlotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlotForm));
            this.txtPlotGroup = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDataLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimeIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlotNow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dispBar10 = new serialComPlot.dispBar();
            this.dispBar9 = new serialComPlot.dispBar();
            this.dispBar8 = new serialComPlot.dispBar();
            this.dispBar7 = new serialComPlot.dispBar();
            this.dispBar6 = new serialComPlot.dispBar();
            this.dispBar5 = new serialComPlot.dispBar();
            this.dispBar4 = new serialComPlot.dispBar();
            this.dispBar3 = new serialComPlot.dispBar();
            this.dispBar2 = new serialComPlot.dispBar();
            this.dispBar1 = new serialComPlot.dispBar();
            this.lblDownLimit = new System.Windows.Forms.Label();
            this.lblUpLimit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDataLen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnClearConfig = new System.Windows.Forms.Button();
            this.btnCloseCurve = new System.Windows.Forms.Button();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.roundButton1 = new MyComponent.RoundButton();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlotGroup
            // 
            this.txtPlotGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPlotGroup.Location = new System.Drawing.Point(191, 40);
            this.txtPlotGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlotGroup.Name = "txtPlotGroup";
            this.txtPlotGroup.Size = new System.Drawing.Size(181, 21);
            this.txtPlotGroup.TabIndex = 0;
            this.txtPlotGroup.Text = "2,5,7|4,3,6";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblDataLen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 303);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDataLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTimeIndex);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnPlotNow);
            this.groupBox2.Controls.Add(this.txtPlotGroup);
            this.groupBox2.Location = new System.Drawing.Point(3, 235);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(452, 66);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // txtDataLabel
            // 
            this.txtDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDataLabel.Location = new System.Drawing.Point(70, 14);
            this.txtDataLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDataLabel.Name = "txtDataLabel";
            this.txtDataLabel.Size = new System.Drawing.Size(359, 21);
            this.txtDataLabel.TabIndex = 9;
            this.txtDataLabel.Text = "t,v_x,v_y,v_z";
            this.txtDataLabel.TextChanged += new System.EventHandler(this.txtDataLabel_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "数据标签";
            // 
            // txtTimeIndex
            // 
            this.txtTimeIndex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimeIndex.Location = new System.Drawing.Point(70, 40);
            this.txtTimeIndex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimeIndex.Name = "txtTimeIndex";
            this.txtTimeIndex.Size = new System.Drawing.Size(31, 21);
            this.txtTimeIndex.TabIndex = 7;
            this.txtTimeIndex.Text = "1";
            this.txtTimeIndex.TextChanged += new System.EventHandler(this.txtTimeIndex_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "时间索引";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "绘图数据分组:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnPlotNow
            // 
            this.btnPlotNow.Location = new System.Drawing.Point(377, 41);
            this.btnPlotNow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlotNow.Name = "btnPlotNow";
            this.btnPlotNow.Size = new System.Drawing.Size(50, 18);
            this.btnPlotNow.TabIndex = 3;
            this.btnPlotNow.Text = "PLOT";
            this.btnPlotNow.UseVisualStyleBackColor = true;
            this.btnPlotNow.Click += new System.EventHandler(this.btnPlotNow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dispBar10);
            this.groupBox1.Controls.Add(this.dispBar9);
            this.groupBox1.Controls.Add(this.dispBar8);
            this.groupBox1.Controls.Add(this.dispBar7);
            this.groupBox1.Controls.Add(this.dispBar6);
            this.groupBox1.Controls.Add(this.dispBar5);
            this.groupBox1.Controls.Add(this.dispBar4);
            this.groupBox1.Controls.Add(this.dispBar3);
            this.groupBox1.Controls.Add(this.dispBar2);
            this.groupBox1.Controls.Add(this.dispBar1);
            this.groupBox1.Controls.Add(this.lblDownLimit);
            this.groupBox1.Controls.Add(this.lblUpLimit);
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(452, 208);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dispBar10
            // 
            this.dispBar10.Channel = 0;
            this.dispBar10.CurrentValue = 0D;
            this.dispBar10.Location = new System.Drawing.Point(358, 15);
            this.dispBar10.LowLimit = 0D;
            this.dispBar10.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dispBar10.Name = "dispBar10";
            this.dispBar10.Size = new System.Drawing.Size(36, 185);
            this.dispBar10.TabIndex = 4;
            this.dispBar10.TotalChannels = 0;
            this.dispBar10.UpLimit = 100D;
            // 
            // dispBar9
            // 
            this.dispBar9.Channel = 0;
            this.dispBar9.CurrentValue = 0D;
            this.dispBar9.Location = new System.Drawing.Point(399, 15);
            this.dispBar9.LowLimit = 0D;
            this.dispBar9.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dispBar9.Name = "dispBar9";
            this.dispBar9.Size = new System.Drawing.Size(36, 185);
            this.dispBar9.TabIndex = 4;
            this.dispBar9.TotalChannels = 0;
            this.dispBar9.UpLimit = 100D;
            // 
            // dispBar8
            // 
            this.dispBar8.Channel = 0;
            this.dispBar8.CurrentValue = 0D;
            this.dispBar8.Location = new System.Drawing.Point(317, 15);
            this.dispBar8.LowLimit = 0D;
            this.dispBar8.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dispBar8.Name = "dispBar8";
            this.dispBar8.Size = new System.Drawing.Size(36, 185);
            this.dispBar8.TabIndex = 4;
            this.dispBar8.TotalChannels = 0;
            this.dispBar8.UpLimit = 100D;
            // 
            // dispBar7
            // 
            this.dispBar7.Channel = 0;
            this.dispBar7.CurrentValue = 0D;
            this.dispBar7.Location = new System.Drawing.Point(276, 15);
            this.dispBar7.LowLimit = 0D;
            this.dispBar7.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dispBar7.Name = "dispBar7";
            this.dispBar7.Size = new System.Drawing.Size(36, 185);
            this.dispBar7.TabIndex = 4;
            this.dispBar7.TotalChannels = 0;
            this.dispBar7.UpLimit = 100D;
            // 
            // dispBar6
            // 
            this.dispBar6.Channel = 0;
            this.dispBar6.CurrentValue = 0D;
            this.dispBar6.Location = new System.Drawing.Point(235, 15);
            this.dispBar6.LowLimit = 0D;
            this.dispBar6.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dispBar6.Name = "dispBar6";
            this.dispBar6.Size = new System.Drawing.Size(36, 185);
            this.dispBar6.TabIndex = 4;
            this.dispBar6.TotalChannels = 0;
            this.dispBar6.UpLimit = 100D;
            // 
            // dispBar5
            // 
            this.dispBar5.Channel = 0;
            this.dispBar5.CurrentValue = 0D;
            this.dispBar5.Location = new System.Drawing.Point(194, 15);
            this.dispBar5.LowLimit = 0D;
            this.dispBar5.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dispBar5.Name = "dispBar5";
            this.dispBar5.Size = new System.Drawing.Size(36, 185);
            this.dispBar5.TabIndex = 4;
            this.dispBar5.TotalChannels = 0;
            this.dispBar5.UpLimit = 100D;
            // 
            // dispBar4
            // 
            this.dispBar4.Channel = 0;
            this.dispBar4.CurrentValue = 0D;
            this.dispBar4.Location = new System.Drawing.Point(153, 15);
            this.dispBar4.LowLimit = 0D;
            this.dispBar4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dispBar4.Name = "dispBar4";
            this.dispBar4.Size = new System.Drawing.Size(36, 185);
            this.dispBar4.TabIndex = 4;
            this.dispBar4.TotalChannels = 0;
            this.dispBar4.UpLimit = 100D;
            // 
            // dispBar3
            // 
            this.dispBar3.Channel = 0;
            this.dispBar3.CurrentValue = 0D;
            this.dispBar3.Location = new System.Drawing.Point(112, 15);
            this.dispBar3.LowLimit = 0D;
            this.dispBar3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dispBar3.Name = "dispBar3";
            this.dispBar3.Size = new System.Drawing.Size(36, 185);
            this.dispBar3.TabIndex = 4;
            this.dispBar3.TotalChannels = 0;
            this.dispBar3.UpLimit = 100D;
            // 
            // dispBar2
            // 
            this.dispBar2.Channel = 0;
            this.dispBar2.CurrentValue = 0D;
            this.dispBar2.Location = new System.Drawing.Point(71, 15);
            this.dispBar2.LowLimit = 0D;
            this.dispBar2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dispBar2.Name = "dispBar2";
            this.dispBar2.Size = new System.Drawing.Size(36, 185);
            this.dispBar2.TabIndex = 4;
            this.dispBar2.TotalChannels = 0;
            this.dispBar2.UpLimit = 100D;
            // 
            // dispBar1
            // 
            this.dispBar1.Channel = 0;
            this.dispBar1.CurrentValue = 0D;
            this.dispBar1.Location = new System.Drawing.Point(30, 15);
            this.dispBar1.LowLimit = 0D;
            this.dispBar1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dispBar1.Name = "dispBar1";
            this.dispBar1.Size = new System.Drawing.Size(36, 185);
            this.dispBar1.TabIndex = 4;
            this.dispBar1.TotalChannels = 0;
            this.dispBar1.UpLimit = 100D;
            // 
            // lblDownLimit
            // 
            this.lblDownLimit.AutoSize = true;
            this.lblDownLimit.Location = new System.Drawing.Point(4, 161);
            this.lblDownLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDownLimit.Name = "lblDownLimit";
            this.lblDownLimit.Size = new System.Drawing.Size(29, 12);
            this.lblDownLimit.TabIndex = 3;
            this.lblDownLimit.Text = "下界";
            // 
            // lblUpLimit
            // 
            this.lblUpLimit.AutoSize = true;
            this.lblUpLimit.Location = new System.Drawing.Point(3, 141);
            this.lblUpLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpLimit.Name = "lblUpLimit";
            this.lblUpLimit.Size = new System.Drawing.Size(29, 12);
            this.lblUpLimit.TabIndex = 3;
            this.lblUpLimit.Text = "上界";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(63, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "0";
            // 
            // lblDataLen
            // 
            this.lblDataLen.AutoSize = true;
            this.lblDataLen.Location = new System.Drawing.Point(103, 202);
            this.lblDataLen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataLen.Name = "lblDataLen";
            this.lblDataLen.Size = new System.Drawing.Size(0, 12);
            this.lblDataLen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据个数：";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(502, 225);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(65, 29);
            this.btnSaveConfig.TabIndex = 3;
            this.btnSaveConfig.Text = "保存设置";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnClearConfig
            // 
            this.btnClearConfig.Location = new System.Drawing.Point(502, 156);
            this.btnClearConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearConfig.Name = "btnClearConfig";
            this.btnClearConfig.Size = new System.Drawing.Size(65, 27);
            this.btnClearConfig.TabIndex = 4;
            this.btnClearConfig.Text = "清空设置";
            this.btnClearConfig.UseVisualStyleBackColor = true;
            this.btnClearConfig.Click += new System.EventHandler(this.btnClearConfig_Click);
            // 
            // btnCloseCurve
            // 
            this.btnCloseCurve.Location = new System.Drawing.Point(502, 263);
            this.btnCloseCurve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCloseCurve.Name = "btnCloseCurve";
            this.btnCloseCurve.Size = new System.Drawing.Size(65, 29);
            this.btnCloseCurve.TabIndex = 3;
            this.btnCloseCurve.Text = "关闭绘图";
            this.btnCloseCurve.UseVisualStyleBackColor = true;
            this.btnCloseCurve.Click += new System.EventHandler(this.btnCloseCurve_Click);
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Location = new System.Drawing.Point(502, 191);
            this.btnLoadConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(65, 27);
            this.btnLoadConfig.TabIndex = 4;
            this.btnLoadConfig.Text = "加载设置";
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.DistanceToBorder = 4;
            this.roundButton1.Location = new System.Drawing.Point(515, 7);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(34, 33);
            this.roundButton1.TabIndex = 5;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundButton1_MouseDown);
            this.roundButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.roundButton1_MouseMove);
            this.roundButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.roundButton1_MouseUp);
            // 
            // PlotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(594, 312);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.btnLoadConfig);
            this.Controls.Add(this.btnClearConfig);
            this.Controls.Add(this.btnCloseCurve);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlotForm";
            this.Text = "Plot Control";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.PlotForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PlotForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlotForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlotForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlotForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlotGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDataLen;
        private System.Windows.Forms.Button btnPlotNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDownLimit;
        private System.Windows.Forms.Label lblUpLimit;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnClearConfig;
        private System.Windows.Forms.Button btnCloseCurve;
        private MyComponent.RoundButton roundButton1;
        private dispBar dispBar10;
        private dispBar dispBar9;
        private dispBar dispBar8;
        private dispBar dispBar7;
        private dispBar dispBar6;
        private dispBar dispBar5;
        private dispBar dispBar4;
        private dispBar dispBar3;
        private dispBar dispBar2;
        private dispBar dispBar1;
        private System.Windows.Forms.TextBox txtTimeIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoadConfig;
        private System.Windows.Forms.TextBox txtDataLabel;
        private System.Windows.Forms.Label label5;
    }
}