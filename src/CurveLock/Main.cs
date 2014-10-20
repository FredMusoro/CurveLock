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
    private Menu _menu;

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
      _menu = new Menu();
      content.Controls.Add(_menu);
      _menu.AboutClicked += MenuAboutClicked;
      _menu.EncryptTextClicked += MenuEncryptTextClicked;
      _menu.DecryptTextClicked += MenuDecryptTextClicked;
      _menu.EncryptFileClicked += MenuEncryptFileClicked;
      _menu.DecryptFileClicked += MenuDecryptFileClicked;
    }

    private void WelcomeComplete(object sender, EventArgs e)
    {
      content.Controls.Remove((Control)sender);
    }

    private void MenuAboutClicked(object sender, EventArgs e)
    {
      var about = new About();
      AddPanel(about);
    }

    private void MenuEncryptTextClicked(object sender, EventArgs e)
    {
      var encryptText = new EncryptText();
      AddPanel(encryptText);
    }

    private void MenuDecryptTextClicked(object sender, EventArgs e)
    {
      var decryptText = new DecryptText();
      AddPanel(decryptText);
    }

    private void MenuEncryptFileClicked(object sender, EventArgs e)
    {
      var encryptFile = new EncryptFile();
      AddPanel(encryptFile);
    }

    private void MenuDecryptFileClicked(object sender, EventArgs e)
    {
      var decryptFile = new DecryptFile();
      AddPanel(decryptFile);
    }

    private void AddPanel(UserControl pnl)
    {
      content.Controls.Add(pnl);
      ((ICompletePanel)pnl).Complete += PanelComplete;
      pnl.BringToFront();
      _menu.Enabled = false;
    }

    private void PanelComplete(object sender, EventArgs e)
    {
      content.Controls.Remove((Control)sender);
      _menu.Enabled = true;
    }
  }
}
