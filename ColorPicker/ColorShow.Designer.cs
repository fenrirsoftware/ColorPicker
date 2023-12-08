namespace ColorPicker;

partial class ColorShow
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lbl_color = new Label();
        btn_colorShow = new Button();
        toolStrip1 = new ToolStrip();
        toolStripLabel1 = new ToolStripLabel();
        toolStripLabel2 = new ToolStripLabel();
        toolStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // lbl_color
        // 
        lbl_color.AutoSize = true;
        lbl_color.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lbl_color.Location = new Point(51, 224);
        lbl_color.Name = "lbl_color";
        lbl_color.Size = new Size(31, 14);
        lbl_color.TabIndex = 0;
        lbl_color.Text = "renk";
        // 
        // btn_colorShow
        // 
        btn_colorShow.Location = new Point(12, 40);
        btn_colorShow.Name = "btn_colorShow";
        btn_colorShow.Size = new Size(216, 169);
        btn_colorShow.TabIndex = 1;
        btn_colorShow.UseVisualStyleBackColor = true;
        btn_colorShow.Click += btn_colorShow_Click;
        // 
        // toolStrip1
        // 
        toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2 });
        toolStrip1.Location = new Point(0, 0);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(241, 25);
        toolStrip1.TabIndex = 2;
        toolStrip1.Text = "toolStrip1";
        // 
        // toolStripLabel1
        // 
        toolStripLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        toolStripLabel1.Name = "toolStripLabel1";
        toolStripLabel1.Size = new Size(78, 22);
        toolStripLabel1.Text = "son seçilenler";
        toolStripLabel1.Click += toolStripLabel1_Click;
        // 
        // toolStripLabel2
        // 
        toolStripLabel2.Name = "toolStripLabel2";
        toolStripLabel2.Size = new Size(75, 22);
        toolStripLabel2.Text = "Renk Oluştur";
        toolStripLabel2.Click += toolStripLabel2_Click;
        // 
        // ColorShow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(241, 247);
        Controls.Add(toolStrip1);
        Controls.Add(btn_colorShow);
        Controls.Add(lbl_color);
        Name = "ColorShow";
        Text = "Color Picker";
        TopMost = true;
        Load += ColorShow_Load;
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl_color;
    private Button btn_colorShow;
    private ToolStrip toolStrip1;
    private ToolStripLabel toolStripLabel1;
    private ToolStripLabel toolStripLabel2;
}
