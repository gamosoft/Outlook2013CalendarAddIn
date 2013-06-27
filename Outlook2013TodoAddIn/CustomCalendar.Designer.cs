namespace Outlook2013TodoAddIn
{
    partial class CustomCalendar
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lnkCurrentRange = new System.Windows.Forms.LinkLabel();
            this.lnkToday = new System.Windows.Forms.LinkLabel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.toolTipCalendar = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(9, 7);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(31, 23);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "<";
            this.toolTipCalendar.SetToolTip(this.btnPrevious, "Previous month");
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(213, 7);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(31, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.toolTipCalendar.SetToolTip(this.btnNext, "Next month");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 34);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 161);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lnkCurrentRange
            // 
            this.lnkCurrentRange.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkCurrentRange.Location = new System.Drawing.Point(47, 7);
            this.lnkCurrentRange.Name = "lnkCurrentRange";
            this.lnkCurrentRange.Size = new System.Drawing.Size(159, 23);
            this.lnkCurrentRange.TabIndex = 0;
            this.lnkCurrentRange.TabStop = true;
            this.lnkCurrentRange.Text = "lnkCurrentRange";
            this.lnkCurrentRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkToday
            // 
            this.lnkToday.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkToday.Location = new System.Drawing.Point(40, 196);
            this.lnkToday.Name = "lnkToday";
            this.lnkToday.Size = new System.Drawing.Size(166, 23);
            this.lnkToday.TabIndex = 4;
            this.lnkToday.TabStop = true;
            this.lnkToday.Text = "lnkToday";
            this.lnkToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipCalendar.SetToolTip(this.lnkToday, "Refresh today\'s appointments");
            this.lnkToday.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkToday_LinkClicked);
            // 
            // btnConfig
            // 
            this.btnConfig.BackgroundImage = global::Outlook2013TodoAddIn.Properties.Resources.gear;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Location = new System.Drawing.Point(219, 198);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(24, 24);
            this.btnConfig.TabIndex = 5;
            this.toolTipCalendar.SetToolTip(this.btnConfig, "Configuration");
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // CustomCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.lnkToday);
            this.Controls.Add(this.lnkCurrentRange);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomCalendar";
            this.Size = new System.Drawing.Size(256, 228);
            this.Load += new System.EventHandler(this.CustomCalendar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel lnkCurrentRange;
        private System.Windows.Forms.LinkLabel lnkToday;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.ToolTip toolTipCalendar;
    }
}
