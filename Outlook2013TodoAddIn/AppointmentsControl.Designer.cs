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
            this.numRangeDays = new System.Windows.Forms.NumericUpDown();
            this.lblRangeDays = new System.Windows.Forms.Label();
            this.ctxMenuAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemReplyAllEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpRefresh = new System.Windows.Forms.GroupBox();
            this.apptCalendar = new Outlook2013TodoAddIn.CustomCalendar();
            this.chkMailAlerts = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRangeDays)).BeginInit();
            this.ctxMenuAppointments.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpRefresh.SuspendLayout();
            this.SuspendLayout();
            // 
            // numRangeDays
            // 
            this.numRangeDays.Location = new System.Drawing.Point(53, 28);
            this.numRangeDays.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numRangeDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRangeDays.Name = "numRangeDays";
            this.numRangeDays.Size = new System.Drawing.Size(48, 25);
            this.numRangeDays.TabIndex = 2;
            this.numRangeDays.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numRangeDays.ValueChanged += new System.EventHandler(this.numRangeDays_ValueChanged);
            // 
            // lblRangeDays
            // 
            this.lblRangeDays.AutoSize = true;
            this.lblRangeDays.Location = new System.Drawing.Point(10, 30);
            this.lblRangeDays.Name = "lblRangeDays";
            this.lblRangeDays.Size = new System.Drawing.Size(42, 19);
            this.lblRangeDays.TabIndex = 3;
            this.lblRangeDays.Text = "Days:";
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
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(110, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(66, 24);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.grpRefresh);
            this.panel1.Controls.Add(this.apptCalendar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 815);
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
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(0, 334);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(226, 481);
            this.listView1.TabIndex = 4;
            this.listView1.TileSize = new System.Drawing.Size(300, 38);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
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
            // grpRefresh
            // 
            this.grpRefresh.Controls.Add(this.chkMailAlerts);
            this.grpRefresh.Controls.Add(this.btnRefresh);
            this.grpRefresh.Controls.Add(this.lblRangeDays);
            this.grpRefresh.Controls.Add(this.numRangeDays);
            this.grpRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRefresh.Location = new System.Drawing.Point(0, 242);
            this.grpRefresh.Name = "grpRefresh";
            this.grpRefresh.Size = new System.Drawing.Size(226, 92);
            this.grpRefresh.TabIndex = 3;
            this.grpRefresh.TabStop = false;
            this.grpRefresh.Text = "Configuration:";
            // 
            // apptCalendar
            // 
            this.apptCalendar.BoldedDates = null;
            this.apptCalendar.CurrentMonthForeColor = System.Drawing.Color.Black;
            this.apptCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.apptCalendar.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.apptCalendar.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.apptCalendar.HoverBackColor = System.Drawing.Color.LightCyan;
            this.apptCalendar.HoverForeColor = System.Drawing.Color.Black;
            this.apptCalendar.Location = new System.Drawing.Point(0, 0);
            this.apptCalendar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.apptCalendar.Name = "apptCalendar";
            this.apptCalendar.OtherMonthForeColor = System.Drawing.Color.LightGray;
            this.apptCalendar.SelectedBackColor = System.Drawing.Color.LightBlue;
            this.apptCalendar.SelectedDate = new System.DateTime(2013, 5, 1, 0, 0, 0, 0);
            this.apptCalendar.SelectedForeColor = System.Drawing.Color.Blue;
            this.apptCalendar.Size = new System.Drawing.Size(226, 242);
            this.apptCalendar.TabIndex = 1;
            this.apptCalendar.TodayBackColor = System.Drawing.Color.Blue;
            this.apptCalendar.TodayForeColor = System.Drawing.Color.White;
            this.apptCalendar.CellDoubleClick += new System.EventHandler(this.apptCalendar_CellDoubleClick);
            this.apptCalendar.SelectedDateChanged += new System.EventHandler(this.apptCalendar_SelectedDateChanged);
            // 
            // chkMailAlerts
            // 
            this.chkMailAlerts.AutoSize = true;
            this.chkMailAlerts.Location = new System.Drawing.Point(36, 63);
            this.chkMailAlerts.Name = "chkMailAlerts";
            this.chkMailAlerts.Size = new System.Drawing.Size(140, 23);
            this.chkMailAlerts.TabIndex = 5;
            this.chkMailAlerts.Text = "Enable Mail Alerts";
            this.chkMailAlerts.UseVisualStyleBackColor = true;
            this.chkMailAlerts.CheckedChanged += new System.EventHandler(this.chkMailAlerts_CheckedChanged);
            // 
            // AppointmentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AppointmentsControl";
            this.Size = new System.Drawing.Size(226, 815);
            ((System.ComponentModel.ISupportInitialize)(this.numRangeDays)).EndInit();
            this.ctxMenuAppointments.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpRefresh.ResumeLayout(false);
            this.grpRefresh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numRangeDays;
        private System.Windows.Forms.Label lblRangeDays;
        private System.Windows.Forms.ContextMenuStrip ctxMenuAppointments;
        private System.Windows.Forms.ToolStripMenuItem mnuItemReplyAllEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private CustomCalendar apptCalendar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox grpRefresh;
        private System.Windows.Forms.CheckBox chkMailAlerts;


    }
}
