namespace ColorPicker
{
    partial class colorcreate
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
            trackBarRed = new TrackBar();
            trackBarBlue = new TrackBar();
            trackBarGreen = new TrackBar();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            SuspendLayout();
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(35, 22);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(104, 45);
            trackBarRed.TabIndex = 0;
            trackBarRed.Scroll += trackBarRed_Scroll;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(282, 22);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(104, 45);
            trackBarBlue.TabIndex = 1;
            trackBarBlue.Scroll += trackBarBlue_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(156, 22);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(112, 45);
            trackBarGreen.TabIndex = 2;
            trackBarGreen.Scroll += trackBarGreen_Scroll;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(35, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 186);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 4);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Blue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 4);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "Green";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 4);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 8;
            label5.Text = "Red";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 265);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 296);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 23);
            textBox2.TabIndex = 10;
            // 
            // colorcreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 327);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(trackBarGreen);
            Controls.Add(trackBarBlue);
            Controls.Add(trackBarRed);
            Name = "colorcreate";
            Text = "colorcreate";
            FormClosing += colorcreate_FormClosing;
            Load += colorcreate_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBarRed;
        private TrackBar trackBarBlue;
        private TrackBar trackBarGreen;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}