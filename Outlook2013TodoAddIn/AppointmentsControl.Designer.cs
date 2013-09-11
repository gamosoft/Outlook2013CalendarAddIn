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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstAppointments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTasks = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.apptCalendar = new Outlook2013TodoAddIn.CustomCalendar();
            this.ctxMenuAppointments.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelCalendar.SuspendLayout();
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
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.panelCalendar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 767);
            this.panel1.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 230);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstAppointments);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstTasks);
            this.splitContainer1.Size = new System.Drawing.Size(258, 537);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 6;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // lstAppointments
            // 
            this.lstAppointments.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstAppointments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstAppointments.ContextMenuStrip = this.ctxMenuAppointments;
            this.lstAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAppointments.FullRowSelect = true;
            this.lstAppointments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstAppointments.Location = new System.Drawing.Point(0, 0);
            this.lstAppointments.MultiSelect = false;
            this.lstAppointments.Name = "lstAppointments";
            this.lstAppointments.OwnerDraw = true;
            this.lstAppointments.ShowItemToolTips = true;
            this.lstAppointments.Size = new System.Drawing.Size(258, 268);
            this.lstAppointments.TabIndex = 4;
            this.lstAppointments.TileSize = new System.Drawing.Size(300, 38);
            this.lstAppointments.UseCompatibleStateImageBehavior = false;
            this.lstAppointments.View = System.Windows.Forms.View.Tile;
            this.lstAppointments.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lstAppointments_DrawItem);
            this.lstAppointments.DoubleClick += new System.EventHandler(this.lstAppointments_DoubleClick);
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
            // lstTasks
            // 
            this.lstTasks.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lstTasks.ContextMenuStrip = this.ctxMenuAppointments;
            this.lstTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTasks.FullRowSelect = true;
            this.lstTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstTasks.Location = new System.Drawing.Point(0, 0);
            this.lstTasks.MultiSelect = false;
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.OwnerDraw = true;
            this.lstTasks.ShowItemToolTips = true;
            this.lstTasks.Size = new System.Drawing.Size(258, 265);
            this.lstTasks.TabIndex = 5;
            this.lstTasks.TileSize = new System.Drawing.Size(300, 38);
            this.lstTasks.UseCompatibleStateImageBehavior = false;
            this.lstTasks.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subject";
            this.columnHeader4.Width = 200;
            // 
            // panelCalendar
            // 
            this.panelCalendar.Controls.Add(this.apptCalendar);
            this.panelCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCalendar.Location = new System.Drawing.Point(0, 0);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(258, 230);
            this.panelCalendar.TabIndex = 7;
            // 
            // apptCalendar
            // 
            this.apptCalendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.apptCalendar.BoldedDates = null;
            this.apptCalendar.CurrentMonthForeColor = System.Drawing.Color.Black;
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
            this.apptCalendar.Size = new System.Drawing.Size(258, 230);
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelCalendar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ctxMenuAppointments;
        private System.Windows.Forms.ToolStripMenuItem mnuItemReplyAllEmail;
        private System.Windows.Forms.Panel panel1;
        private CustomCalendar apptCalendar;
        private System.Windows.Forms.ListView lstAppointments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lstTasks;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelCalendar;


    }
}
