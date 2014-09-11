using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CurveLock.Core;

namespace CurveLock.Panels
{
  public partial class DecryptText : UserControl
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
        decrypt.Enabled = false;

        var decoded = Base58Check.Base58CheckEncoding.Decode(message.Text);
        message.Text = Encoding.UTF8.GetString(MessageCrypto.DecryptMessage(decoded, Common.PrivateKey));
      }
    }

    private void CancelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Complete.Invoke(this, EventArgs.Empty);
    }
  }
}
