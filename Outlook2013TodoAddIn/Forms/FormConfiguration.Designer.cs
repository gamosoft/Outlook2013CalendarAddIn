namespace Outlook2013TodoAddIn.Forms
{
    partial class FormConfiguration
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkMailAlerts = new System.Windows.Forms.CheckBox();
            this.lblRangeDays = new System.Windows.Forms.Label();
            this.numRangeDays = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkShowPastAppointments = new System.Windows.Forms.CheckBox();
            this.chkListCalendars = new System.Windows.Forms.CheckedListBox();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.chkFriendlyGroupHeaders = new System.Windows.Forms.CheckBox();
            this.chkShowTasks = new System.Windows.Forms.CheckBox();
            this.cboFirstDayOfWeek = new System.Windows.Forms.ComboBox();
            this.lblFirstDayOfWeek = new System.Windows.Forms.Label();
            this.chkShowDayNames = new System.Windows.Forms.CheckBox();
            this.chkShowWeekNumbers = new System.Windows.Forms.CheckBox();
            this.pctBoxPayPal = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numRangeEmailAlertsTimeOut = new System.Windows.Forms.NumericUpDown();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.chkShowCompletedTasks = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRangeDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPayPal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRangeEmailAlertsTimeOut)).BeginInit();
            this.SuspendLayout();
            // 
            // chkMailAlerts
            // 
            this.chkMailAlerts.AutoSize = true;
            this.chkMailAlerts.Location = new System.Drawing.Point(45, 94);
            this.chkMailAlerts.Name = "chkMailAlerts";
            this.chkMailAlerts.Size = new System.Drawing.Size(95, 21);
            this.chkMailAlerts.TabIndex = 8;
            this.chkMailAlerts.Text = "Mail Alerts";
            this.chkMailAlerts.UseVisualStyleBackColor = true;
            // 
            // lblRangeDays
            // 
            this.lblRangeDays.AutoSize = true;
            this.lblRangeDays.Location = new System.Drawing.Point(28, 29);
            this.lblRangeDays.Name = "lblRangeDays";
            this.lblRangeDays.Size = new System.Drawing.Size(44, 17);
            this.lblRangeDays.TabIndex = 7;
            this.lblRangeDays.Text = "Days:";
            // 
            // numRangeDays
            // 
            this.numRangeDays.Location = new System.Drawing.Point(78, 27);
            this.numRangeDays.Maximum = new decimal(new int[] {
            30,
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
            this.numRangeDays.TabIndex = 6;
            this.numRangeDays.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(168, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 37);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(26, 432);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 37);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkShowPastAppointments
            // 
            this.chkShowPastAppointments.AutoSize = true;
            this.chkShowPastAppointments.Location = new System.Drawing.Point(45, 67);
            this.chkShowPastAppointments.Name = "chkShowPastAppointments";
            this.chkShowPastAppointments.Size = new System.Drawing.Size(186, 21);
            this.chkShowPastAppointments.TabIndex = 12;
            this.chkShowPastAppointments.Text = "Show Past Appointments";
            this.chkShowPastAppointments.UseVisualStyleBackColor = true;
            // 
            // chkListCalendars
            // 
            this.chkListCalendars.FormattingEnabled = true;
            this.chkListCalendars.Location = new System.Drawing.Point(26, 317);
            this.chkListCalendars.Name = "chkListCalendars";
            this.chkListCalendars.Size = new System.Drawing.Size(229, 106);
            this.chkListCalendars.TabIndex = 13;
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.Location = new System.Drawing.Point(23, 297);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(70, 17);
            this.lblAccounts.TabIndex = 14;
            this.lblAccounts.Text = "Accounts:";
            // 
            // chkFriendlyGroupHeaders
            // 
            this.chkFriendlyGroupHeaders.AutoSize = true;
            this.chkFriendlyGroupHeaders.Location = new System.Drawing.Point(45, 121);
            this.chkFriendlyGroupHeaders.Name = "chkFriendlyGroupHeaders";
            this.chkFriendlyGroupHeaders.Size = new System.Drawing.Size(176, 21);
            this.chkFriendlyGroupHeaders.TabIndex = 15;
            this.chkFriendlyGroupHeaders.Text = "Show Friendly Headers";
            this.chkFriendlyGroupHeaders.UseVisualStyleBackColor = true;
            // 
            // chkShowTasks
            // 
            this.chkShowTasks.AutoSize = true;
            this.chkShowTasks.Location = new System.Drawing.Point(45, 206);
            this.chkShowTasks.Name = "chkShowTasks";
            this.chkShowTasks.Size = new System.Drawing.Size(106, 21);
            this.chkShowTasks.TabIndex = 16;
            this.chkShowTasks.Text = "Show Tasks";
            this.chkShowTasks.UseVisualStyleBackColor = true;
            // 
            // cboFirstDayOfWeek
            // 
            this.cboFirstDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFirstDayOfWeek.FormattingEnabled = true;
            this.cboFirstDayOfWeek.Location = new System.Drawing.Point(45, 259);
            this.cboFirstDayOfWeek.Name = "cboFirstDayOfWeek";
            this.cboFirstDayOfWeek.Size = new System.Drawing.Size(186, 24);
            this.cboFirstDayOfWeek.TabIndex = 17;
            // 
            // lblFirstDayOfWeek
            // 
            this.lblFirstDayOfWeek.AutoSize = true;
            this.lblFirstDayOfWeek.Location = new System.Drawing.Point(42, 239);
            this.lblFirstDayOfWeek.Name = "lblFirstDayOfWeek";
            this.lblFirstDayOfWeek.Size = new System.Drawing.Size(124, 17);
            this.lblFirstDayOfWeek.TabIndex = 18;
            this.lblFirstDayOfWeek.Text = "First Day of Week:";
            // 
            // chkShowDayNames
            // 
            this.chkShowDayNames.AutoSize = true;
            this.chkShowDayNames.Location = new System.Drawing.Point(45, 150);
            this.chkShowDayNames.Name = "chkShowDayNames";
            this.chkShowDayNames.Size = new System.Drawing.Size(141, 21);
            this.chkShowDayNames.TabIndex = 19;
            this.chkShowDayNames.Text = "Show Day Names";
            this.chkShowDayNames.UseVisualStyleBackColor = true;
            // 
            // chkShowWeekNumbers
            // 
            this.chkShowWeekNumbers.AutoSize = true;
            this.chkShowWeekNumbers.Location = new System.Drawing.Point(45, 178);
            this.chkShowWeekNumbers.Name = "chkShowWeekNumbers";
            this.chkShowWeekNumbers.Size = new System.Drawing.Size(165, 21);
            this.chkShowWeekNumbers.TabIndex = 20;
            this.chkShowWeekNumbers.Text = "Show Week Numbers";
            this.chkShowWeekNumbers.UseVisualStyleBackColor = true;
            // 
            // pctBoxPayPal
            // 
            this.pctBoxPayPal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctBoxPayPal.Image = global::Outlook2013TodoAddIn.Properties.Resources.buy_me_a_beer_small;
            this.pctBoxPayPal.Location = new System.Drawing.Point(152, 23);
            this.pctBoxPayPal.Name = "pctBoxPayPal";
            this.pctBoxPayPal.Size = new System.Drawing.Size(83, 30);
            this.pctBoxPayPal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctBoxPayPal.TabIndex = 21;
            this.pctBoxPayPal.TabStop = false;
            this.toolTip1.SetToolTip(this.pctBoxPayPal, "If you find it useful and have spare time you can drop me a line saying how you l" +
        "ike the tool and such, or better yet, you can buy me a beer if you wish. ;-) ");
            this.pctBoxPayPal.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // numRangeEmailAlertsTimeOut
            // 
            this.numRangeEmailAlertsTimeOut.Location = new System.Drawing.Point(138, 93);
            this.numRangeEmailAlertsTimeOut.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRangeEmailAlertsTimeOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRangeEmailAlertsTimeOut.Name = "numRangeEmailAlertsTimeOut";
            this.numRangeEmailAlertsTimeOut.Size = new System.Drawing.Size(44, 22);
            this.numRangeEmailAlertsTimeOut.TabIndex = 22;
            this.numRangeEmailAlertsTimeOut.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(186, 95);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(61, 17);
            this.lblSeconds.TabIndex = 23;
            this.lblSeconds.Text = "seconds";
            // 
            // chkShowCompletedTasks
            // 
            this.chkShowCompletedTasks.AutoSize = true;
            this.chkShowCompletedTasks.Location = new System.Drawing.Point(157, 206);
            this.chkShowCompletedTasks.Name = "chkShowCompletedTasks";
            this.chkShowCompletedTasks.Size = new System.Drawing.Size(105, 21);
            this.chkShowCompletedTasks.TabIndex = 24;
            this.chkShowCompletedTasks.Text = "Completed?";
            this.chkShowCompletedTasks.UseVisualStyleBackColor = true;
            // 
            // FormConfiguration
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(282, 482);
            this.Controls.Add(this.chkShowCompletedTasks);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.numRangeEmailAlertsTimeOut);
            this.Controls.Add(this.pctBoxPayPal);
            this.Controls.Add(this.chkShowWeekNumbers);
            this.Controls.Add(this.chkShowDayNames);
            this.Controls.Add(this.lblFirstDayOfWeek);
            this.Controls.Add(this.cboFirstDayOfWeek);
            this.Controls.Add(this.chkShowTasks);
            this.Controls.Add(this.chkFriendlyGroupHeaders);
            this.Controls.Add(this.lblAccounts);
            this.Controls.Add(this.chkListCalendars);
            this.Controls.Add(this.chkShowPastAppointments);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkMailAlerts);
            this.Controls.Add(this.lblRangeDays);
            this.Controls.Add(this.numRangeDays);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfiguration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.FormConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRangeDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPayPal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRangeEmailAlertsTimeOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMailAlerts;
        private System.Windows.Forms.Label lblRangeDays;
        private System.Windows.Forms.NumericUpDown numRangeDays;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkShowPastAppointments;
        private System.Windows.Forms.CheckedListBox chkListCalendars;
        private System.Windows.Forms.Label lblAccounts;
        private System.Windows.Forms.CheckBox chkFriendlyGroupHeaders;
        private System.Windows.Forms.CheckBox chkShowTasks;
        private System.Windows.Forms.ComboBox cboFirstDayOfWeek;
        private System.Windows.Forms.Label lblFirstDayOfWeek;
        private System.Windows.Forms.CheckBox chkShowDayNames;
        private System.Windows.Forms.CheckBox chkShowWeekNumbers;
        private System.Windows.Forms.PictureBox pctBoxPayPal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numRangeEmailAlertsTimeOut;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.CheckBox chkShowCompletedTasks;
    }
}