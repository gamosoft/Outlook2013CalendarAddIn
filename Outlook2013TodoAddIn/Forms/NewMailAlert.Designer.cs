﻿namespace Outlook2013TodoAddIn.Forms
{
    partial class NewMailAlert
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
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFlag = new System.Windows.Forms.Button();
            this.btnEnvelope = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lnkSender = new System.Windows.Forms.LinkLabel();
            this.lnkSubject = new System.Windows.Forms.LinkLabel();
            this.comboMoveTo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBody
            // 
            this.txtBody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBody.Location = new System.Drawing.Point(88, 47);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ReadOnly = true;
            this.txtBody.Size = new System.Drawing.Size(285, 51);
            this.txtBody.TabIndex = 2;
            this.txtBody.Text = "[Email body preview...]";
            this.txtBody.Click += new System.EventHandler(this.txtBody_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Outlook2013TodoAddIn.Properties.Resources.Delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(50, 66);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFlag
            // 
            this.btnFlag.BackgroundImage = global::Outlook2013TodoAddIn.Properties.Resources.Flag;
            this.btnFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFlag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlag.Location = new System.Drawing.Point(12, 66);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(32, 32);
            this.btnFlag.TabIndex = 5;
            this.btnFlag.UseVisualStyleBackColor = true;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // btnEnvelope
            // 
            this.btnEnvelope.BackgroundImage = global::Outlook2013TodoAddIn.Properties.Resources.Envelope;
            this.btnEnvelope.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnvelope.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnvelope.Location = new System.Drawing.Point(19, 5);
            this.btnEnvelope.Name = "btnEnvelope";
            this.btnEnvelope.Size = new System.Drawing.Size(60, 60);
            this.btnEnvelope.TabIndex = 8;
            this.btnEnvelope.UseVisualStyleBackColor = true;
            this.btnEnvelope.Click += new System.EventHandler(this.btnEnvelope_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Outlook2013TodoAddIn.Properties.Resources.Delete;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(353, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lnkSender
            // 
            this.lnkSender.AutoSize = true;
            this.lnkSender.Location = new System.Drawing.Point(85, 5);
            this.lnkSender.Name = "lnkSender";
            this.lnkSender.Size = new System.Drawing.Size(75, 17);
            this.lnkSender.TabIndex = 10;
            this.lnkSender.TabStop = true;
            this.lnkSender.Text = "linkSender";
            this.lnkSender.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSender_LinkClicked);
            // 
            // lnkSubject
            // 
            this.lnkSubject.AutoSize = true;
            this.lnkSubject.Location = new System.Drawing.Point(85, 27);
            this.lnkSubject.Name = "lnkSubject";
            this.lnkSubject.Size = new System.Drawing.Size(76, 17);
            this.lnkSubject.TabIndex = 11;
            this.lnkSubject.TabStop = true;
            this.lnkSubject.Text = "linkSubject";
            this.lnkSubject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSubject_LinkClicked);
            // 
            // comboMoveTo
            // 
            this.comboMoveTo.DisplayMember = "Text";
            this.comboMoveTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMoveTo.FormattingEnabled = true;
            this.comboMoveTo.Location = new System.Drawing.Point(220, 5);
            this.comboMoveTo.Name = "comboMoveTo";
            this.comboMoveTo.Size = new System.Drawing.Size(121, 24);
            this.comboMoveTo.TabIndex = 12;
            this.comboMoveTo.ValueMember = "Value";
            this.comboMoveTo.SelectedIndexChanged += new System.EventHandler(this.comboMoveTo_SelectedIndexChanged);
            // 
            // NewMailAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 100);
            this.Controls.Add(this.comboMoveTo);
            this.Controls.Add(this.lnkSubject);
            this.Controls.Add(this.lnkSender);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEnvelope);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFlag);
            this.Controls.Add(this.txtBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewMailAlert";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NewMailAlert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Button btnFlag;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnvelope;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lnkSender;
        private System.Windows.Forms.LinkLabel lnkSubject;
        private System.Windows.Forms.ComboBox comboMoveTo;
    }
}