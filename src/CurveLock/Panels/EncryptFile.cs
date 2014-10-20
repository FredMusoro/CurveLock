using System.Threading.Tasks;
using CurveLock.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StreamCryptor.Model;

namespace CurveLock.Panels
{
  public partial class EncryptFile : UserControl, ICompletePanel
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

    private async void EncryptLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (_files.Count > 0)
      {
        encrypt.Enabled = false;

        await ProcessFiles();

        status.Text = "Complete!";
        Enabled = true;
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

          status.Visible = true;
          status.Text = string.Format("{0} File(s) Added", _files.Count);
        }
      }
    }

    private async Task ProcessFiles()
    {
      foreach (var file in _files)
      {
        await ProcessFile(file);
      }
    }

    private async Task ProcessFile(string file)
    {
      var shortFile = System.IO.Path.GetFileName(file);

      if (!string.IsNullOrEmpty(shortFile) && shortFile.Length > 35)
        shortFile = shortFile.Substring(0, 32) + "...";

      var prg = new Progress<StreamCryptorTaskAsyncProgress>();
      prg.ProgressChanged += (s, e) =>
      {
        status.Text = string.Format("{0}: {1}%", shortFile, e.ProgressPercentage);
      };

      try
      {
        Enabled = false;

        await MessageCrypto.EncryptFile(file, toId.Text, prg);
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("Unable to encrypt message.\r\nError: '{0}'", ex.Message),
          "CurveLock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
