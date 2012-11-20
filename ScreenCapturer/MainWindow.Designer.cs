﻿namespace ScreenCapturer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.notificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notificationContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notificationMenuToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.notificationMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationIcon
            // 
            this.notificationIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notificationIcon.BalloonTipTitle = "ScreenCapturer";
            this.notificationIcon.ContextMenuStrip = this.notificationContextMenu;
            this.notificationIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notificationIcon.Icon")));
            this.notificationIcon.Text = "ScreenCapturer is not taking screenshots.";
            this.notificationIcon.Visible = true;
            this.notificationIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotificationIconMouseClick);
            // 
            // notificationContextMenu
            // 
            this.notificationContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificationMenuToggle,
            this.notificationMenuSave,
            this.toolStripSeparator1,
            this.notificationMenuExit});
            this.notificationContextMenu.Name = "notificationContextMenu";
            this.notificationContextMenu.Size = new System.Drawing.Size(163, 76);
            // 
            // notificationMenuToggle
            // 
            this.notificationMenuToggle.Name = "notificationMenuToggle";
            this.notificationMenuToggle.Size = new System.Drawing.Size(162, 22);
            this.notificationMenuToggle.Text = "Toggle capture";
            this.notificationMenuToggle.Click += new System.EventHandler(this.NotificationMenuToggleClick);
            // 
            // notificationMenuSave
            // 
            this.notificationMenuSave.Name = "notificationMenuSave";
            this.notificationMenuSave.Size = new System.Drawing.Size(162, 22);
            this.notificationMenuSave.Text = "Save shots to file";
            this.notificationMenuSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notificationMenuSave.Click += new System.EventHandler(this.NotificationMenuSaveClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // notificationMenuExit
            // 
            this.notificationMenuExit.Name = "notificationMenuExit";
            this.notificationMenuExit.Size = new System.Drawing.Size(162, 22);
            this.notificationMenuExit.Text = "Exit";
            this.notificationMenuExit.Click += new System.EventHandler(this.NotificationMenuExitClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 162);
            this.ControlBox = false;
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindowFormClosing);
            this.Load += new System.EventHandler(this.MainWindowLoad);
            this.notificationContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.NotifyIcon notificationIcon;
        private System.Windows.Forms.ContextMenuStrip notificationContextMenu;
        private System.Windows.Forms.ToolStripMenuItem notificationMenuSave;
        private System.Windows.Forms.ToolStripMenuItem notificationMenuExit;
        private System.Windows.Forms.ToolStripMenuItem notificationMenuToggle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        #endregion
    }
}
