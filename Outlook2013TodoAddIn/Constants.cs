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

        /// <summary>
        /// URL to paypal donation site, in case someone want's to buy me a beer ;-)
        /// </summary>
        public const string DonateUrl = "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=ZXYEC3PM6K7TQ&lc=US&item_name=Outlook2103AddInBuyBeer&currency_code=USD&bn=PP%2dDonationsBF%3amybutton%2epng%3aNonHosted";

        /// <summary>
        /// Topmost value
        /// </summary>
        public const int WS_EX_TOPMOST = 0x00000008;

        #endregion "Variables"
    }
}