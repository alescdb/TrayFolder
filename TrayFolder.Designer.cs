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
namespace TrayFolder
{
    partial class TrayFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.FolderMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.IconName = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.TextPath = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.OpenFolders = new System.Windows.Forms.CheckBox();
      this.HideExtensions = new System.Windows.Forms.CheckBox();
      this.LaunchStartup = new System.Windows.Forms.CheckBox();
      this.panel4 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.ButtonQuit = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel5 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.NumericDepth = new System.Windows.Forms.NumericUpDown();
      this.panel6 = new System.Windows.Forms.Panel();
      this.NumericFailSafe = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.panel2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.panel3.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NumericDepth)).BeginInit();
      this.panel6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NumericFailSafe)).BeginInit();
      this.SuspendLayout();
      // 
      // TrayIcon
      // 
      this.TrayIcon.Text = "Folders";
      this.TrayIcon.Visible = true;
      // 
      // FolderMenu
      // 
      this.FolderMenu.Name = "FolderMenu";
      this.FolderMenu.Size = new System.Drawing.Size(61, 4);
      // 
      // groupBox1
      // 
      this.groupBox1.AutoSize = true;
      this.groupBox1.Controls.Add(this.IconName);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(15, 15);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
      this.groupBox1.Size = new System.Drawing.Size(308, 63);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Tray Icon Name";
      // 
      // IconName
      // 
      this.IconName.Dock = System.Windows.Forms.DockStyle.Top;
      this.IconName.Location = new System.Drawing.Point(15, 28);
      this.IconName.Name = "IconName";
      this.IconName.Size = new System.Drawing.Size(278, 20);
      this.IconName.TabIndex = 0;
      this.IconName.Text = "Folder";
      // 
      // groupBox2
      // 
      this.groupBox2.AutoSize = true;
      this.groupBox2.Controls.Add(this.panel2);
      this.groupBox2.Controls.Add(this.TextPath);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox2.Location = new System.Drawing.Point(15, 88);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(15);
      this.groupBox2.Size = new System.Drawing.Size(308, 89);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Path";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.button1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(15, 48);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(278, 26);
      this.panel2.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Right;
      this.button1.Location = new System.Drawing.Point(203, 0);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 26);
      this.button1.TabIndex = 0;
      this.button1.Text = "Select...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.OnSelectFolder);
      // 
      // TextPath
      // 
      this.TextPath.Dock = System.Windows.Forms.DockStyle.Top;
      this.TextPath.Location = new System.Drawing.Point(15, 28);
      this.TextPath.Name = "TextPath";
      this.TextPath.Size = new System.Drawing.Size(278, 20);
      this.TextPath.TabIndex = 0;
      this.TextPath.Text = "C:\\Users\\adb\\Documents\\Menus";
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(15, 78);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(308, 10);
      this.panel1.TabIndex = 3;
      // 
      // groupBox3
      // 
      this.groupBox3.AutoSize = true;
      this.groupBox3.Controls.Add(this.tableLayoutPanel1);
      this.groupBox3.Controls.Add(this.OpenFolders);
      this.groupBox3.Controls.Add(this.HideExtensions);
      this.groupBox3.Controls.Add(this.LaunchStartup);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox3.Location = new System.Drawing.Point(15, 187);
      this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Padding = new System.Windows.Forms.Padding(15);
      this.groupBox3.Size = new System.Drawing.Size(308, 156);
      this.groupBox3.TabIndex = 5;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Options";
      // 
      // OpenFolders
      // 
      this.OpenFolders.AutoSize = true;
      this.OpenFolders.Dock = System.Windows.Forms.DockStyle.Top;
      this.OpenFolders.Location = new System.Drawing.Point(15, 71);
      this.OpenFolders.Name = "OpenFolders";
      this.OpenFolders.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
      this.OpenFolders.Size = new System.Drawing.Size(278, 23);
      this.OpenFolders.TabIndex = 1;
      this.OpenFolders.Text = "Open folder on click";
      this.OpenFolders.UseVisualStyleBackColor = true;
      // 
      // HideExtensions
      // 
      this.HideExtensions.AutoSize = true;
      this.HideExtensions.Dock = System.Windows.Forms.DockStyle.Top;
      this.HideExtensions.Location = new System.Drawing.Point(15, 48);
      this.HideExtensions.Name = "HideExtensions";
      this.HideExtensions.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
      this.HideExtensions.Size = new System.Drawing.Size(278, 23);
      this.HideExtensions.TabIndex = 0;
      this.HideExtensions.Text = "Hide Extensions";
      this.HideExtensions.UseVisualStyleBackColor = true;
      // 
      // LaunchStartup
      // 
      this.LaunchStartup.AutoSize = true;
      this.LaunchStartup.Dock = System.Windows.Forms.DockStyle.Top;
      this.LaunchStartup.Location = new System.Drawing.Point(15, 28);
      this.LaunchStartup.Name = "LaunchStartup";
      this.LaunchStartup.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.LaunchStartup.Size = new System.Drawing.Size(278, 20);
      this.LaunchStartup.TabIndex = 4;
      this.LaunchStartup.Text = "Launch at startup";
      this.LaunchStartup.UseVisualStyleBackColor = true;
      this.LaunchStartup.CheckedChanged += new System.EventHandler(this.OnLaunchOnStartup);
      // 
      // panel4
      // 
      this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel4.Location = new System.Drawing.Point(15, 177);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(308, 10);
      this.panel4.TabIndex = 6;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.ButtonQuit);
      this.panel3.Controls.Add(this.button2);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(15, 343);
      this.panel3.Name = "panel3";
      this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
      this.panel3.Size = new System.Drawing.Size(308, 31);
      this.panel3.TabIndex = 7;
      // 
      // ButtonQuit
      // 
      this.ButtonQuit.Dock = System.Windows.Forms.DockStyle.Left;
      this.ButtonQuit.Location = new System.Drawing.Point(0, 5);
      this.ButtonQuit.Name = "ButtonQuit";
      this.ButtonQuit.Size = new System.Drawing.Size(75, 26);
      this.ButtonQuit.TabIndex = 1;
      this.ButtonQuit.Text = "Quit";
      this.ButtonQuit.UseVisualStyleBackColor = true;
      this.ButtonQuit.Click += new System.EventHandler(this.OnQuit);
      // 
      // button2
      // 
      this.button2.Dock = System.Windows.Forms.DockStyle.Right;
      this.button2.Location = new System.Drawing.Point(233, 5);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 26);
      this.button2.TabIndex = 0;
      this.button2.Text = "Save";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.OnSave);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.AutoSize = true;
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 94);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 47);
      this.tableLayoutPanel1.TabIndex = 5;
      // 
      // panel5
      // 
      this.panel5.AutoSize = true;
      this.panel5.Controls.Add(this.NumericDepth);
      this.panel5.Controls.Add(this.label1);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel5.Location = new System.Drawing.Point(3, 3);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(133, 41);
      this.panel5.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
      this.label1.Size = new System.Drawing.Size(57, 21);
      this.label1.TabIndex = 4;
      this.label1.Text = "Max depth";
      // 
      // NumericDepth
      // 
      this.NumericDepth.Dock = System.Windows.Forms.DockStyle.Top;
      this.NumericDepth.Location = new System.Drawing.Point(0, 21);
      this.NumericDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.NumericDepth.Name = "NumericDepth";
      this.NumericDepth.Size = new System.Drawing.Size(133, 20);
      this.NumericDepth.TabIndex = 5;
      this.NumericDepth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
      // 
      // panel6
      // 
      this.panel6.AutoSize = true;
      this.panel6.Controls.Add(this.NumericFailSafe);
      this.panel6.Controls.Add(this.label2);
      this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel6.Location = new System.Drawing.Point(142, 3);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(133, 41);
      this.panel6.TabIndex = 1;
      // 
      // NumericFailSafe
      // 
      this.NumericFailSafe.Dock = System.Windows.Forms.DockStyle.Top;
      this.NumericFailSafe.Location = new System.Drawing.Point(0, 21);
      this.NumericFailSafe.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.NumericFailSafe.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.NumericFailSafe.Name = "NumericFailSafe";
      this.NumericFailSafe.Size = new System.Drawing.Size(133, 20);
      this.NumericFailSafe.TabIndex = 5;
      this.NumericFailSafe.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
      this.label2.Size = new System.Drawing.Size(46, 21);
      this.label2.TabIndex = 4;
      this.label2.Text = "Fail safe";
      // 
      // TrayFolder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(338, 400);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(350, 39);
      this.Name = "TrayFolder";
      this.Padding = new System.Windows.Forms.Padding(15);
      this.Text = "Tray Folder v0.1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NumericDepth)).EndInit();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NumericFailSafe)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IconName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip FolderMenu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox HideExtensions;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox OpenFolders;
        private System.Windows.Forms.CheckBox LaunchStartup;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown NumericFailSafe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown NumericDepth;
        private System.Windows.Forms.Label label1;
    }
}

