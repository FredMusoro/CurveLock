using CurveLock.Core;
using System;
using System.Text;
using System.Windows.Forms;

namespace CurveLock.Panels
{
  public partial class EncryptText : UserControl
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
      encrypt.Enabled = false;

      message.Text = Base58Check.Base58CheckEncoding.Encode(
        MessageCrypto.EncryptMessage(Encoding.UTF8.GetBytes(message.Text), toId.Text));
    }
  }
}
