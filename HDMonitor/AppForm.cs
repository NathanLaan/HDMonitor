using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Management;
using System.Management.Instrumentation;

namespace HDMonitor
{
    public partial class AppForm : Form
    {

        private const string MANAGEMENT_OBJECT_DISK_READ = "DiskBytesPersec";

        private Icon hdIconOn;
        private Icon hdIconOff;

        private bool hdMonitorThreadRunning = false;
        private Thread hdMonitorThread;

        private static readonly Icon hd_blue = new Icon("Icons/HD32-blue.ico");
        private static readonly Icon hd_cyan = new Icon("Icons/HD32-cyan.ico");
        private static readonly Icon hd_green = new Icon("Icons/HD32-green.ico");
        private static readonly Icon hd_red = new Icon("Icons/HD32-red.ico");
        private static readonly Icon hd_white = new Icon("Icons/HD32-white.ico");
        private static readonly Icon hd_yellow = new Icon("Icons/HD32-yellow.ico");


        public AppForm()
        {
            InitializeComponent();

            //this.hdIconOn = new Icon("HD-ON-32.ico");
            //this.hdIconOff = new Icon("HD-OFF-32.ico");
            this.hdIconOn = hd_green;
            this.hdIconOff = hd_white;
            this.contextMenuIconColorGreen.Checked = true;
            this.hdNotifyIcon.Icon = this.hdIconOff;
            this.hdNotifyIcon.ContextMenuStrip = this.contextMenu;

            Application.ApplicationExit += Application_ApplicationExit;

            this.hdMonitorThreadRunning = true;
            this.hdMonitorThread = new Thread(new ThreadStart(this.hdMonitorThreadExecute));
            this.hdMonitorThread.Start();
        }


        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            this.hdMonitorThreadRunning = false;
            this.hdMonitorThread.Abort();
            this.hdNotifyIcon.Dispose();
            //MessageBox.Show("Exit");
        }

        private void contextMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool showActivityNotificationBalloon = false;


        private void hdMonitorThreadExecute()
        {
            using (ManagementClass driveDataClass = new ManagementClass("Win32_PerfFormattedData_PerfDisk_PhysicalDisk"))
            {
                ManagementObjectCollection driveDataClassList = driveDataClass.GetInstances();
                object mgmtObj;
                try
                {
                    while (this.hdMonitorThreadRunning)
                    {
                        driveDataClassList = driveDataClass.GetInstances();
                        foreach (ManagementObject managementObject in driveDataClassList)
                        {
                            // We only want the "_Total" HD activity
                            if (managementObject["Name"].ToString() == "_Total")
                            {
                                mgmtObj = managementObject[MANAGEMENT_OBJECT_DISK_READ];
                                if (Convert.ToUInt64(mgmtObj) > 0)
                                {
                                    if (showActivityNotificationBalloon)
                                    {
                                        this.hdNotifyIcon.ShowBalloonTip(2000, "HD Activity", mgmtObj.ToString(), ToolTipIcon.Info);
                                    }
                                    this.hdNotifyIcon.Icon = hdIconOn;
                                }
                                else
                                {
                                    this.hdNotifyIcon.Icon = hdIconOff;
                                }
                            }
                        }

                        Thread.Sleep(10);
                    }
                }
                catch (ThreadAbortException exception)
                {
                    //
                    // TODO: logging...?
                    //
                }
                finally
                {
                    driveDataClassList.Dispose();
                }
            }

        }

        private void contextMenuShowNotification_Click(object sender, EventArgs e)
        {
            this.showActivityNotificationBalloon = this.contextMenuShowNotification.Checked;
        }

        private void contextMenuIconColorBlue_Click(object sender, EventArgs e)
        {
            this.contextMenuIconColorBlue.Checked = true;
            this.contextMenuIconColorCyan.Checked = false;
            this.contextMenuIconColorGreen.Checked = false;
            this.contextMenuIconColorRed.Checked = false;
            this.hdIconOn = AppForm.hd_blue;
        }

        private void contextMenuIconColorCyan_Click(object sender, EventArgs e)
        {
            this.contextMenuIconColorBlue.Checked = false;
            this.contextMenuIconColorCyan.Checked = true;
            this.contextMenuIconColorGreen.Checked = false;
            this.contextMenuIconColorRed.Checked = false;
            this.hdIconOn = AppForm.hd_cyan;
        }

        private void contextMenuIconColorGreen_Click(object sender, EventArgs e)
        {
            this.contextMenuIconColorBlue.Checked = false;
            this.contextMenuIconColorCyan.Checked = false;
            this.contextMenuIconColorGreen.Checked = true;
            this.contextMenuIconColorRed.Checked = false;
            this.hdIconOn = AppForm.hd_green;
        }

        private void contextMenuIconColorRed_Click(object sender, EventArgs e)
        {
            this.contextMenuIconColorBlue.Checked = false;
            this.contextMenuIconColorCyan.Checked = false;
            this.contextMenuIconColorGreen.Checked = false;
            this.contextMenuIconColorRed.Checked = true;
            this.hdIconOn = AppForm.hd_red;
        }


    }
}
