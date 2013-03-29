using Microsoft.Office.Tools.Ribbon;

namespace Outlook2013TodoAddIn
{
    public partial class TodoRibbonAddIn
    {
        private void TodoRibbonAddIn_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void toggleButton1_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ToDoTaskPane.Visible = this.toggleButton1.Checked;
        }
    }
}