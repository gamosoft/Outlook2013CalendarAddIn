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

namespace Outlook2013TodoAddIn.Forms
{
    /// <summary>
    /// New form to display new email notifications
    /// </summary>
    public partial class NewMailAlert : Form
    {
        #region "Variables"

        /// <summary>
        /// To control how long the form displays
        /// </summary>
        private Timer timer;

        /// <summary>
        /// Don't close the for if the mouse is over it
        /// </summary>
        #endregion "Variables"
        private bool mouseIsOver = false;
        /// <summary>


        #region "Properties"

        /// Attached email message to open or flag
        /// </summary>
        public Microsoft.Office.Interop.Outlook.MailItem Email { get; set; }

        /// <summary>
        /// Whether to show without the form activation
        /// </summary>
        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        /// <summary>
        /// This is used so we can show without activation and be the TopMost form
        /// The TopMost property of the form MUST be set to false for this to work
        /// https://connect.microsoft.com/VisualStudio/feedback/details/401311/showwithoutactivation-is-not-supported-with-topmost
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams value = base.CreateParams;
                value.ExStyle |= Constants.WS_EX_TOPMOST;
                return value;
            }
        }

        #endregion "Properties"

        #region "Methods"

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="newMail">Mail item</param>
        /// <param name="interval">Time in ms to keep the alert on</param>
        public NewMailAlert(Microsoft.Office.Interop.Outlook.MailItem newMail, int interval)
        {
            InitializeComponent();
            this.Email = newMail; // Assign it to open or flag later
            this.lnkSender.Text = newMail.Sender.Name;
            this.lnkSubject.Text = newMail.Subject;
            this.txtBody.Text = newMail.Body;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 10;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 10;
            this.timer = new Timer();
            timer.Interval = interval;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        /// <summary>
        /// Button delete clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Email.Delete();
            this.Close();
        }

        /// <summary>
        /// Button flag clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnFlag_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Outlook.OlFlagIcon.olYellowFlagIcon
            this.Email.FlagRequest = Constants.FollowUp;
            this.Email.Save();
            this.Close();
        }

        /// <summary>
        /// Button envelope clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnEnvelope_Click(object sender, EventArgs e)
        {
            this.ShowEmail();
        }

        /// <summary>
        /// Button close clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Sender hyperlink clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">LinkLabelLinkClickedEventArgs</param>
        private void lnkSender_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowEmail();
        }

        /// <summary>
        /// Subject hyperlink clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">LinkLabelLinkClickedEventArgs</param>
        private void lnkSubject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowEmail();
        }

        /// <summary>
        /// Body textbox clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void txtBody_Click(object sender, EventArgs e)
        {
            this.ShowEmail();
        }

        /// <summary>
        /// Show the email and close the form
        /// </summary>
        private void ShowEmail()
        {
            this.Email.Display();
            this.Close();
        }

        /// <summary>
        /// Process timer ticks
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (!mouseIsOver)
            {
                timer.Stop();
                this.Close();
            }
        }

        /// <summary>
        /// Processed when the mouse enters the form
        /// </summary>
        /// <param name="ea">EventArgs</param>
        protected override void OnMouseEnter(EventArgs ea)
        {
            base.OnMouseEnter(ea);
            Point mousePos = PointToClient(Cursor.Position);
            mouseIsOver = ClientRectangle.Contains(mousePos);
        }

        /// <summary>
        /// Processed when the mouse exits the form
        /// </summary>
        /// <param name="ea">EventArgs</param>
        protected override void OnMouseLeave(EventArgs ea)
        {
            base.OnMouseLeave(ea);
            Point mousePos = PointToClient(Cursor.Position);
            mouseIsOver = ClientRectangle.Contains(mousePos);
        }

        #endregion "Methods"
    }
}