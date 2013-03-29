using Microsoft.Win32;
using System;
using System.Linq;
using Office = Microsoft.Office.Core;

namespace Outlook2013TodoAddIn
{
    public partial class ThisAddIn
    {
        private AppointmentsControl appControl;

        public Microsoft.Office.Tools.CustomTaskPane ToDoTaskPane { get; set; }

        //private Dictionary<Outlook.Inspector, InspectorWrapper> inspectorWrappersValue = new Dictionary<Outlook.Inspector, InspectorWrapper>();
        //private Outlook.Inspectors inspectors;

        //void Inspectors_NewInspector(Outlook.Inspector Inspector)
        //{
        //    if (Inspector.CurrentItem is Outlook.MailItem)
        //    {
        //        inspectorWrappersValue.Add(Inspector, new InspectorWrapper(Inspector));
        //    }
        //}

        //public Dictionary<Outlook.Inspector, InspectorWrapper> InspectorWrappers
        //{
        //    get
        //    {
        //        return inspectorWrappersValue;
        //    }
        //}

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //inspectors = this.Application.Inspectors;
            //inspectors.NewInspector +=
            //    new Outlook.InspectorsEvents_NewInspectorEventHandler(
            //    Inspectors_NewInspector);

            //foreach (Outlook.Inspector inspector in inspectors)
            //{
            //    Inspectors_NewInspector(inspector);
            //}

            appControl = new AppointmentsControl();
            appControl.NumDays = Properties.Settings.Default.NumDays; // Setting the value will load the appointments

            //Properties.Settings.Default.Properties[]
            // appControl.Dock = System.Windows.Forms.DockStyle.Right;
            ToDoTaskPane = this.CustomTaskPanes.Add(appControl, "Appointments");
            ToDoTaskPane.Visible = Properties.Settings.Default.Visible;

            //ToDoTaskPane.Visible = true;
            //ToDoTaskPane.Width = 285; // appControl.Width;
            ToDoTaskPane.Width = Properties.Settings.Default.Width;
            ToDoTaskPane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionRight;
            ToDoTaskPane.DockPositionRestrict = Office.MsoCTPDockPositionRestrict.msoCTPDockPositionRestrictNoHorizontal;
            ToDoTaskPane.VisibleChanged += ToDoTaskPane_VisibleChanged;
            appControl.SizeChanged += appControl_SizeChanged;

            this.AddRegistryNotification();
        }

        private void appControl_SizeChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Width = ToDoTaskPane.Width;
        }

        private void ToDoTaskPane_VisibleChanged(object sender, EventArgs e)
        {
            // Properties.Settings.Default.Visible = ToDoTaskPane.Visible;
            TodoRibbonAddIn rbn = Globals.Ribbons.FirstOrDefault(r => r is TodoRibbonAddIn) as TodoRibbonAddIn;
            if (rbn != null)
            {
                rbn.toggleButton1.Checked = ToDoTaskPane.Visible;
            }
        }

        /// <summary>
        /// This is NEVER executed anymore
        /// http://msdn.microsoft.com/en-us/library/office/ee720183.aspx#OL2010AdditionalShutdownChanges_AddinShutdownChangesinOL2010Beta
        /// We MANUALLY add notification to the registry of each user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            //inspectors.NewInspector -=
            //    new Outlook.InspectorsEvents_NewInspectorEventHandler(
            //    Inspectors_NewInspector);
            //inspectors = null;
            //inspectorWrappersValue = null;
            // Can't call these because the object is already disposed. Settings will be set while the app is running
            //Properties.Settings.Default.Visible = ToDoTaskPane.Visible;
            //Properties.Settings.Default.Width = ToDoTaskPane.Width;
            //Properties.Settings.Default.NumDays = appControl.NumDays;
            Properties.Settings.Default.Save();
        }

        private void AddRegistryNotification()
        {
            // http://msdn.microsoft.com/en-us/library/office/ee720183.aspx#OL2010AdditionalShutdownChanges_AddinShutdownChangesinOL2010Beta
            // HKEY_CURRENT_USER\Software\Microsoft\Office\Outlook\Addins\<ProgID>\[RequireShutdownNotification]=dword:0x1

            string subKey = @"Software\Microsoft\Office\Outlook\Addins\Outlook2013TodoAddIn";
            RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subKey, true);

            if (rk == null)
            {
                rk = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
            }

            if ((int)rk.GetValue("RequireShutdownNotification", 0) == 0)
            {
                rk.SetValue("RequireShutdownNotification", 1, RegistryValueKind.DWord); // "dword:0x1"
            }
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion VSTO generated code
    }
}