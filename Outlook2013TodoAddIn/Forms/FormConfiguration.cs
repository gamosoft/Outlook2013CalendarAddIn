using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Outlook2013TodoAddIn.Forms
{
    public partial class FormConfiguration : Form
    {
        #region "Properties"

        /// <summary>
        /// Number of days (including today) to retrieve appointments from in the future
        /// </summary>
        public decimal NumDays
        {
            get { return this.numRangeDays.Value; }
            set { this.numRangeDays.Value = value; }
        }

        /// <summary>
        /// Gets/sets whether mail notifications are enabled or not
        /// </summary>
        public bool MailAlertsEnabled
        {
            get { return this.chkMailAlerts.Checked; }
            set { this.chkMailAlerts.Checked = value; }
        }

        /// <summary>
        /// Gets/sets whether to show past appointments in the current day or not
        /// </summary>
        public bool ShowPastAppointments
        {
            get { return this.chkShowPastAppointments.Checked; }
            set { this.chkShowPastAppointments.Checked = value; }
        }

        /// <summary>
        /// Gets/sets a list of all stores/accounts to retrieve information from
        /// </summary>
        public StringCollection Accounts
        {
            get
            {
                StringCollection col = new StringCollection();
                foreach (object item in this.chkListCalendars.CheckedItems)
                {
                    col.Add(item.ToString());
                }
                return col;
            }
        }

        /// <summary>
        /// Gets/sets whether to show friendly group headers (yesterday, today, tomorrow)
        /// </summary>
        public bool ShowFriendlyGroupHeaders
        {
            get { return this.chkFriendlyGroupHeaders.Checked; }
            set { this.chkFriendlyGroupHeaders.Checked = value; }
        }

        /// <summary>
        /// Gets/sets whether to show localized day names next to the days
        /// </summary>
        public bool ShowDayNames
        {
            get { return this.chkShowDayNames.Checked; }
            set { this.chkShowDayNames.Checked = value; }
        }

        /// <summary>
        /// Gets/sets whether to show week numbers
        /// </summary>
        public bool ShowWeekNumbers
        {
            get { return this.chkShowWeekNumbers.Checked; }
            set { this.chkShowWeekNumbers.Checked = value; }
        }

        /// <summary>
        /// Gets/sets whether to show the tasks list
        /// </summary>
        public bool ShowTasks
        {
            get { return this.chkShowTasks.Checked; }
            set { this.chkShowTasks.Checked = value; }
        }

        /// <summary>
        /// Gets/sets whether to show the completed tasks in the list
        /// </summary>
        public bool ShowCompletedTasks
        {
            get { return this.chkShowCompletedTasks.Checked; }
            set { this.chkShowCompletedTasks.Checked = value; }
        }

        /// <summary>
        /// Gets/sets the first day of the week for the calendar
        /// </summary>
        public System.DayOfWeek FirstDayOfWeek
        {
            get { return (System.DayOfWeek)Enum.Parse(typeof(System.DayOfWeek), this.cboFirstDayOfWeek.SelectedValue.ToString()); }
            set { this.cboFirstDayOfWeek.SelectedValue = value; }
        }

        #endregion "Properties"
        
        #region "Methods"

        /// <summary>
        /// Default constructor
        /// </summary>
        public FormConfiguration()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On load, display saved configuration
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void FormConfiguration_Load(object sender, EventArgs e)
        {
            this.numRangeDays.Value = Properties.Settings.Default.NumDays;
            this.chkMailAlerts.Checked = Properties.Settings.Default.MailAlertsEnabled;
            this.numRangeEmailAlertsTimeOut.Value = Properties.Settings.Default.DisplayTimeOut / 1000;
            this.chkShowPastAppointments.Checked = Properties.Settings.Default.ShowPastAppointments;
            this.chkFriendlyGroupHeaders.Checked = Properties.Settings.Default.ShowFriendlyGroupHeaders;
            this.chkShowDayNames.Checked = Properties.Settings.Default.ShowDayNames;
            this.chkShowWeekNumbers.Checked = Properties.Settings.Default.ShowWeekNumbers;
            this.chkShowTasks.Checked = Properties.Settings.Default.ShowTasks;
            this.chkShowCompletedTasks.Checked = Properties.Settings.Default.ShowCompletedTasks;
            this.LoadStores();
            this.LoadDays();
        }

        /// <summary>
        /// Loads all the stores (accounts) in the current session
        /// </summary>
        private void LoadStores()
        {
            foreach (Outlook.Store store in Globals.ThisAddIn.Application.Session.Stores)
            {
                bool itemChecked = Properties.Settings.Default.Accounts != null && Properties.Settings.Default.Accounts.Contains(store.DisplayName);
                int index = this.chkListCalendars.Items.Add(store.DisplayName, itemChecked);
                // TODO: Use StoreID instead?
            }
        }

        /// <summary>
        /// Loads the available days of the week in the dropdown
        /// </summary>
        private void LoadDays()
        {
            this.cboFirstDayOfWeek.DataSource = Enum.GetValues(typeof(System.DayOfWeek));
            this.cboFirstDayOfWeek.SelectedItem = Properties.Settings.Default.FirstDayOfWeek;
        }

        /// <summary>
        /// Clicking the OK button
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NumDays = this.numRangeDays.Value;
            Properties.Settings.Default.MailAlertsEnabled = this.chkMailAlerts.Checked;
            Properties.Settings.Default.DisplayTimeOut = (int)this.numRangeEmailAlertsTimeOut.Value * 1000;
            Properties.Settings.Default.ShowPastAppointments = this.chkShowPastAppointments.Checked;
            Properties.Settings.Default.Accounts = this.Accounts;
            Properties.Settings.Default.ShowFriendlyGroupHeaders = this.chkFriendlyGroupHeaders.Checked;
            Properties.Settings.Default.ShowDayNames = this.chkShowDayNames.Checked;
            Properties.Settings.Default.ShowWeekNumbers = this.chkShowWeekNumbers.Checked;
            Properties.Settings.Default.ShowCompletedTasks = this.chkShowCompletedTasks.Checked;
            Properties.Settings.Default.FirstDayOfWeek = (System.DayOfWeek)Enum.Parse(typeof(System.DayOfWeek), this.cboFirstDayOfWeek.SelectedValue.ToString());
        }

        /// <summary>
        /// Open the default web browser with a link to PayPal in case someone wants to buy me a beer
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(Constants.DonateUrl);
        }

        #endregion "Methods"
    }
}