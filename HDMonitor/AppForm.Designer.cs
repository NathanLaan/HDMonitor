namespace HDMonitor
{
    partial class AppForm
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
            this.hdNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuShowNotification = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuIconColor = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuIconColorBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuIconColorCyan = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuIconColorGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuIconColorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdNotifyIcon
            // 
            this.hdNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.hdNotifyIcon.BalloonTipText = "HD Monitor";
            this.hdNotifyIcon.Text = "HD Monitor";
            this.hdNotifyIcon.Visible = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuTitle,
            this.contextMenuSeparator,
            this.contextMenuShowNotification,
            this.contextMenuIconColor,
            this.toolStripSeparator1,
            this.contextMenuExit});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(193, 126);
            // 
            // contextMenuTitle
            // 
            this.contextMenuTitle.Enabled = false;
            this.contextMenuTitle.Name = "contextMenuTitle";
            this.contextMenuTitle.Size = new System.Drawing.Size(192, 22);
            this.contextMenuTitle.Text = "HD Monitor";
            // 
            // contextMenuSeparator
            // 
            this.contextMenuSeparator.Name = "contextMenuSeparator";
            this.contextMenuSeparator.Size = new System.Drawing.Size(189, 6);
            // 
            // contextMenuShowNotification
            // 
            this.contextMenuShowNotification.CheckOnClick = true;
            this.contextMenuShowNotification.Name = "contextMenuShowNotification";
            this.contextMenuShowNotification.Size = new System.Drawing.Size(192, 22);
            this.contextMenuShowNotification.Text = "Show HD Activity Rate";
            this.contextMenuShowNotification.Click += new System.EventHandler(this.contextMenuShowNotification_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // contextMenuExit
            // 
            this.contextMenuExit.Name = "contextMenuExit";
            this.contextMenuExit.Size = new System.Drawing.Size(192, 22);
            this.contextMenuExit.Text = "E&xit";
            this.contextMenuExit.Click += new System.EventHandler(this.contextMenuExit_Click);
            // 
            // contextMenuIconColor
            // 
            this.contextMenuIconColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuIconColorBlue,
            this.contextMenuIconColorCyan,
            this.contextMenuIconColorGreen,
            this.contextMenuIconColorRed});
            this.contextMenuIconColor.Name = "contextMenuIconColor";
            this.contextMenuIconColor.Size = new System.Drawing.Size(192, 22);
            this.contextMenuIconColor.Text = "Active Icon Color";
            // 
            // contextMenuIconColorBlue
            // 
            this.contextMenuIconColorBlue.ForeColor = System.Drawing.Color.Blue;
            this.contextMenuIconColorBlue.Name = "contextMenuIconColorBlue";
            this.contextMenuIconColorBlue.Size = new System.Drawing.Size(152, 22);
            this.contextMenuIconColorBlue.Text = "Blue";
            this.contextMenuIconColorBlue.Click += new System.EventHandler(this.contextMenuIconColorBlue_Click);
            // 
            // contextMenuIconColorCyan
            // 
            this.contextMenuIconColorCyan.ForeColor = System.Drawing.Color.Cyan;
            this.contextMenuIconColorCyan.Name = "contextMenuIconColorCyan";
            this.contextMenuIconColorCyan.Size = new System.Drawing.Size(152, 22);
            this.contextMenuIconColorCyan.Text = "Cyan";
            this.contextMenuIconColorCyan.Click += new System.EventHandler(this.contextMenuIconColorCyan_Click);
            // 
            // contextMenuIconColorGreen
            // 
            this.contextMenuIconColorGreen.ForeColor = System.Drawing.Color.Green;
            this.contextMenuIconColorGreen.Name = "contextMenuIconColorGreen";
            this.contextMenuIconColorGreen.Size = new System.Drawing.Size(152, 22);
            this.contextMenuIconColorGreen.Text = "Green";
            this.contextMenuIconColorGreen.Click += new System.EventHandler(this.contextMenuIconColorGreen_Click);
            // 
            // contextMenuIconColorRed
            // 
            this.contextMenuIconColorRed.ForeColor = System.Drawing.Color.Red;
            this.contextMenuIconColorRed.Name = "contextMenuIconColorRed";
            this.contextMenuIconColorRed.Size = new System.Drawing.Size(152, 22);
            this.contextMenuIconColorRed.Text = "Red";
            this.contextMenuIconColorRed.Click += new System.EventHandler(this.contextMenuIconColorRed_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "HD Monitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon hdNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextMenuExit;
        private System.Windows.Forms.ToolStripSeparator contextMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem contextMenuTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuShowNotification;
        private System.Windows.Forms.ToolStripMenuItem contextMenuIconColor;
        private System.Windows.Forms.ToolStripMenuItem contextMenuIconColorBlue;
        private System.Windows.Forms.ToolStripMenuItem contextMenuIconColorCyan;
        private System.Windows.Forms.ToolStripMenuItem contextMenuIconColorGreen;
        private System.Windows.Forms.ToolStripMenuItem contextMenuIconColorRed;
    }
}

