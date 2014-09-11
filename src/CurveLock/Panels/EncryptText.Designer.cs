namespace CurveLock.Panels
{
  partial class EncryptText
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
      this.encrypt = new System.Windows.Forms.LinkLabel();
      this.label1 = new System.Windows.Forms.Label();
      this.toId = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.message = new System.Windows.Forms.TextBox();
      this.cancel = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // header
      // 
      this.header.AutoSize = true;
      this.header.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.header.Location = new System.Drawing.Point(105, 0);
      this.header.Name = "header";
      this.header.Size = new System.Drawing.Size(384, 86);
      this.header.TabIndex = 0;
      this.header.Text = "Encrypt Text";
      // 
      // encrypt
      // 
      this.encrypt.AutoSize = true;
      this.encrypt.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.encrypt.Location = new System.Drawing.Point(504, 435);
      this.encrypt.Name = "encrypt";
      this.encrypt.Size = new System.Drawing.Size(75, 25);
      this.encrypt.TabIndex = 2;
      this.encrypt.TabStop = true;
      this.encrypt.Text = "Encrypt";
      this.encrypt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.encrypt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EncryptLinkClicked);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 95);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(114, 25);
      this.label1.TabIndex = 3;
      this.label1.Text = "To Curve ID:";
      // 
      // toId
      // 
      this.toId.Location = new System.Drawing.Point(17, 123);
      this.toId.Name = "toId";
      this.toId.Size = new System.Drawing.Size(562, 33);
      this.toId.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 159);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(90, 25);
      this.label2.TabIndex = 5;
      this.label2.Text = "Message:";
      // 
      // message
      // 
      this.message.Location = new System.Drawing.Point(17, 187);
      this.message.Multiline = true;
      this.message.Name = "message";
      this.message.Size = new System.Drawing.Size(562, 245);
      this.message.TabIndex = 6;
      // 
      // cancel
      // 
      this.cancel.AutoSize = true;
      this.cancel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.cancel.Location = new System.Drawing.Point(429, 435);
      this.cancel.Name = "cancel";
      this.cancel.Size = new System.Drawing.Size(69, 25);
      this.cancel.TabIndex = 7;
      this.cancel.TabStop = true;
      this.cancel.Text = "Cancel";
      this.cancel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.cancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CancelLinkClicked);
      // 
      // EncryptText
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(58)))));
      this.Controls.Add(this.cancel);
      this.Controls.Add(this.message);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.toId);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.encrypt);
      this.Controls.Add(this.header);
      this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
      this.Name = "EncryptText";
      this.Size = new System.Drawing.Size(594, 472);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label header;
    private System.Windows.Forms.LinkLabel encrypt;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox toId;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox message;
    private System.Windows.Forms.LinkLabel cancel;
  }
}
