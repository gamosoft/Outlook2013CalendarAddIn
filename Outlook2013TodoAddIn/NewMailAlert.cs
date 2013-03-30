using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Outlook2013TodoAddIn
{
    public partial class NewMailAlert : Form
    {
        public Microsoft.Office.Interop.Outlook.MailItem Email { get; set; }

        public NewMailAlert(string sender, string subject, string body)
        {
            InitializeComponent();
            this.lblSender.Text = sender;
            this.lblSubject.Text = subject;
            this.txtBody.Text = body;
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
            this.Email.Display();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}