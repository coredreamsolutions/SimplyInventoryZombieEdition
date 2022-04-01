namespace SimplyInventoryTest.Presentation
{
    partial class EditSettings
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
            this.SaveSettings = new System.Windows.Forms.Button();
            this.CancelSetting = new System.Windows.Forms.Button();
            this.SMTPPortNumber = new System.Windows.Forms.TextBox();
            this.SMTPHostname = new System.Windows.Forms.TextBox();
            this.SendTo = new System.Windows.Forms.TextBox();
            this.SMTPPortNumberLabel = new System.Windows.Forms.Label();
            this.SMTPHostnameLabel = new System.Windows.Forms.Label();
            this.SMTPPasswordLabel = new System.Windows.Forms.Label();
            this.SMTPUsername = new System.Windows.Forms.TextBox();
            this.DefaultSendToLabel = new System.Windows.Forms.Label();
            this.SMTPUsernameLabel = new System.Windows.Forms.Label();
            this.SMTPPassword = new System.Windows.Forms.TextBox();
            this.ShowStoreLogo = new System.Windows.Forms.CheckBox();
            this.MailID = new System.Windows.Forms.TextBox();
            this.MailIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveSettings
            // 
            this.SaveSettings.Location = new System.Drawing.Point(332, 232);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(75, 33);
            this.SaveSettings.TabIndex = 0;
            this.SaveSettings.Text = "&Save";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // CancelSetting
            // 
            this.CancelSetting.Location = new System.Drawing.Point(251, 232);
            this.CancelSetting.Name = "CancelSetting";
            this.CancelSetting.Size = new System.Drawing.Size(75, 33);
            this.CancelSetting.TabIndex = 2;
            this.CancelSetting.Text = "C&ancel";
            this.CancelSetting.UseVisualStyleBackColor = true;
            this.CancelSetting.Click += new System.EventHandler(this.CancelSetting_Click);
            // 
            // SMTPPortNumber
            // 
            this.SMTPPortNumber.Location = new System.Drawing.Point(336, 37);
            this.SMTPPortNumber.Name = "SMTPPortNumber";
            this.SMTPPortNumber.Size = new System.Drawing.Size(71, 27);
            this.SMTPPortNumber.TabIndex = 3;
            this.SMTPPortNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SMTPHostname
            // 
            this.SMTPHostname.Location = new System.Drawing.Point(28, 37);
            this.SMTPHostname.Name = "SMTPHostname";
            this.SMTPHostname.Size = new System.Drawing.Size(298, 27);
            this.SMTPHostname.TabIndex = 4;
            // 
            // SendTo
            // 
            this.SendTo.Location = new System.Drawing.Point(28, 106);
            this.SendTo.Name = "SendTo";
            this.SendTo.Size = new System.Drawing.Size(379, 27);
            this.SendTo.TabIndex = 5;
            // 
            // SMTPPortNumberLabel
            // 
            this.SMTPPortNumberLabel.AutoSize = true;
            this.SMTPPortNumberLabel.Location = new System.Drawing.Point(332, 15);
            this.SMTPPortNumberLabel.Name = "SMTPPortNumberLabel";
            this.SMTPPortNumberLabel.Size = new System.Drawing.Size(47, 19);
            this.SMTPPortNumberLabel.TabIndex = 6;
            this.SMTPPortNumberLabel.Text = "Port #";
            // 
            // SMTPHostnameLabel
            // 
            this.SMTPHostnameLabel.AutoSize = true;
            this.SMTPHostnameLabel.Location = new System.Drawing.Point(24, 15);
            this.SMTPHostnameLabel.Name = "SMTPHostnameLabel";
            this.SMTPHostnameLabel.Size = new System.Drawing.Size(115, 19);
            this.SMTPHostnameLabel.TabIndex = 7;
            this.SMTPHostnameLabel.Text = "SMTP Hostname";
            // 
            // SMTPPasswordLabel
            // 
            this.SMTPPasswordLabel.AutoSize = true;
            this.SMTPPasswordLabel.Location = new System.Drawing.Point(217, 153);
            this.SMTPPasswordLabel.Name = "SMTPPasswordLabel";
            this.SMTPPasswordLabel.Size = new System.Drawing.Size(111, 19);
            this.SMTPPasswordLabel.TabIndex = 8;
            this.SMTPPasswordLabel.Text = "SMTP Password";
            // 
            // SMTPUsername
            // 
            this.SMTPUsername.Location = new System.Drawing.Point(28, 175);
            this.SMTPUsername.Name = "SMTPUsername";
            this.SMTPUsername.Size = new System.Drawing.Size(187, 27);
            this.SMTPUsername.TabIndex = 9;
            // 
            // DefaultSendToLabel
            // 
            this.DefaultSendToLabel.AutoSize = true;
            this.DefaultSendToLabel.Location = new System.Drawing.Point(24, 84);
            this.DefaultSendToLabel.Name = "DefaultSendToLabel";
            this.DefaultSendToLabel.Size = new System.Drawing.Size(111, 19);
            this.DefaultSendToLabel.TabIndex = 11;
            this.DefaultSendToLabel.Text = "Default Send To";
            // 
            // SMTPUsernameLabel
            // 
            this.SMTPUsernameLabel.AutoSize = true;
            this.SMTPUsernameLabel.Location = new System.Drawing.Point(24, 153);
            this.SMTPUsernameLabel.Name = "SMTPUsernameLabel";
            this.SMTPUsernameLabel.Size = new System.Drawing.Size(115, 19);
            this.SMTPUsernameLabel.TabIndex = 12;
            this.SMTPUsernameLabel.Text = "SMTP Username";
            // 
            // SMTPPassword
            // 
            this.SMTPPassword.Location = new System.Drawing.Point(221, 175);
            this.SMTPPassword.Name = "SMTPPassword";
            this.SMTPPassword.PasswordChar = '*';
            this.SMTPPassword.Size = new System.Drawing.Size(187, 27);
            this.SMTPPassword.TabIndex = 13;
            // 
            // ShowStoreLogo
            // 
            this.ShowStoreLogo.AutoSize = true;
            this.ShowStoreLogo.Location = new System.Drawing.Point(28, 232);
            this.ShowStoreLogo.Name = "ShowStoreLogo";
            this.ShowStoreLogo.Size = new System.Drawing.Size(134, 23);
            this.ShowStoreLogo.TabIndex = 14;
            this.ShowStoreLogo.Text = "Show Store Logo";
            this.ShowStoreLogo.UseVisualStyleBackColor = true;
            // 
            // MailID
            // 
            this.MailID.Location = new System.Drawing.Point(179, 232);
            this.MailID.Name = "MailID";
            this.MailID.ReadOnly = true;
            this.MailID.Size = new System.Drawing.Size(57, 27);
            this.MailID.TabIndex = 61;
            this.MailID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MailIDLabel
            // 
            this.MailIDLabel.AutoSize = true;
            this.MailIDLabel.Location = new System.Drawing.Point(175, 210);
            this.MailIDLabel.Name = "MailIDLabel";
            this.MailIDLabel.Size = new System.Drawing.Size(56, 19);
            this.MailIDLabel.TabIndex = 62;
            this.MailIDLabel.Text = "Mail ID";
            // 
            // EditSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(428, 281);
            this.Controls.Add(this.MailID);
            this.Controls.Add(this.MailIDLabel);
            this.Controls.Add(this.ShowStoreLogo);
            this.Controls.Add(this.SMTPPassword);
            this.Controls.Add(this.SMTPUsernameLabel);
            this.Controls.Add(this.DefaultSendToLabel);
            this.Controls.Add(this.SMTPUsername);
            this.Controls.Add(this.SMTPPasswordLabel);
            this.Controls.Add(this.SMTPHostnameLabel);
            this.Controls.Add(this.SMTPPortNumberLabel);
            this.Controls.Add(this.SendTo);
            this.Controls.Add(this.SMTPHostname);
            this.Controls.Add(this.SMTPPortNumber);
            this.Controls.Add(this.CancelSetting);
            this.Controls.Add(this.SaveSettings);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveSettings;
        private System.Windows.Forms.Button CancelSetting;
        private System.Windows.Forms.TextBox SMTPPortNumber;
        private System.Windows.Forms.TextBox SMTPHostname;
        private System.Windows.Forms.TextBox SendTo;
        private System.Windows.Forms.Label SMTPPortNumberLabel;
        private System.Windows.Forms.Label SMTPHostnameLabel;
        private System.Windows.Forms.Label SMTPPasswordLabel;
        private System.Windows.Forms.TextBox SMTPUsername;
        private System.Windows.Forms.Label DefaultSendToLabel;
        private System.Windows.Forms.Label SMTPUsernameLabel;
        private System.Windows.Forms.TextBox SMTPPassword;
        private System.Windows.Forms.CheckBox ShowStoreLogo;
        private System.Windows.Forms.TextBox MailID;
        private System.Windows.Forms.Label MailIDLabel;
    }
}