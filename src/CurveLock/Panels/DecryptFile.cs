using System.Collections.Generic;
using CurveLock.Core;
using System;
using System.Text;
using System.Windows.Forms;

namespace CurveLock.Panels
{
  public partial class DecryptFile : UserControl
  {
    private List<string> _files = new List<string>();
 
    public event EventHandler<EventArgs> Complete;

    public DecryptFile()
    {
      InitializeComponent();
    }

    private void CancelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Complete.Invoke(this, EventArgs.Empty);
    }

    private void DecryptLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (_files.Count > 0)
      {
        decrypt.Enabled = false;

        foreach (var file in _files)
        {
          try
          {
            Enabled = false;

            //todo: thread this off
            MessageCrypto.DecryptFile(file, Common.KeyPair);
          }
          catch (Exception ex)
          {
            MessageBox.Show(
              string.Format("Unable to decrypt message. Please verify that it is correct. \r\nError: '{0}'", ex.Message),
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
