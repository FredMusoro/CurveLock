using System;
using System.Reflection;
using System.Windows.Forms;

namespace CurveLock.Panels
{
  public partial class About : UserControl, ICompletePanel
  {
    public event EventHandler<EventArgs> Complete;

    public About()
    {
      InitializeComponent();
    }

    private void AboutLoad(object sender, EventArgs e)
    {
      copyright.Text = AssemblyCopyright;
      version.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version;
    }

    public string AssemblyCopyright
    {
      get
      {
        var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);

        if (attributes.Length == 0)
        {
          return string.Empty;
        }

        return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
      }
    }

    private void BackLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Complete.Invoke(this, EventArgs.Empty);
    }
  }
}
