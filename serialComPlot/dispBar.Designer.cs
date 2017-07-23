namespace serialComPlot
{
    partial class dispBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myPanel1 = new serialComPlot.myPanel();
            this.myComboBox1 = new MyComponent.myComboBox();
            this.myTextBox2 = new MyComponent.myTextBox();
            this.myTextBox1 = new MyComponent.myTextBox();
            this.SuspendLayout();
            // 
            // myPanel1
            // 
            this.myPanel1.Location = new System.Drawing.Point(5, 3);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(47, 174);
            this.myPanel1.TabIndex = 5;
            // 
            // myComboBox1
            // 
            this.myComboBox1.Channels = 0;
            this.myComboBox1.Choice = 0;
            this.myComboBox1.FormattingEnabled = true;
            this.myComboBox1.Location = new System.Drawing.Point(1, 245);
            this.myComboBox1.Name = "myComboBox1";
            this.myComboBox1.Size = new System.Drawing.Size(51, 26);
            this.myComboBox1.TabIndex = 4;
            this.myComboBox1.SelectedIndexChanged += new System.EventHandler(this.myComboBox1_SelectedIndexChanged);
            // 
            // myTextBox2
            // 
            this.myTextBox2.Location = new System.Drawing.Point(1, 183);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Size = new System.Drawing.Size(51, 28);
            this.myTextBox2.TabIndex = 3;
            this.myTextBox2.Text = "100";
            this.myTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myTextBox2_KeyPress);
            this.myTextBox2.Leave += new System.EventHandler(this.myTextBox2_Leave);
            // 
            // myTextBox1
            // 
            this.myTextBox1.Location = new System.Drawing.Point(1, 214);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(51, 28);
            this.myTextBox1.TabIndex = 3;
            this.myTextBox1.Text = "0";
            this.myTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myTextBox1_KeyPress);
            this.myTextBox1.Leave += new System.EventHandler(this.myTextBox1_Leave);
            // 
            // dispBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myPanel1);
            this.Controls.Add(this.myComboBox1);
            this.Controls.Add(this.myTextBox2);
            this.Controls.Add(this.myTextBox1);
            this.Name = "dispBar";
            this.Size = new System.Drawing.Size(54, 278);
            this.Load += new System.EventHandler(this.dispBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MyComponent.myTextBox myTextBox1;
        private MyComponent.myTextBox myTextBox2;
        private MyComponent.myComboBox myComboBox1;
        private myPanel myPanel1;
    }
}
