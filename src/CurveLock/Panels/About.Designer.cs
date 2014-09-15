namespace CurveLock.Panels
{
  partial class About
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
      this.header = new System.Windows.Forms.Label();
      this.back = new System.Windows.Forms.LinkLabel();
      this.copyright = new System.Windows.Forms.Label();
      this.version = new System.Windows.Forms.Label();
      this.libsodium = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // header
      // 
      this.header.AutoSize = true;
      this.header.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.header.Location = new System.Drawing.Point(36, 0);
      this.header.Name = "header";
      this.header.Size = new System.Drawing.Size(522, 86);
      this.header.TabIndex = 0;
      this.header.Text = "About CurveLock";
      // 
      // back
      // 
      this.back.AutoSize = true;
      this.back.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.back.Location = new System.Drawing.Point(507, 436);
      this.back.Name = "back";
      this.back.Size = new System.Drawing.Size(51, 25);
      this.back.TabIndex = 2;
      this.back.TabStop = true;
      this.back.Text = "Back";
      this.back.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackLinkClicked);
      // 
      // copyright
      // 
      this.copyright.AutoSize = true;
      this.copyright.Location = new System.Drawing.Point(46, 86);
      this.copyright.Name = "copyright";
      this.copyright.Size = new System.Drawing.Size(95, 25);
      this.copyright.TabIndex = 3;
      this.copyright.Text = "Copyright";
      // 
      // version
      // 
      this.version.AutoSize = true;
      this.version.Location = new System.Drawing.Point(46, 111);
      this.version.Name = "version";
      this.version.Size = new System.Drawing.Size(76, 25);
      this.version.TabIndex = 4;
      this.version.Text = "Version";
      // 
      // libsodium
      // 
      this.libsodium.AutoSize = true;
      this.libsodium.Location = new System.Drawing.Point(46, 436);
      this.libsodium.Name = "libsodium";
      this.libsodium.Size = new System.Drawing.Size(269, 25);
      this.libsodium.TabIndex = 5;
      this.libsodium.Text = "Proudly powered by libsodium";
      // 
      // About
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(58)))));
      this.Controls.Add(this.libsodium);
      this.Controls.Add(this.version);
      this.Controls.Add(this.copyright);
      this.Controls.Add(this.back);
      this.Controls.Add(this.header);
      this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
      this.Name = "About";
      this.Size = new System.Drawing.Size(594, 472);
      this.Load += new System.EventHandler(this.AboutLoad);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label header;
    private System.Windows.Forms.LinkLabel back;
    private System.Windows.Forms.Label copyright;
    private System.Windows.Forms.Label version;
    private System.Windows.Forms.Label libsodium;
  }
}
