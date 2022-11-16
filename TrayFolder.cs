using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TrayFolder
{
  public partial class TrayFolder : Form
  {
    const string KEY_FOLDER = "Folder";
    const string APPNAME = "TrayFolder";

    private SystemIconsImageList SystemIcons = new SystemIconsImageList();
    private ToolStripMenuItem SettingMenu;

    public TrayFolder()
    {
      InitializeComponent();

      Icon = Win32.GetStockIcon(Win32.SHSIID_FOLDER, Win32.SHGSI_LARGEICON);
      DialogResult = DialogResult.OK;
      SettingMenu = CreateSettingMenu();

      TrayIcon.Icon = this.Icon;
      TrayIcon.Click += OnTrayIconClick;

      TextPath.Text = Properties.Settings.Default.FolderPath;
      HideExtensions.Checked = Properties.Settings.Default.HideExtensions;
      TrayIcon.Text = Properties.Settings.Default.FolderName;
      IconName.Text = Properties.Settings.Default.FolderName;
      NumericDepth.Value = Properties.Settings.Default.MaxDepth;
      OpenFolders.Checked = Properties.Settings.Default.OpenFolders;
      LaunchStartup.Checked = GetLaunchOnStartup();
      NumericFailSafe.Value = Properties.Settings.Default.FailSafe;

      Text = APPNAME + " v" + Application.ProductVersion;
    }

    protected override void OnLoad( EventArgs e )
    {
      if(IsValid())
      {
        HideMe();
        UpdateMenu();
      }

      base.OnLoad(e);
    }

    private bool IsValid()
    {
      if(Properties.Settings.Default.FirstRun)
        return (false);
      if(String.IsNullOrWhiteSpace(TextPath.Text))
        return (false);
      if(Directory.Exists(TextPath.Text) == false)
        return (false);
      return (true);
    }

    private void OnTrayIconClick( object sender, EventArgs e )
    {
      MouseEventArgs me = (MouseEventArgs)e;

      Win32.SetForegroundWindow(new HandleRef(FolderMenu, FolderMenu.Handle));
      SettingMenu.Visible = me.Button == MouseButtons.Right;

      FolderMenu.Show(Cursor.Position);
    }

    private void OnSelectFolder( object sender, EventArgs e )
    {
      FolderBrowserDialog fbd = new FolderBrowserDialog();

      fbd.SelectedPath = TextPath.Text;
      if(fbd.ShowDialog(this) == DialogResult.OK)
      {
        TextPath.Text = fbd.SelectedPath;
        UpdateMenu();
      }
    }


    public ToolStripMenuItem CreateSettingMenu()
    {
      ToolStripMenuItem Settings = new ToolStripMenuItem("Setup");
      // Settings.Image = DefaultIcons.Extract("shell32.dll", 21, false).ToBitmap();

      ToolStripMenuItem MenuSettings = new ToolStripMenuItem("Settings...");
      MenuSettings.Click += OnMenuSettings;
      Settings.DropDownItems.Add(MenuSettings);
      Settings.DropDownItems.Add(new ToolStripSeparator());

      ToolStripMenuItem MenuUpdate = new ToolStripMenuItem("Update Folders");
      MenuUpdate.Click += OnMenuUpdate;
      Settings.DropDownItems.Add(MenuUpdate);
      Settings.DropDownItems.Add(new ToolStripSeparator());

      ToolStripMenuItem MenuQuit = new ToolStripMenuItem("Quit");
      MenuQuit.Click += OnQuit;
      Settings.DropDownItems.Add(MenuQuit);

      return (Settings);
    }

    private void UpdateMenu()
    {
      MenuBuilder Builder = new MenuBuilder(SystemIcons)
      {
        HideExtensions = HideExtensions.Checked,
        MaxDepth = (int)NumericDepth.Value,
        OpenFolders = OpenFolders.Checked,
      };

      Builder.UpdateMenu(TextPath.Text, FolderMenu);
      FolderMenu.Items.Add(SettingMenu);
    }

    private void OnSave( object sender, EventArgs e )
    {
      Properties.Settings.Default.FirstRun = false;
      Properties.Settings.Default.FolderName = IconName.Text;
      Properties.Settings.Default.FolderPath = TextPath.Text;
      Properties.Settings.Default.HideExtensions = HideExtensions.Checked;
      Properties.Settings.Default.MaxDepth = (int)NumericDepth.Value;
      Properties.Settings.Default.FailSafe = (int)NumericFailSafe.Value;
      Properties.Settings.Default.OpenFolders = OpenFolders.Checked;
      Properties.Settings.Default.Save();
      TrayIcon.Text = IconName.Text;

      if(IsValid())
      {
        HideMe();
        UpdateMenu();
      }
    }

    protected override void OnClosing( CancelEventArgs e )
    {
      if(DialogResult == DialogResult.OK)
      {
        e.Cancel = true;
        HideMe();
      }
      base.OnClosing(e);
    }

    private void HideMe()
    {
      Visible = false;
      ShowInTaskbar = false;
    }

    private void OnMenuUpdate( object sender, EventArgs e )
    {
      UpdateMenu();
    }

    private void OnQuit( object sender, EventArgs e )
    {
      DialogResult = DialogResult.Cancel;
      Close();
    }

    private void OnMenuSettings( object sender, EventArgs e )
    {
      ShowInTaskbar = true;
      Visible = true;
    }

    private bool GetLaunchOnStartup()
    {
      try
      {
        RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        return (key.GetValue(APPNAME) as String == Application.ExecutablePath);
      }
      catch
      {
      }
      return (false);
    }

    private void OnLaunchOnStartup( object sender, EventArgs e )
    {
      try
      {
        RegistryKey regkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        if(LaunchStartup.Checked)
        {
          regkey.SetValue(APPNAME, Application.ExecutablePath, RegistryValueKind.String);
        }
        else
        {
          regkey.DeleteValue(APPNAME, false);
        }
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
