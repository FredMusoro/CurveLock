using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CurveLock.Core;
using Sodium;

namespace CurveLock.Panels
{
  public partial class Login : UserControl
  {
    public event EventHandler<EventArgs> Complete;

    public Login()
    {
      InitializeComponent();
    }

    private void LinkLoginLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.Enabled = false;

      //get key seed, then continue once complete - takes 10+ seconds
      var task = Task<KeyPair>.Factory.StartNew(() => KeyGeneration.ScryptGenerateKey(email.Text, password.Text));
      task.ContinueWith((key) => _CompleteProcessing(key.Result));
    }

    private void _CompleteProcessing(KeyPair key)
    {
      Common.PrivateKey = key.PrivateKey;
      Common.PublicKey = key.PublicKey;
      Common.Id = KeyGeneration.EncodePublicKey(key.PublicKey);

      this.Invoke(Complete, this, EventArgs.Empty);
    }
  }
}
