using System.Windows.Forms;

namespace Outlook2013TodoAddIn.Forms
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

        /// <summary>
        /// To reuse the form, gets/sets the title
        /// </summary>
        public string Title { get; set; }


        /// <summary>
        /// To reuse the form, gets/sets the message
        /// </summary>
        public string Message { get; set; }

        #endregion "Properties"

        #region "Methods"

        /// <summary>
        /// Load the form
        /// </summary>
        public FormRecurringOpen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the form
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void FormRecurringOpen_Load(object sender, System.EventArgs e)
        {
            this.Text = this.Title;
            this.textBox1.Text = this.Message;
        }

        #endregion "Methods"
    }
}