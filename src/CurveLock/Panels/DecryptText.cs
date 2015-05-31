using CurveLock.Core;
using System;
using System.Text;
using System.Windows.Forms;

namespace CurveLock.Panels
{
  public partial class DecryptText : UserControl, ICompletePanel
  {
    public event EventHandler<EventArgs> Complete;

    public DecryptText()
    {
      InitializeComponent();
    }

    private void DecryptLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (message.Text.Length > 0)
      {
        byte[] decoded;
        decrypt.Enabled = false;

        try
        {
          Enabled = false;

          decoded = Base58Check.Base58CheckEncoding.Decode(message.Text);
        }
        catch (Exception)
        {
          MessageBox.Show("Unable to decode message. Please verify that it is correct.",
            "CurveLock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

          //bail out, nothing we can do here
          return;
        }
        finally
        {
          Enabled = true;
        }

        try
        {
          Enabled = false;

          message.Text = Encoding.UTF8.GetString(MessageCrypto.DecryptMessage(decoded, Common.KeyPair));
        }
        catch (Exception ex)
        {
          MessageBox.Show(
            string.Format("Unable to decrypt message. Please verify that it is correct.\r\nError: '{0}'", ex.Message),
            "CurveLock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
          Enabled = true;
        }
      }
    }

    private void CancelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Complete.Invoke(this, EventArgs.Empty);
    }
  }
}
