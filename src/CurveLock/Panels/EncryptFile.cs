using System.Collections.Generic;
using CurveLock.Core;
using System;
using System.Text;
using System.Windows.Forms;

namespace CurveLock.Panels
{
  public partial class EncryptFile : UserControl
  {
    private List<string> _files = new List<string>();
 
    public event EventHandler<EventArgs> Complete;

    public EncryptFile()
    {
      InitializeComponent();
    }

    private void CancelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Complete.Invoke(this, EventArgs.Empty);
    }

    private void EncryptLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (_files.Count > 0)
      {
        encrypt.Enabled = false;

        foreach (var file in _files)
        {
          try
          {
            Enabled = false;

            //todo: thread this off
            MessageCrypto.EncryptFile(file, toId.Text);
          }
          catch (Exception ex)
          {
            MessageBox.Show(string.Format("Unable to encrypt message.\r\nError: '{0}'", ex.Message),
              "CurveLock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          finally
          {
            Enabled = true;
          }
        }
      }
    }

    private void DataDragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
      {
        e.Effect = DragDropEffects.Copy;
      }
    }

    private void DataDragDrop(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
      {
        var files = (string[])(e.Data.GetData(DataFormats.FileDrop));
        foreach (var file in files)
        {
          _files.Add(file);

          filesAdded.Visible = true;
          filesAdded.Text = string.Format("{0} File(s) Added", _files.Count);
        }
      }
    }
  }
}
