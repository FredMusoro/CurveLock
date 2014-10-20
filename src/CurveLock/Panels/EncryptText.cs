using CurveLock.Core;
using System;
using System.Text;
using System.Windows.Forms;

namespace CurveLock.Panels
{
  public partial class EncryptText : UserControl, ICompletePanel
  {
    public event EventHandler<EventArgs> Complete;

    public EncryptText()
    {
      InitializeComponent();
    }

    private void CancelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Complete.Invoke(this, EventArgs.Empty);
    }

    private void EncryptLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (message.Text.Length > 0)
      {
        encrypt.Enabled = false;

        try
        {
          Enabled = false;

          message.Text = Base58Check.Base58CheckEncoding.Encode(
            MessageCrypto.EncryptMessage(Encoding.UTF8.GetBytes(message.Text), toId.Text));
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
}
