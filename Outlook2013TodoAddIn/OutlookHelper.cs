using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Outlook2013TodoAddIn
{
    public class OutlookHelper
    {
        #region "Variables"

        /// <summary>
        /// Used to retrieve the email address of a contact
        /// </summary>
        private const string PR_SMTP_ADDRESS = "http://schemas.microsoft.com/mapi/proptag/0x39FE001E";

        #endregion "Variables"

        #region "Methods"

        /// <summary>
        /// Resolves Outlook recipient email address
        /// </summary>
        /// <param name="rcpt">Recipient</param>
        /// <returns>Email address of the contact</returns>
        public static string GetEmailAddress(Outlook.Recipient rcpt)
        {
            Outlook.PropertyAccessor pa = rcpt.PropertyAccessor;
            return pa.GetProperty(PR_SMTP_ADDRESS).ToString();
        }

        /// <summary>
        /// Gets a list of recipients email addresses, and when exception is present will not be included
        /// </summary>
        /// <param name="rcpts">Recipients</param>
        /// <param name="exception">Email address exception</param>
        /// <returns>List of emails</returns>
        public static List<string> GetRecipentsEmailAddresses(Outlook.Recipients rcpts, string exception)
        {
            List<string> results = new List<string>();
            foreach (Outlook.Recipient rcpt in rcpts)
            {
                string smtpAddress = OutlookHelper.GetEmailAddress(rcpt);
                if (smtpAddress != exception && !results.Contains(smtpAddress))
                {
                    results.Add(smtpAddress);
                }
            }
            return results;
        }

        /// <summary>
        /// Rounds up a datetime to the nearest X interval
        /// e.g.: RoundUp(new DateTime(2013, 6, 18, 13, 43, 10), TimeSpan.FromMinutes(15)); -> 6/18/2013 1:45:00 PM
        /// </summary>
        /// <param name="dt">DateTime</param>
        /// <param name="d">TimeSpan</param>
        /// <returns></returns>
        public static DateTime RoundUp(DateTime dt, TimeSpan d)
        {
            return new DateTime(((dt.Ticks + d.Ticks - 1) / d.Ticks) * d.Ticks);
        }

        #endregion "Methods"
    }
}   