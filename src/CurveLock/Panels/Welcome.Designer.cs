namespace CurveLock.Panels
{
  partial class Welcome
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
      this.header = new System.Windows.Forms.Label();
      this.info = new System.Windows.Forms.Label();
      this.getStarted = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // header
      // 
      this.header.AutoSize = true;
      this.header.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.header.Location = new System.Drawing.Point(137, 0);
      this.header.Name = "header";
      this.header.Size = new System.Drawing.Size(320, 86);
      this.header.TabIndex = 0;
      this.header.Text = "Welcome!";
      // 
      // info
      // 
      this.info.Location = new System.Drawing.Point(14, 86);
      this.info.Name = "info";
      this.info.Size = new System.Drawing.Size(566, 308);
      this.info.TabIndex = 1;
      this.info.Text = resources.GetString("info.Text");
      // 
      // getStarted
      // 
      this.getStarted.AutoSize = true;
      this.getStarted.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.getStarted.Location = new System.Drawing.Point(474, 436);
      this.getStarted.Name = "getStarted";
      this.getStarted.Size = new System.Drawing.Size(106, 25);
      this.getStarted.TabIndex = 2;
      this.getStarted.TabStop = true;
      this.getStarted.Text = "Get Started";
      this.getStarted.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.getStarted.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GetStartedLinkClicked);
      // 
      // Welcome
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(58)))));
      this.Controls.Add(this.getStarted);
      this.Controls.Add(this.info);
      this.Controls.Add(this.header);
      this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
      this.Name = "Welcome";
      this.Size = new System.Drawing.Size(594, 472);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label header;
    private System.Windows.Forms.Label info;
    private System.Windows.Forms.LinkLabel getStarted;
  }
}
