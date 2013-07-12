namespace Outlook2013TodoAddIn
{
    partial class AppointmentsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctxMenuAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemReplyAllEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apptCalendar = new Outlook2013TodoAddIn.CustomCalendar();
            this.ctxMenuAppointments.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxMenuAppointments
            // 
            this.ctxMenuAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemReplyAllEmail});
            this.ctxMenuAppointments.Name = "ctxMenuAppointments";
            this.ctxMenuAppointments.Size = new System.Drawing.Size(214, 28);
            // 
            // mnuItemReplyAllEmail
            // 
            this.mnuItemReplyAllEmail.Name = "mnuItemReplyAllEmail";
            this.mnuItemReplyAllEmail.Size = new System.Drawing.Size(213, 24);
            this.mnuItemReplyAllEmail.Text = "Reply All With Email";
            this.mnuItemReplyAllEmail.Click += new System.EventHandler(this.mnuItemReplyAllEmail_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.apptCalendar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 767);
            this.panel1.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.ContextMenuStrip = this.ctxMenuAppointments;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(0, 228);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(258, 539);
            this.listView1.TabIndex = 4;
            this.listView1.TileSize = new System.Drawing.Size(300, 38);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subject";
            this.columnHeader2.Width = 200;
            // 
            // apptCalendar
            // 
            this.apptCalendar.BoldedDates = null;
            this.apptCalendar.CurrentMonthForeColor = System.Drawing.Color.Black;
            this.apptCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.apptCalendar.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.apptCalendar.HoverBackColor = System.Drawing.Color.LightCyan;
            this.apptCalendar.HoverForeColor = System.Drawing.Color.Black;
            this.apptCalendar.Location = new System.Drawing.Point(0, 0);
            this.apptCalendar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.apptCalendar.Name = "apptCalendar";
            this.apptCalendar.OtherMonthForeColor = System.Drawing.Color.LightGray;
            this.apptCalendar.SelectedBackColor = System.Drawing.Color.LightBlue;
            this.apptCalendar.SelectedDate = new System.DateTime(2013, 5, 2, 0, 0, 0, 0);
            this.apptCalendar.SelectedForeColor = System.Drawing.Color.Blue;
            this.apptCalendar.Size = new System.Drawing.Size(258, 228);
            this.apptCalendar.TabIndex = 1;
            this.apptCalendar.TodayBackColor = System.Drawing.Color.Blue;
            this.apptCalendar.TodayForeColor = System.Drawing.Color.White;
            this.apptCalendar.CellDoubleClick += new System.EventHandler(this.apptCalendar_CellDoubleClick);
            this.apptCalendar.SelectedDateChanged += new System.EventHandler(this.apptCalendar_SelectedDateChanged);
            this.apptCalendar.ConfigurationButtonClicked += new System.EventHandler(this.apptCalendar_ConfigurationButtonClicked);
            // 
            // AppointmentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AppointmentsControl";
            this.Size = new System.Drawing.Size(258, 767);
            this.ctxMenuAppointments.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ctxMenuAppointments;
        private System.Windows.Forms.ToolStripMenuItem mnuItemReplyAllEmail;
        private System.Windows.Forms.Panel panel1;
        private CustomCalendar apptCalendar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;


    }
}
