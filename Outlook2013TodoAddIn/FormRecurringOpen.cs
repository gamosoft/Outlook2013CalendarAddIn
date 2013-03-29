using System.Windows.Forms;

namespace Outlook2013TodoAddIn
{
    public partial class FormRecurringOpen : Form
    {
        public DialogResult ButtonPressed { get; set; }

        public bool OpenRecurring
        {
            get
            {
                return this.rbtnAll.Checked;
            }
        }

        public FormRecurringOpen()
        {
            InitializeComponent();
        }
    }
}