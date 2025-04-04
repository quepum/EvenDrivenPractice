namespace WinFormsMiniGame;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        button1.BackColor = System.Drawing.Color.CornflowerBlue;
        button1.Location = new System.Drawing.Point(97, 312);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(60, 51);
        button1.TabIndex = 0;
        button1.Text = "<";
        button1.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        button2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        button2.BackColor = System.Drawing.Color.CornflowerBlue;
        button2.Location = new System.Drawing.Point(163, 312);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(59, 51);
        button2.TabIndex = 1;
        button2.Text = "v";
        button2.UseVisualStyleBackColor = false;
        // 
        // button3
        // 
        button3.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        button3.BackColor = System.Drawing.Color.CornflowerBlue;
        button3.Location = new System.Drawing.Point(228, 312);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(59, 51);
        button3.TabIndex = 2;
        button3.Text = ">";
        button3.UseVisualStyleBackColor = false;
        // 
        // button4
        // 
        button4.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        button4.BackColor = System.Drawing.Color.CornflowerBlue;
        button4.Location = new System.Drawing.Point(163, 255);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(59, 51);
        button4.TabIndex = 3;
        button4.Text = "^";
        button4.UseVisualStyleBackColor = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(618, 379);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        MinimumSize = new System.Drawing.Size(640, 435);
        Text = "MiniGame";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    #endregion
}