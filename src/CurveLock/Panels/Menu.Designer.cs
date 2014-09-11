namespace CurveLock.Panels
{
  partial class Menu
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
      this.encryptText = new System.Windows.Forms.LinkLabel();
      this.encryptFile = new System.Windows.Forms.LinkLabel();
      this.decryptText = new System.Windows.Forms.LinkLabel();
      this.decryptFile = new System.Windows.Forms.LinkLabel();
      this.about = new System.Windows.Forms.LinkLabel();
      this.identity = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // header
      // 
      this.header.AutoSize = true;
      this.header.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.header.Location = new System.Drawing.Point(133, 0);
      this.header.Name = "header";
      this.header.Size = new System.Drawing.Size(329, 86);
      this.header.TabIndex = 0;
      this.header.Text = "CurveLock";
      // 
      // encryptText
      // 
      this.encryptText.AutoSize = true;
      this.encryptText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.encryptText.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.encryptText.Location = new System.Drawing.Point(217, 144);
      this.encryptText.Name = "encryptText";
      this.encryptText.Size = new System.Drawing.Size(161, 37);
      this.encryptText.TabIndex = 2;
      this.encryptText.TabStop = true;
      this.encryptText.Text = "Encrypt Text";
      this.encryptText.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.encryptText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EncryptTextLinkClicked);
      // 
      // encryptFile
      // 
      this.encryptFile.AutoSize = true;
      this.encryptFile.Enabled = false;
      this.encryptFile.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.encryptFile.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.encryptFile.Location = new System.Drawing.Point(221, 181);
      this.encryptFile.Name = "encryptFile";
      this.encryptFile.Size = new System.Drawing.Size(153, 37);
      this.encryptFile.TabIndex = 3;
      this.encryptFile.TabStop = true;
      this.encryptFile.Text = "Encrypt File";
      this.encryptFile.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      // 
      // decryptText
      // 
      this.decryptText.AutoSize = true;
      this.decryptText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.decryptText.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.decryptText.Location = new System.Drawing.Point(215, 218);
      this.decryptText.Name = "decryptText";
      this.decryptText.Size = new System.Drawing.Size(165, 37);
      this.decryptText.TabIndex = 4;
      this.decryptText.TabStop = true;
      this.decryptText.Text = "Decrypt Text";
      this.decryptText.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.decryptText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DecryptTextLinkClicked);
      // 
      // decryptFile
      // 
      this.decryptFile.AutoSize = true;
      this.decryptFile.Enabled = false;
      this.decryptFile.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.decryptFile.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.decryptFile.Location = new System.Drawing.Point(219, 255);
      this.decryptFile.Name = "decryptFile";
      this.decryptFile.Size = new System.Drawing.Size(157, 37);
      this.decryptFile.TabIndex = 5;
      this.decryptFile.TabStop = true;
      this.decryptFile.Text = "Decrypt File";
      this.decryptFile.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      // 
      // about
      // 
      this.about.AutoSize = true;
      this.about.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.about.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.about.Location = new System.Drawing.Point(252, 292);
      this.about.Name = "about";
      this.about.Size = new System.Drawing.Size(90, 37);
      this.about.TabIndex = 6;
      this.about.TabStop = true;
      this.about.Text = "About";
      this.about.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.about.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLinkClicked);
      // 
      // identity
      // 
      this.identity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(58)))));
      this.identity.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.identity.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.identity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
      this.identity.Location = new System.Drawing.Point(3, 445);
      this.identity.Name = "identity";
      this.identity.ReadOnly = true;
      this.identity.Size = new System.Drawing.Size(588, 24);
      this.identity.TabIndex = 7;
      this.identity.Text = "6To5kxAzdEvDRK1ckxAEH1XFJkzrTshKWyVxRLjmkcBq5";
      this.identity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 417);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(171, 25);
      this.label1.TabIndex = 8;
      this.label1.Text = "Your CurveLock ID:";
      // 
      // Menu
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(58)))));
      this.Controls.Add(this.label1);
      this.Controls.Add(this.identity);
      this.Controls.Add(this.about);
      this.Controls.Add(this.decryptFile);
      this.Controls.Add(this.decryptText);
      this.Controls.Add(this.encryptFile);
      this.Controls.Add(this.encryptText);
      this.Controls.Add(this.header);
      this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
      this.Name = "Menu";
      this.Size = new System.Drawing.Size(594, 472);
      this.Load += new System.EventHandler(this.MenuLoad);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label header;
    private System.Windows.Forms.LinkLabel encryptText;
    private System.Windows.Forms.LinkLabel encryptFile;
    private System.Windows.Forms.LinkLabel decryptText;
    private System.Windows.Forms.LinkLabel decryptFile;
    private System.Windows.Forms.LinkLabel about;
    private System.Windows.Forms.TextBox identity;
    private System.Windows.Forms.Label label1;
  }
}
