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
            this.contextMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuTitle = new System.Windows.Forms.ToolStripMenuItem();
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
            this.contextMenuExit});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(153, 76);
            // 
            // contextMenuExit
            // 
            this.contextMenuExit.Name = "contextMenuExit";
            this.contextMenuExit.Size = new System.Drawing.Size(152, 22);
            this.contextMenuExit.Text = "E&xit";
            this.contextMenuExit.Click += new System.EventHandler(this.contextMenuExit_Click);
            // 
            // contextMenuSeparator
            // 
            this.contextMenuSeparator.Name = "contextMenuSeparator";
            this.contextMenuSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // contextMenuTitle
            // 
            this.contextMenuTitle.Enabled = false;
            this.contextMenuTitle.Name = "contextMenuTitle";
            this.contextMenuTitle.Size = new System.Drawing.Size(152, 22);
            this.contextMenuTitle.Text = "HD Monitor";
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
    }
}

