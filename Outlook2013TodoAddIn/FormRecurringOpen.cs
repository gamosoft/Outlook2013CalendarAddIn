using System.Windows.Forms;

namespace Outlook2013TodoAddIn
{
    /// <summary>
    /// Mimic Outlook's popup to open one instance or the whole series
    /// </summary>
    public partial class FormRecurringOpen : Form
    {
        #region "Properties"

        /// <summary>
        /// Whether the user wants to retrieve all instances or not
        /// </summary>
        public bool OpenRecurring
        {
            get { return this.rbtnAll.Checked; }
        }

        #endregion "Properties"

        #region "Methods"

        /// <summary>
        /// Open the form
        /// </summary>
        public FormRecurringOpen()
        {
            InitializeComponent();
        }
        
        #endregion "Methods"
    }
}