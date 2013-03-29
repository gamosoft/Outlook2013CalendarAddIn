using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Outlook2013TodoAddIn
{
    /// User control to hold the calendar, etc...
    /// </summary>
    public partial class AppointmentsControl : UserControl
    {
        #region "Variables"
    /// <summary>

        /// <summary>
        /// Used to retrieve the email address of a contact
        /// </summary>
        private const string PR_SMTP_ADDRESS = "http://schemas.microsoft.com/mapi/proptag/0x39FE001E";

        #endregion "Variables"

        #region "Properties"
        
        /// <summary>
        /// Number of days (including today) to retrieve appointments from in the future
        /// </summary>
        public decimal NumDays
        {
            get { return this.numRangeDays.Value; }
            set { this.numRangeDays.Value = value; }
        }

        #endregion "Properties"

        #region "Methods"

        /// <summary>
        /// Default constructor
        /// </summary>
        public AppointmentsControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Respond to calendar changes
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">DateRangeEventArgs</param>
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.RetrieveAppointments();
        }

        /// <summary>
        /// Change days to retrieve appointments in the future
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void numRangeDays_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.NumDays = this.numRangeDays.Value;
            this.RetrieveAppointments();
        }

        /// <summary>
        /// Manual refresh
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RetrieveAppointments();
        }

        /// <summary>
        /// Retrieve all appointments for the current configurations
        /// </summary>
        public void RetrieveAppointments()
        {
            // Get the Outlook folder for the calendar to retrieve the appointments
            Outlook.Folder calFolder =
                Globals.ThisAddIn.Application.Session.GetDefaultFolder(
                Outlook.OlDefaultFolders.olFolderCalendar)
                as Outlook.Folder;

            int selectedMonth = this.apptCalendar.SelectionStart.Month;
            int selectedYear = this.apptCalendar.SelectionStart.Year;

            // To get all the appointments for the current month (so it displays nicely bolded even for past events)
            DateTime start = new DateTime(selectedYear, selectedMonth, 1); // MM-01-YYYY
            DateTime end = start.AddMonths(1).AddDays(-1); // Last day of the month
            end = end.AddDays((int)this.numRangeDays.Value); // So we get appointments for the "possible" first days of the next month

            // Get all the appointments
            Outlook.Items rangeAppts = GetAppointmentsInRange(calFolder, start, end);

            // Get a more manageable list
            List<Outlook.AppointmentItem> appts = new List<Outlook.AppointmentItem>();
            if (rangeAppts != null)
            {
                foreach (Outlook.AppointmentItem appt in rangeAppts)
                {
                    appts.Add(appt);
                }
            }

            // Highlight dates with appointments in the current calendar
            this.apptCalendar.BoldedDates = appts.Select<Outlook.AppointmentItem, DateTime>(a => a.Start).ToArray();

            // Now display the actual appointments below the calendar
            DateTime startRange = this.apptCalendar.SelectionStart;
            DateTime endRange = startRange.AddDays((int)this.numRangeDays.Value);

            // Get items in range
            var lstItems = appts.Where(a => a.Start >= startRange && a.Start <= endRange);

            int sameDay = -1; // startRange.Day;

            List<ListViewItem> lstCol = new List<ListViewItem>();
            lstItems.ToList().ForEach(i =>
            {
                if (i.Start.Day != sameDay)
                {
                    ListViewItem dateItem = new ListViewItem() { Text = i.Start.ToShortDateString() };
                    dateItem.Font = new Font(this.listView1.Font, FontStyle.Bold);
                    lstCol.Add(dateItem);
                    sameDay = i.Start.Day;
                };

                ListViewItem current = new ListViewItem() { Text = i.Start.ToShortTimeString() };
                current.SubItems.Add(i.Subject);

                // current.SubItems.Add(i.Location);
                current.ToolTipText = String.Format("{0} - {1}  {2}", i.Start.ToShortTimeString(), i.End.ToShortTimeString(), i.Subject);
                current.Tag = i;

                switch (i.BusyStatus)
                {
                    case Outlook.OlBusyStatus.olBusy:
                        current.ForeColor = Color.Purple;
                        break;
                    case Outlook.OlBusyStatus.olFree:
                        break;
                    case Outlook.OlBusyStatus.olOutOfOffice:
                        current.ForeColor = Color.Brown;
                        break;
                    case Outlook.OlBusyStatus.olTentative:
                        break;
                    case Outlook.OlBusyStatus.olWorkingElsewhere:
                        break;
                    default:
                        break;
                }

                lstCol.Add(current);

                // Add location into a new line (if available)
                if (!String.IsNullOrEmpty(i.Location))
                {
                    ListViewItem locationItem = new ListViewItem() { Text = String.Empty };
                    locationItem.SubItems.Add(i.Location);
                    locationItem.ForeColor = current.ForeColor;
                    locationItem.Tag = i;
                    lstCol.Add(locationItem);
                }
            });

            this.listView1.Items.Clear();
            this.listView1.Items.AddRange(lstCol.ToArray());
        }

        /// <summary>
        /// Get recurring appointments in a date range.
        /// </summary>
        /// <param name="folder">Outlook folder</param>
        /// <param name="startTime">Start time</param>
        /// <param name="endTime">End time</param>
        /// <returns>Outlook.Items</returns>
        private Outlook.Items GetAppointmentsInRange(Outlook.Folder folder, DateTime startTime, DateTime endTime)
        {
            string filter = "[Start] >= '"
                + startTime.ToString("g")
                + "' AND [End] <= '"
                + endTime.ToString("g") + "'";

            try
            {
                Outlook.Items calItems = folder.Items;
                calItems.IncludeRecurrences = true;
                calItems.Sort("[Start]", Type.Missing);
                Outlook.Items restrictItems = calItems.Restrict(filter);
                if (restrictItems.Count > 0)
                {
                    return restrictItems;
                }
                else
                {
                    return null;
                }
            }
            catch { return null; }
        }

        /// <summary>
        /// Open the appointment, having in mind it might be a recurring event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.listView1.SelectedIndices.Count != 0)
            {
                Outlook.AppointmentItem appt = this.listView1.SelectedItems[0].Tag as Outlook.AppointmentItem;
                if (appt != null)
                {
                    if (appt.IsRecurring)
                    {
                        FormRecurringOpen f = new FormRecurringOpen();
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            if (f.OpenRecurring)
                            {
                                // Open up the master appointment in a new window
                                // If we open the current instance then there is an error: "This item is no longer valid because it has been closed"
                                // One workaround is to refresh the appointments list to get new instances...
                                Outlook.AppointmentItem masterAppt = appt.Parent; // Get the master appointment item
                                masterAppt.Display(true); // Will modify ALL instances
                            }
                            else
                            {
                                // Open up the appointment in a new window
                                appt.Display(true); // Modal yes/no
                            }
                        }
                    }
                    else
                    {
                        // Open up the appointment in a new window
                        appt.Display(true); // Modal yes/no
                    }
                    // At the end, synchronously "refresh" items in case they have changed
                    this.RetrieveAppointments();
                }
            }
        }

        /// <summary>
        /// Creates a new mail item to reply all recipients of an appointment (except the current user)
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void mnuItemReplyAllEmail_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedIndices.Count != 0)
            {
                Outlook.AppointmentItem appt = this.listView1.SelectedItems[0].Tag as Outlook.AppointmentItem;
                if (appt != null)
                {
                    Outlook.MailItem mail = Globals.ThisAddIn.Application.CreateItem(Outlook.OlItemType.olMailItem) as Outlook.MailItem;
                    string curUserAddress = GetEmailAddress(Globals.ThisAddIn.Application.Session.CurrentUser);
                    foreach (Outlook.Recipient rcpt in appt.Recipients)
                    {
                        string smtpAddress = GetEmailAddress(rcpt);
                        if (curUserAddress != smtpAddress)
                        {
                            mail.Recipients.Add(smtpAddress);
                        }
                    }
                    mail.Body = Environment.NewLine + Environment.NewLine + appt.Body;
                    mail.Subject = "RE: " + appt.Subject;
                    mail.Display();
                }
            }
        }

        /// <summary>
        /// Resolves Outlook recipient email address
        /// </summary>
        /// <param name="rcpt">Recipient</param>
        /// <returns>Email address of the contact</returns>
        private string GetEmailAddress(Outlook.Recipient rcpt)
        {
            Outlook.PropertyAccessor pa = rcpt.PropertyAccessor;
            return pa.GetProperty(PR_SMTP_ADDRESS).ToString();
        }

        /// <summary>
        /// Switch to the calendar view when double-clicking a date
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void apptCalendar_DoubleClickEx(object sender, EventArgs e)
        {
            // Clicking in days outside of the current month will cause the calendar to refresh to that day
            // reposition all days and select the wrong one
            Outlook.Folder f = Globals.ThisAddIn.Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderCalendar) as Outlook.Folder;
            Globals.ThisAddIn.Application.ActiveExplorer().CurrentFolder = f;
            Outlook.CalendarView cv = (Outlook.CalendarView)(Globals.ThisAddIn.Application.ActiveExplorer().CurrentView);
            cv.CalendarViewMode = Outlook.OlCalendarViewMode.olCalendarViewDay;
            cv.GoToDate(this.apptCalendar.SelectionStart);
        }

        #endregion "Methods"
    }
}