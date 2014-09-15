using System;
using System.Windows.Forms;

namespace CurveLock.Panels
{
  public partial class Menu : UserControl
  {
    public event EventHandler<EventArgs> AboutClicked;
    public event EventHandler<EventArgs> EncryptTextClicked;
    public event EventHandler<EventArgs> DecryptTextClicked;
    public event EventHandler<EventArgs> EncryptFileClicked;
    public event EventHandler<EventArgs> DecryptFileClicked;

    public Menu()
    {
      InitializeComponent();
    }

    private void MenuLoad(object sender, EventArgs e)
    {
      identity.Text = Common.Id;
    }

    private void AboutLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      AboutClicked.Invoke(this, EventArgs.Empty);
    }

    private void EncryptTextLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      EncryptTextClicked.Invoke(this, EventArgs.Empty);
    }

    private void DecryptTextLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DecryptTextClicked.Invoke(this, EventArgs.Empty);
    }

    private void EncryptFileLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      EncryptFileClicked.Invoke(this, EventArgs.Empty);
    }

    private void DecryptFileLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DecryptFileClicked.Invoke(this, EventArgs.Empty);
    }
  }
}
