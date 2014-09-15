using CurveLock.Panels;
using CurveLock.Properties;
using System;
using System.Reflection;
using System.Windows.Forms;
using Menu = CurveLock.Panels.Menu;

namespace CurveLock
{
  public partial class Main : Form
  {
    public Main()
    {
      InitializeComponent();
    }

    private void MainLoad(object sender, EventArgs e)
    {
      Text += " v" + Assembly.GetExecutingAssembly().GetName().Version;

      //display the login panel
      var login = new Login();
      login.Complete += LoginComplete;
      content.Controls.Add(login);

      //if this is the first time we've run the app, show the intro
      // and walk the user through creating an identity););
      if (Settings.Default.IsFirstRun)
      {
        var wlcm = new Welcome();
        wlcm.Complete += WelcomeComplete;
        content.Controls.Add(wlcm);
        wlcm.BringToFront();

        //update the setting so we don't show this next time.
        Settings.Default.IsFirstRun = false;
      }
    }

    private void MainFormClosing(object sender, FormClosingEventArgs e)
    {
      //save the application settings
      //Settings.Default.Save();
    }

    private void LoginComplete(object sender, EventArgs e)
    {
      //remove the login panel
      content.Controls.Remove((Control)sender);

      //add the menu control
      var menu = new Menu();
      content.Controls.Add(menu);
      menu.AboutClicked += MenuAboutClicked;
      menu.EncryptTextClicked += MenuEncryptTextClicked;
      menu.DecryptTextClicked += MenuDecryptTextClicked;
    }

    private void WelcomeComplete(object sender, EventArgs e)
    {
      content.Controls.Remove((Control)sender);
    }

    private void AboutComplete(object sender, EventArgs e)
    {
      content.Controls.Remove((Control)sender);
    }

    private void EncryptTextComplete(object sender, EventArgs e)
    {
      content.Controls.Remove((Control)sender);
    }

    private void DecryptTextComplete(object sender, EventArgs e)
    {
      content.Controls.Remove((Control)sender);
    }

    private void MenuAboutClicked(object sender, EventArgs e)
    {
      var about = new About();
      content.Controls.Add(about);
      about.Complete += AboutComplete;
      about.BringToFront();
    }

    private void MenuEncryptTextClicked(object sender, EventArgs e)
    {
      var encryptText = new EncryptText();
      content.Controls.Add(encryptText);
      encryptText.Complete += EncryptTextComplete;
      encryptText.BringToFront();
    }

    private void MenuDecryptTextClicked(object sender, EventArgs e)
    {
      var decryptText = new DecryptText();
      content.Controls.Add(decryptText);
      decryptText.Complete += DecryptTextComplete;
      decryptText.BringToFront();
    }
  }
}
