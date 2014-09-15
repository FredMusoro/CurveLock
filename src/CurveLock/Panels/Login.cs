using CurveLock.Core;
using Sodium;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

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
      Enabled = false;

      //get key seed, then continue once complete - takes 10+ seconds
      var task = Task<KeyPair>.Factory.StartNew(() => KeyGeneration.ScryptGenerateKey(email.Text, password.Text));
      task.ContinueWith(key => _CompleteProcessing(key.Result));
    }

    private void _CompleteProcessing(KeyPair key)
    {
      Common.PrivateKey = key.PrivateKey;
      Common.PublicKey = key.PublicKey;
      Common.Id = KeyGeneration.EncodePublicKey(key.PublicKey);

      Invoke(Complete, this, EventArgs.Empty);
    }
  }
}
