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
            this.apptCalendar = new System.Windows.Forms.MonthCalendar();
            this.ctxMenuAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemReplyAllEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.hdrDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numRangeDays)).BeginInit();
            this.ctxMenuAppointments.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numRangeDays
            // 
            this.numRangeDays.Location = new System.Drawing.Point(60, 21);
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
            this.numRangeDays.Size = new System.Drawing.Size(55, 22);
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
            this.lblRangeDays.Location = new System.Drawing.Point(10, 23);
            this.lblRangeDays.Name = "lblRangeDays";
            this.lblRangeDays.Size = new System.Drawing.Size(44, 17);
            this.lblRangeDays.TabIndex = 3;
            this.lblRangeDays.Text = "Days:";
            // 
            // apptCalendar
            // 
            this.apptCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.apptCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptCalendar.Location = new System.Drawing.Point(0, 0);
            this.apptCalendar.MaxSelectionCount = 1;
            this.apptCalendar.Name = "apptCalendar";
            this.apptCalendar.TabIndex = 4;
            this.apptCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
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
            // hdrDate
            // 
            this.hdrDate.Text = "Date";
            this.hdrDate.Width = 78;
            // 
            // hdrSubject
            // 
            this.hdrSubject.Text = "Subject";
            this.hdrSubject.Width = 163;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrDate,
            this.hdrSubject});
            this.listView1.ContextMenuStrip = this.ctxMenuAppointments;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(289, 507);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.lblRangeDays);
            this.groupBox1.Controls.Add(this.numRangeDays);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 53);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Days:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(162, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 507);
            this.panel1.TabIndex = 8;
            // 
            // AppointmentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.apptCalendar);
            this.Name = "AppointmentsControl";
            this.Size = new System.Drawing.Size(289, 767);
            ((System.ComponentModel.ISupportInitialize)(this.numRangeDays)).EndInit();
            this.ctxMenuAppointments.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numRangeDays;
        private System.Windows.Forms.Label lblRangeDays;
        private System.Windows.Forms.MonthCalendar apptCalendar;
        private System.Windows.Forms.ContextMenuStrip ctxMenuAppointments;
        private System.Windows.Forms.ToolStripMenuItem mnuItemReplyAllEmail;
        private System.Windows.Forms.ColumnHeader hdrDate;
        private System.Windows.Forms.ColumnHeader hdrSubject;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;


    }
}
