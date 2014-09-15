namespace CurveLock.Panels
{
  partial class DecryptFile
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
      this.decrypt = new System.Windows.Forms.LinkLabel();
      this.label2 = new System.Windows.Forms.Label();
      this.cancel = new System.Windows.Forms.LinkLabel();
      this.data = new System.Windows.Forms.Panel();
      this.filesAdded = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.data.SuspendLayout();
      this.SuspendLayout();
      // 
      // header
      // 
      this.header.AutoSize = true;
      this.header.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.header.Location = new System.Drawing.Point(105, 0);
      this.header.Name = "header";
      this.header.Size = new System.Drawing.Size(372, 86);
      this.header.TabIndex = 0;
      this.header.Text = "Decrypt File";
      // 
      // decrypt
      // 
      this.decrypt.AutoSize = true;
      this.decrypt.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.decrypt.Location = new System.Drawing.Point(504, 435);
      this.decrypt.Name = "decrypt";
      this.decrypt.Size = new System.Drawing.Size(77, 25);
      this.decrypt.TabIndex = 2;
      this.decrypt.TabStop = true;
      this.decrypt.Text = "Decrypt";
      this.decrypt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.decrypt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DecryptLinkClicked);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 84);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(90, 25);
      this.label2.TabIndex = 5;
      this.label2.Text = "Message:";
      // 
      // cancel
      // 
      this.cancel.AutoSize = true;
      this.cancel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.cancel.Location = new System.Drawing.Point(429, 435);
      this.cancel.Name = "cancel";
      this.cancel.Size = new System.Drawing.Size(57, 25);
      this.cancel.TabIndex = 7;
      this.cancel.TabStop = true;
      this.cancel.Text = "Done";
      this.cancel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.cancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CancelLinkClicked);
      // 
      // data
      // 
      this.data.AllowDrop = true;
      this.data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
      this.data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.data.Controls.Add(this.filesAdded);
      this.data.Controls.Add(this.label3);
      this.data.Location = new System.Drawing.Point(17, 112);
      this.data.Name = "data";
      this.data.Size = new System.Drawing.Size(562, 320);
      this.data.TabIndex = 8;
      this.data.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataDragDrop);
      this.data.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataDragEnter);
      // 
      // filesAdded
      // 
      this.filesAdded.AutoSize = true;
      this.filesAdded.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic);
      this.filesAdded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(58)))));
      this.filesAdded.Location = new System.Drawing.Point(221, 206);
      this.filesAdded.Name = "filesAdded";
      this.filesAdded.Size = new System.Drawing.Size(119, 25);
      this.filesAdded.TabIndex = 10;
      this.filesAdded.Text = "0 Files Added";
      this.filesAdded.UseMnemonic = false;
      this.filesAdded.Visible = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 20F);
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(58)))));
      this.label3.Location = new System.Drawing.Point(139, 104);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(282, 37);
      this.label3.TabIndex = 9;
      this.label3.Text = "Drag & Drop File Here";
      this.label3.UseMnemonic = false;
      // 
      // DecryptFile
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(58)))));
      this.Controls.Add(this.data);
      this.Controls.Add(this.cancel);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.decrypt);
      this.Controls.Add(this.header);
      this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
      this.Name = "DecryptFile";
      this.Size = new System.Drawing.Size(594, 472);
      this.data.ResumeLayout(false);
      this.data.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label header;
    private System.Windows.Forms.LinkLabel decrypt;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.LinkLabel cancel;
    private System.Windows.Forms.Panel data;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label filesAdded;
  }
}
