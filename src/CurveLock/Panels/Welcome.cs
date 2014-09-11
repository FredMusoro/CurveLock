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
  public partial class Welcome : UserControl
  {
    public event EventHandler<EventArgs> Complete;

    public Welcome()
    {
      InitializeComponent();
    }

    private void GetStartedLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Complete.Invoke(this, EventArgs.Empty);
    }
  }
}
