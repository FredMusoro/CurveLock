using System;
using System.Windows.Forms;

namespace CurveLock.Panels
{
  public partial class Welcome : UserControl, ICompletePanel
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
