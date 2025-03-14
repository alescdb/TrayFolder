/*
Licensed to the Apache Software Foundation (ASF) under one
or more contributor license agreements.  See the NOTICE file
distributed with this work for additional information
regarding copyright ownership.  The ASF licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License.  You may obtain a copy of the License at

  http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied.  See the License for the
specific language governing permissions and limitations
under the License.    
*/
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TrayFolder
{
  public class MenuBuilder
  {
    private int ItemCount = 0;
    public bool HideExtensions { get; set; }
    public bool OpenFolders { get; set; }
    public int MaxDepth { get; set; }
    public int FailSafe { get; set; } = 1000;

    public SystemIconsImageList SystemIcons { get; }

    public MenuBuilder( SystemIconsImageList SystemIcons )
    {
      this.SystemIcons = SystemIcons;
    }



    public String GetFileName( String FilePath )
    {
      if(HideExtensions == false)
      {
        // Force hide '.lnk'
        var Ext = (Path.GetExtension(FilePath) ?? "").ToLower();
        if(String.Compare(Ext, ".lnk") != 0)
          return (Path.GetFileName(FilePath));
      }
      return Path.GetFileNameWithoutExtension(FilePath);
    }

    public ToolStripMenuItem CreateItem( String ItemPath )
    {
      // TODO/BUG : Image are set to Item.Image instead of using ImageIndex,
      // when using ImageIndex icons are not shown in sub menus

      ToolStripMenuItem Item = new ToolStripMenuItem();
      int ImageIndex = SystemIcons.GetIconIndex(ItemPath);
      Item.Image = SystemIcons.LargeIconsImageList.Images[ImageIndex];
      Item.Tag = ItemPath;

      return (Item);
    }

    public void UpdateMenu( String InitialPath, ContextMenuStrip Menu )
    {
      Menu.Items.Clear();
      Menu.ImageList = SystemIcons.LargeIconsImageList;
      ItemCount = 0;
      UpdateMenu(InitialPath, 0, Menu.Items);
    }

    private void UpdateMenu( String Folder, int SubFolders, ToolStripItemCollection Items )
    {
      Trace.WriteLine($"{Folder} => {SubFolders}/{MaxDepth} ({ItemCount})");
      foreach(string Dir in Directory.GetDirectories(Folder))
      {
        var Item = CreateItem(Dir);
        Item.Text = Path.GetFileName(Dir);
        Items.Add(Item);

        if(OpenFolders)
          Item.Click += OnStartItem;

        ItemCount++;
        if(ItemCount > FailSafe)
          return;

        if(SubFolders < MaxDepth)
        {
          try
          {
            UpdateMenu(Dir, SubFolders + 1, Item.DropDownItems);
          }
          catch
          {
            // Avoid permission denied exceptions
          }
        }
      }

      foreach(string File in Directory.GetFiles(Folder))
      {
        var Item = CreateItem(File);
        Item.Text = GetFileName(File);
        Item.Click += OnStartItem;
        Items.Add(Item);

        ItemCount++;
        if(ItemCount > FailSafe)
          return;
      }
    }

    private void OnStartItem( object sender, EventArgs e )
    {
      try
      {
        string path = ((ToolStripMenuItem)sender).Tag as String;
        if(IsLink(path))
        {
          ProcessStartInfo psi = new ProcessStartInfo
          {
            FileName = "explorer.exe",
            Arguments = "\"" + path + "\"",
            UseShellExecute = true
          };
          Process.Start(psi);
        }
        else
        {
          Process.Start(path);
        }
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private bool IsLink( string path )
    {
      return String.Compare((Path.GetExtension(path) ?? "").ToLower(), ".lnk") == 0;
    }
  }
}
