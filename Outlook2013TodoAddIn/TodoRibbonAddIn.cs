using Microsoft.Office.Tools.Ribbon;

namespace Outlook2013TodoAddIn
{
    /// <summary>
    /// Adds a button to the add-in placeholder in the ribbon
    /// </summary>
    public partial class TodoRibbonAddIn
    {
        #region "Methods"

        /// <summary>
        /// Change visibility of the pane
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">RibbonControlEventArgs</param>
        private void toggleButton1_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ToDoTaskPane.Visible = this.toggleButton1.Checked;
        }

        #endregion
    }
}