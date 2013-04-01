using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Outlook2013TodoAddIn
{
    public partial class NewMailAlert : Form
    {
        private Timer timer;
        private bool mouseIsOver = false;

        public Microsoft.Office.Interop.Outlook.MailItem Email { get; set; }

        public NewMailAlert(string sender, string subject, string body, int interval)
        {
            InitializeComponent();
            this.lnkSender.Text = sender;
            this.lnkSubject.Text = subject;
            this.txtBody.Text = body;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 10;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 10;
            this.timer = new Timer();
            timer.Interval = interval;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr hWnd, uint dwTime, uint dwFlags);

        private const int SW_SHOW = 5;
        private const uint AW_BLEND = 0x00080000;

        public bool ShowPopup()
        {
            bool result = ShowWindow(this.Handle, SW_SHOW);
            //bool result = AnimateWindow(this.Handle, 200, AW_BLEND);
            this.BringToFront();
            return result;
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Email.Delete();
            this.Close();
        }

        private void btnFlag_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Outlook.OlFlagIcon.olYellowFlagIcon
            this.Email.FlagRequest = "Follow up";
            this.Email.Save();
            this.Close();
        }

        private void btnEnvelope_Click(object sender, EventArgs e)
        {
            this.ShowEmail();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowEmail()
        {
            this.Email.Display();
            this.Close();
        }

        private void lnkSender_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowEmail();
        }

        private void lnkSubject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowEmail();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            this.Focus();
            this.BringToFront();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!mouseIsOver)
            {
                timer.Stop();
                this.Close();
            }
        }

        //protected override void OnMouseEnter(EventArgs ea)
        //{
        //    base.OnMouseEnter(ea);
        //    Point clientPos = PointToClient(Cursor.Position);
        //    if (!ClientRectangle.Contains(clientPos))
        //    {
        //        mouseIsOver = true;
        //    }
        //}

        //protected override void OnMouseLeave(EventArgs ea)
        //{
        //    base.OnMouseLeave(ea);
        //    Point clientPos = PointToClient(Cursor.Position);
        //    if (!ClientRectangle.Contains(clientPos))
        //    {
        //        mouseIsOver = false;
        //    }
        //}
    }
}