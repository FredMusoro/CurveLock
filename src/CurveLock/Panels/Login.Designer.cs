namespace CurveLock.Panels
{
  partial class Login
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
      this.header = new System.Windows.Forms.Label();
      this.linkLogin = new System.Windows.Forms.LinkLabel();
      this.intro = new System.Windows.Forms.Label();
      this.password = new System.Windows.Forms.TextBox();
      this.labelPassword1 = new System.Windows.Forms.Label();
      this.email = new System.Windows.Forms.TextBox();
      this.labelEmail = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // header
      // 
      this.header.AutoSize = true;
      this.header.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.header.Location = new System.Drawing.Point(200, 0);
      this.header.Name = "header";
      this.header.Size = new System.Drawing.Size(195, 86);
      this.header.TabIndex = 0;
      this.header.Text = "Login";
      // 
      // linkLogin
      // 
      this.linkLogin.AutoSize = true;
      this.linkLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.linkLogin.Location = new System.Drawing.Point(474, 436);
      this.linkLogin.Name = "linkLogin";
      this.linkLogin.Size = new System.Drawing.Size(103, 25);
      this.linkLogin.TabIndex = 2;
      this.linkLogin.TabStop = true;
      this.linkLogin.Text = "Login Now";
      this.linkLogin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLoginLinkClicked);
      // 
      // intro
      // 
      this.intro.Location = new System.Drawing.Point(11, 86);
      this.intro.Name = "intro";
      this.intro.Size = new System.Drawing.Size(569, 111);
      this.intro.TabIndex = 3;
      this.intro.Text = resources.GetString("intro.Text");
      // 
      // password
      // 
      this.password.Location = new System.Drawing.Point(82, 349);
      this.password.Name = "password";
      this.password.Size = new System.Drawing.Size(435, 33);
      this.password.TabIndex = 1;
      this.password.UseSystemPasswordChar = true;
      // 
      // labelPassword1
      // 
      this.labelPassword1.AutoSize = true;
      this.labelPassword1.Location = new System.Drawing.Point(77, 311);
      this.labelPassword1.Name = "labelPassword1";
      this.labelPassword1.Size = new System.Drawing.Size(96, 25);
      this.labelPassword1.TabIndex = 11;
      this.labelPassword1.Text = "Password:";
      // 
      // email
      // 
      this.email.Location = new System.Drawing.Point(82, 253);
      this.email.Name = "email";
      this.email.Size = new System.Drawing.Size(435, 33);
      this.email.TabIndex = 0;
      // 
      // labelEmail
      // 
      this.labelEmail.AutoSize = true;
      this.labelEmail.Location = new System.Drawing.Point(77, 213);
      this.labelEmail.Name = "labelEmail";
      this.labelEmail.Size = new System.Drawing.Size(134, 25);
      this.labelEmail.TabIndex = 9;
      this.labelEmail.Text = "Email Address:";
      // 
      // Login
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(58)))));
      this.Controls.Add(this.password);
      this.Controls.Add(this.labelPassword1);
      this.Controls.Add(this.email);
      this.Controls.Add(this.labelEmail);
      this.Controls.Add(this.intro);
      this.Controls.Add(this.linkLogin);
      this.Controls.Add(this.header);
      this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
      this.Name = "Login";
      this.Size = new System.Drawing.Size(594, 472);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label header;
    private System.Windows.Forms.LinkLabel linkLogin;
    private System.Windows.Forms.Label intro;
    private System.Windows.Forms.TextBox password;
    private System.Windows.Forms.Label labelPassword1;
    private System.Windows.Forms.TextBox email;
    private System.Windows.Forms.Label labelEmail;
  }
}
