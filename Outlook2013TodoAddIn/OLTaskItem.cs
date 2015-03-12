using Outlook = Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;

namespace Outlook2013TodoAddIn
{
    public class OLTaskItem
    {
        #region "Properties"
        public bool ValidTaskItem { get; set; }
        public string TaskType { get; set; }
        public string TaskSubject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Reminder { get; set; }
        public DateTime DueDate { get; set; }
        public string FolderName { get; set; }
        public object OriginalItem { get; set; }
        public List<string> Categories { get; set; }

        public bool Completed { get; set; }

        #endregion "Properties"

        #region "Methods"

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="item">Outlook item in the tasks folder</param>
        public OLTaskItem(object item)
        {
            // TODO: Priority, status, % complete
            this.ValidTaskItem = true;
            this.OriginalItem = item;
            this.Categories = new List<string>();
            if (item is Outlook.MailItem)
            {
                Outlook.MailItem mail = item as Outlook.MailItem;
                this.TaskType = "Mail";
                this.TaskSubject = mail.TaskSubject;
                this.StartDate = mail.TaskStartDate;
                this.Reminder = mail.ReminderTime;
                this.DueDate = mail.TaskDueDate;
                MAPIFolder f = (MAPIFolder)mail.Parent;
                this.FolderName = f.Name;
                if (!String.IsNullOrEmpty(mail.Categories)) this.Categories.AddRange(mail.Categories.Split(new char[] { ',' }));
                this.Completed = (mail.TaskCompletedDate.Year != Constants.NullYear);
            }
            else if (item is Outlook.ContactItem)
            {
                Outlook.ContactItem contact = item as Outlook.ContactItem;
                this.TaskType = "Contact";
                this.TaskSubject = contact.TaskSubject;
                this.StartDate = contact.TaskStartDate;
                this.Reminder = contact.ReminderTime;
                this.DueDate = contact.TaskDueDate;
                MAPIFolder f = (MAPIFolder)contact.Parent;
                this.FolderName = f.Name;
                if (!String.IsNullOrEmpty(contact.Categories)) this.Categories.AddRange(contact.Categories.Split(new char[] { ',' }));
                this.Completed = (contact.TaskCompletedDate.Year != Constants.NullYear);
            }
            else if (item is Outlook.TaskItem)
            {
                Outlook.TaskItem task = item as Outlook.TaskItem;
                this.TaskType = "Task";
                this.TaskSubject = task.Subject;
                this.StartDate = task.StartDate;
                this.Reminder = task.ReminderTime;
                this.DueDate = task.DueDate;
                MAPIFolder f = (MAPIFolder)task.Parent;
                this.FolderName = f.Name;
                if (!String.IsNullOrEmpty(task.Categories)) this.Categories.AddRange(task.Categories.Split(new char[] { ',' }));
                this.Completed = task.Complete;
            }
            else
            {
                // Unhandled type
                this.ValidTaskItem = false; // So we don't add to the collection later
            }
            this.Categories = this.Categories.Select(cat => cat.Trim()).Where(cat => !String.IsNullOrEmpty(cat)).ToList();
        }

        #endregion "Methods"
    }
}