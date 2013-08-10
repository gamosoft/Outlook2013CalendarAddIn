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
            ((System.ComponentModel.ISupportInitialize)(this.numRangeDays)).BeginInit();
            this.SuspendLayout();
            // 
            // chkMailAlerts
            // 
            this.chkMailAlerts.AutoSize = true;
            this.chkMailAlerts.Location = new System.Drawing.Point(45, 94);
            this.chkMailAlerts.Name = "chkMailAlerts";
            this.chkMailAlerts.Size = new System.Drawing.Size(143, 21);
            this.chkMailAlerts.TabIndex = 8;
            this.chkMailAlerts.Text = "Enable Mail Alerts";
            this.chkMailAlerts.UseVisualStyleBackColor = true;
            // 
            // lblRangeDays
            // 
            this.lblRangeDays.AutoSize = true;
            this.lblRangeDays.Location = new System.Drawing.Point(55, 29);
            this.lblRangeDays.Name = "lblRangeDays";
            this.lblRangeDays.Size = new System.Drawing.Size(44, 17);
            this.lblRangeDays.TabIndex = 7;
            this.lblRangeDays.Text = "Days:";
            // 
            // numRangeDays
            // 
            this.numRangeDays.Location = new System.Drawing.Point(115, 27);
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
            this.btnCancel.Location = new System.Drawing.Point(168, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 37);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(26, 374);
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
            this.chkListCalendars.Location = new System.Drawing.Point(26, 259);
            this.chkListCalendars.Name = "chkListCalendars";
            this.chkListCalendars.Size = new System.Drawing.Size(229, 106);
            this.chkListCalendars.TabIndex = 13;
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.Location = new System.Drawing.Point(23, 239);
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
            this.chkShowTasks.Location = new System.Drawing.Point(45, 148);
            this.chkShowTasks.Name = "chkShowTasks";
            this.chkShowTasks.Size = new System.Drawing.Size(106, 21);
            this.chkShowTasks.TabIndex = 16;
            this.chkShowTasks.Text = "Show Tasks";
            this.chkShowTasks.UseVisualStyleBackColor = true;
            this.chkShowTasks.Visible = false;
            // 
            // cboFirstDayOfWeek
            // 
            this.cboFirstDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFirstDayOfWeek.FormattingEnabled = true;
            this.cboFirstDayOfWeek.Location = new System.Drawing.Point(45, 201);
            this.cboFirstDayOfWeek.Name = "cboFirstDayOfWeek";
            this.cboFirstDayOfWeek.Size = new System.Drawing.Size(186, 24);
            this.cboFirstDayOfWeek.TabIndex = 17;
            // 
            // lblFirstDayOfWeek
            // 
            this.lblFirstDayOfWeek.AutoSize = true;
            this.lblFirstDayOfWeek.Location = new System.Drawing.Point(42, 181);
            this.lblFirstDayOfWeek.Name = "lblFirstDayOfWeek";
            this.lblFirstDayOfWeek.Size = new System.Drawing.Size(124, 17);
            this.lblFirstDayOfWeek.TabIndex = 18;
            this.lblFirstDayOfWeek.Text = "First Day of Week:";
            // 
            // FormConfiguration
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(282, 452);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfiguration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.FormConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRangeDays)).EndInit();
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
    }
}