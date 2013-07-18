using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Outlook2013TodoAddIn
{
    /// <summary>
    /// New class to localize some texts and get some constants, pending proper resource localization
    /// </summary>
    public class Constants
    {
        #region "Variables"

        /// <summary>
        /// Today
        /// </summary>
        public const string Today = "Today";

        /// <summary>
        /// Yesterday
        /// </summary>
        public const string Yesterday = "Yesterday";

        /// <summary>
        /// Tomorrow
        /// </summary>
        public const string Tomorrow = "Tomorrow";

        /// <summary>
        /// Reply header prefix for the subject
        /// </summary>
        public const string SubjectRE = "RE";

        /// <summary>
        /// Follow Up email flag (can't be changed)
        /// </summary>
        public const string FollowUp = "Follow up";

        #endregion "Variables"
    }
}