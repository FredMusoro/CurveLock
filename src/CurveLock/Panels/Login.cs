using CurveLock.Core;
using Sodium;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurveLock.Panels
{
  public partial class Login : UserControl, ICompletePanel
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
      var task = Task<KeyPair>.Factory.StartNew(_GenerateKeyPair);
      task.ContinueWith(key => _CompleteProcessing(key.Result));
    }

    private void _CompleteProcessing(KeyPair key)
    {
      if (key != null)
      {
        Common.KeyPair = key;
        Common.Id = KeyGeneration.EncodePublicKey(key.PublicKey);

        Invoke(Complete, this, EventArgs.Empty);
      }
    }

    private KeyPair _GenerateKeyPair()
    {
      KeyPair key = null;

      try
      {
        key = KeyGeneration.ScryptGenerateKey(email.Text, password.Text);
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("Unable to generate CurveLock Identity\r\nError: '{0}'", ex.Message), 
          "CurveLock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      return key;
    }
  }
}
