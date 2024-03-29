namespace ShowAbfComments;

partial class Form1
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
        richTextBox1 = new RichTextBox();
        label1 = new Label();
        button1 = new Button();
        SuspendLayout();
        // 
        // richTextBox1
        // 
        richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        richTextBox1.Location = new Point(12, 62);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(1381, 732);
        richTextBox1.TabIndex = 0;
        richTextBox1.Text = "";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 31);
        label1.Name = "label1";
        label1.Size = new Size(233, 25);
        label1.TabIndex = 1;
        label1.Text = "Paste a list of ABF file paths:";
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        button1.Location = new Point(1281, 12);
        button1.Name = "button1";
        button1.Size = new Size(112, 44);
        button1.TabIndex = 2;
        button1.Text = "Analyze";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1405, 806);
        Controls.Add(button1);
        Controls.Add(label1);
        Controls.Add(richTextBox1);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ABF Comment Viewer";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private RichTextBox richTextBox1;
    private Label label1;
    private Button button1;
}
