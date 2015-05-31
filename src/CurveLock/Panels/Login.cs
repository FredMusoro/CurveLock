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
      if (!string.IsNullOrWhiteSpace(email.Text) && !string.IsNullOrWhiteSpace(password.Text))
      {
        Enabled = false;

        //get key seed, then continue once complete - takes 10+ seconds
        var task = Task<KeyPair>.Factory.StartNew(_GenerateKeyPair);
        task.ContinueWith(key => _CompleteProcessing(key.Result));
      }
      else
      {
        MessageBox.Show("Email Address and Password are required to continue.",
          "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
      }
    }

    private void PasswordTextChanged(object sender, EventArgs e)
    {
      var entropy = Zxcvbn.Zxcvbn.MatchPassword(password.Text).Entropy;
      var score = Core.Utilities.Clamp(Convert.ToInt32((entropy / 128) * 10), 0, 10);

      labelPasswordStrength.Text = string.Format("Score: {0}/10", score);
      toolTip.SetToolTip(labelPasswordStrength, String.Format("Entropy: {0}", entropy));
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
