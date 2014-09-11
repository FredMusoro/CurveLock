using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CurveLock.Panels
{
  public partial class Menu : UserControl
  {
    public event EventHandler<EventArgs> AboutClicked;
    public event EventHandler<EventArgs> EncryptTextClicked;
    public event EventHandler<EventArgs> DecryptTextClicked;

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
  }
}
