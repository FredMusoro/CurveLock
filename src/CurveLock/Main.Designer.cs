namespace CurveLock
{
  partial class Main
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.content = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // content
      // 
      this.content.Dock = System.Windows.Forms.DockStyle.Fill;
      this.content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
      this.content.Location = new System.Drawing.Point(0, 0);
      this.content.Name = "content";
      this.content.Size = new System.Drawing.Size(594, 472);
      this.content.TabIndex = 0;
      // 
      // Main
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(58)))));
      this.ClientSize = new System.Drawing.Size(594, 472);
      this.Controls.Add(this.content);
      this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.MaximizeBox = false;
      this.Name = "Main";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "CurveLock";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
      this.Load += new System.EventHandler(this.MainLoad);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel content;

  }
}

