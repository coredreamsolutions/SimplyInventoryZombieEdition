namespace SimplyInventoryTest.Presentation
{
    partial class MailSetupView
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
            this.SendToAddressLabel = new System.Windows.Forms.Label();
            this.MailServersLabel = new System.Windows.Forms.Label();
            this.DefaultBodyLabel = new System.Windows.Forms.Label();
            this.AddressTo = new System.Windows.Forms.TextBox();
            this.DefaultMessage = new System.Windows.Forms.TextBox();
            this.MailServersDropDown = new System.Windows.Forms.ComboBox();
            this.DefaultSubjectLabel = new System.Windows.Forms.Label();
            this.DefaultSubject = new System.Windows.Forms.TextBox();
            this.SenderNameLabel = new System.Windows.Forms.Label();
            this.SenderName = new System.Windows.Forms.TextBox();
            this.SMTPPasswordLabel = new System.Windows.Forms.Label();
            this.SMTPUsernameLabel = new System.Windows.Forms.Label();
            this.STMPPortNumberLabel = new System.Windows.Forms.Label();
            this.SMTPHostnameLabel = new System.Windows.Forms.Label();
            this.SMTPPortNumber = new System.Windows.Forms.TextBox();
            this.SMTPHostname = new System.Windows.Forms.TextBox();
            this.SMTPUsername = new System.Windows.Forms.TextBox();
            this.SMTPPassword = new System.Windows.Forms.TextBox();
            this.SaveMailSetup = new System.Windows.Forms.Button();
            this.MailIDLabel = new System.Windows.Forms.Label();
            this.MailID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendToAddressLabel
            // 
            this.SendToAddressLabel.AutoSize = true;
            this.SendToAddressLabel.Location = new System.Drawing.Point(12, 396);
            this.SendToAddressLabel.Name = "SendToAddressLabel";
            this.SendToAddressLabel.Size = new System.Drawing.Size(113, 19);
            this.SendToAddressLabel.TabIndex = 48;
            this.SendToAddressLabel.Text = "Send to Address";
            // 
            // MailServersLabel
            // 
            this.MailServersLabel.AutoSize = true;
            this.MailServersLabel.Location = new System.Drawing.Point(12, 16);
            this.MailServersLabel.Name = "MailServersLabel";
            this.MailServersLabel.Size = new System.Drawing.Size(89, 19);
            this.MailServersLabel.TabIndex = 1;
            this.MailServersLabel.Text = "Mail Servers";
            // 
            // DefaultBodyLabel
            // 
            this.DefaultBodyLabel.AutoSize = true;
            this.DefaultBodyLabel.Location = new System.Drawing.Point(12, 296);
            this.DefaultBodyLabel.Name = "DefaultBodyLabel";
            this.DefaultBodyLabel.Size = new System.Drawing.Size(93, 19);
            this.DefaultBodyLabel.TabIndex = 43;
            this.DefaultBodyLabel.Text = "Default Body";
            // 
            // AddressTo
            // 
            this.AddressTo.Location = new System.Drawing.Point(15, 418);
            this.AddressTo.Name = "AddressTo";
            this.AddressTo.Size = new System.Drawing.Size(373, 27);
            this.AddressTo.TabIndex = 36;
            // 
            // DefaultMessage
            // 
            this.DefaultMessage.Location = new System.Drawing.Point(15, 318);
            this.DefaultMessage.Multiline = true;
            this.DefaultMessage.Name = "DefaultMessage";
            this.DefaultMessage.Size = new System.Drawing.Size(373, 69);
            this.DefaultMessage.TabIndex = 34;
            // 
            // MailServersDropDown
            // 
            this.MailServersDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MailServersDropDown.FormattingEnabled = true;
            this.MailServersDropDown.Items.AddRange(new object[] {
            "AOL",
            "GMail",
            "Custom"});
            this.MailServersDropDown.Location = new System.Drawing.Point(15, 38);
            this.MailServersDropDown.Name = "MailServersDropDown";
            this.MailServersDropDown.Size = new System.Drawing.Size(368, 27);
            this.MailServersDropDown.TabIndex = 25;
            this.MailServersDropDown.SelectedIndexChanged += new System.EventHandler(this.MailServersDropDown_SelectedIndexChanged);
            // 
            // DefaultSubjectLabel
            // 
            this.DefaultSubjectLabel.AutoSize = true;
            this.DefaultSubjectLabel.Location = new System.Drawing.Point(12, 200);
            this.DefaultSubjectLabel.Name = "DefaultSubjectLabel";
            this.DefaultSubjectLabel.Size = new System.Drawing.Size(108, 19);
            this.DefaultSubjectLabel.TabIndex = 42;
            this.DefaultSubjectLabel.Text = "Default Subject";
            // 
            // DefaultSubject
            // 
            this.DefaultSubject.Location = new System.Drawing.Point(16, 222);
            this.DefaultSubject.Name = "DefaultSubject";
            this.DefaultSubject.Size = new System.Drawing.Size(372, 27);
            this.DefaultSubject.TabIndex = 33;
            // 
            // SenderNameLabel
            // 
            this.SenderNameLabel.AutoSize = true;
            this.SenderNameLabel.Location = new System.Drawing.Point(12, 266);
            this.SenderNameLabel.Name = "SenderNameLabel";
            this.SenderNameLabel.Size = new System.Drawing.Size(95, 19);
            this.SenderNameLabel.TabIndex = 40;
            this.SenderNameLabel.Text = "Sender Name";
            // 
            // SenderName
            // 
            this.SenderName.Location = new System.Drawing.Point(116, 263);
            this.SenderName.Name = "SenderName";
            this.SenderName.Size = new System.Drawing.Size(272, 27);
            this.SenderName.TabIndex = 31;
            // 
            // SMTPPasswordLabel
            // 
            this.SMTPPasswordLabel.AutoSize = true;
            this.SMTPPasswordLabel.Location = new System.Drawing.Point(188, 130);
            this.SMTPPasswordLabel.Name = "SMTPPasswordLabel";
            this.SMTPPasswordLabel.Size = new System.Drawing.Size(71, 19);
            this.SMTPPasswordLabel.TabIndex = 51;
            this.SMTPPasswordLabel.Text = "Password";
            // 
            // SMTPUsernameLabel
            // 
            this.SMTPUsernameLabel.AutoSize = true;
            this.SMTPUsernameLabel.Location = new System.Drawing.Point(12, 130);
            this.SMTPUsernameLabel.Name = "SMTPUsernameLabel";
            this.SMTPUsernameLabel.Size = new System.Drawing.Size(75, 19);
            this.SMTPUsernameLabel.TabIndex = 52;
            this.SMTPUsernameLabel.Text = "Username";
            // 
            // STMPPortNumberLabel
            // 
            this.STMPPortNumberLabel.AutoSize = true;
            this.STMPPortNumberLabel.Location = new System.Drawing.Point(301, 81);
            this.STMPPortNumberLabel.Name = "STMPPortNumberLabel";
            this.STMPPortNumberLabel.Size = new System.Drawing.Size(47, 19);
            this.STMPPortNumberLabel.TabIndex = 53;
            this.STMPPortNumberLabel.Text = "Port #";
            // 
            // SMTPHostnameLabel
            // 
            this.SMTPHostnameLabel.AutoSize = true;
            this.SMTPHostnameLabel.Location = new System.Drawing.Point(10, 78);
            this.SMTPHostnameLabel.Name = "SMTPHostnameLabel";
            this.SMTPHostnameLabel.Size = new System.Drawing.Size(75, 19);
            this.SMTPHostnameLabel.TabIndex = 37;
            this.SMTPHostnameLabel.Text = "Hostname";
            // 
            // SMTPPortNumber
            // 
            this.SMTPPortNumber.Location = new System.Drawing.Point(305, 103);
            this.SMTPPortNumber.Name = "SMTPPortNumber";
            this.SMTPPortNumber.Size = new System.Drawing.Size(78, 27);
            this.SMTPPortNumber.TabIndex = 55;
            this.SMTPPortNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SMTPHostname
            // 
            this.SMTPHostname.Location = new System.Drawing.Point(15, 100);
            this.SMTPHostname.Name = "SMTPHostname";
            this.SMTPHostname.Size = new System.Drawing.Size(280, 27);
            this.SMTPHostname.TabIndex = 26;
            // 
            // SMTPUsername
            // 
            this.SMTPUsername.Location = new System.Drawing.Point(15, 152);
            this.SMTPUsername.Name = "SMTPUsername";
            this.SMTPUsername.Size = new System.Drawing.Size(172, 27);
            this.SMTPUsername.TabIndex = 57;
            // 
            // SMTPPassword
            // 
            this.SMTPPassword.Location = new System.Drawing.Point(193, 152);
            this.SMTPPassword.Name = "SMTPPassword";
            this.SMTPPassword.PasswordChar = '*';
            this.SMTPPassword.Size = new System.Drawing.Size(190, 27);
            this.SMTPPassword.TabIndex = 58;
            // 
            // SaveMailSetup
            // 
            this.SaveMailSetup.Location = new System.Drawing.Point(264, 467);
            this.SaveMailSetup.Name = "SaveMailSetup";
            this.SaveMailSetup.Size = new System.Drawing.Size(124, 57);
            this.SaveMailSetup.TabIndex = 59;
            this.SaveMailSetup.Text = "&Save && Close";
            this.SaveMailSetup.UseVisualStyleBackColor = true;
            this.SaveMailSetup.Click += new System.EventHandler(this.SaveMailSetup_Click);
            // 
            // MailIDLabel
            // 
            this.MailIDLabel.AutoSize = true;
            this.MailIDLabel.Location = new System.Drawing.Point(12, 475);
            this.MailIDLabel.Name = "MailIDLabel";
            this.MailIDLabel.Size = new System.Drawing.Size(56, 19);
            this.MailIDLabel.TabIndex = 60;
            this.MailIDLabel.Text = "Mail ID";
            // 
            // MailID
            // 
            this.MailID.Location = new System.Drawing.Point(16, 497);
            this.MailID.Name = "MailID";
            this.MailID.ReadOnly = true;
            this.MailID.Size = new System.Drawing.Size(57, 27);
            this.MailID.TabIndex = 50;
            this.MailID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MailSetupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(405, 545);
            this.Controls.Add(this.MailID);
            this.Controls.Add(this.MailIDLabel);
            this.Controls.Add(this.SaveMailSetup);
            this.Controls.Add(this.SMTPPassword);
            this.Controls.Add(this.SMTPUsername);
            this.Controls.Add(this.SMTPHostname);
            this.Controls.Add(this.SMTPPortNumber);
            this.Controls.Add(this.SMTPHostnameLabel);
            this.Controls.Add(this.STMPPortNumberLabel);
            this.Controls.Add(this.SMTPUsernameLabel);
            this.Controls.Add(this.SMTPPasswordLabel);
            this.Controls.Add(this.SenderName);
            this.Controls.Add(this.SenderNameLabel);
            this.Controls.Add(this.DefaultSubject);
            this.Controls.Add(this.DefaultSubjectLabel);
            this.Controls.Add(this.MailServersDropDown);
            this.Controls.Add(this.DefaultMessage);
            this.Controls.Add(this.AddressTo);
            this.Controls.Add(this.DefaultBodyLabel);
            this.Controls.Add(this.MailServersLabel);
            this.Controls.Add(this.SendToAddressLabel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MailSetupView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mail Server Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SendToAddressLabel;
        private System.Windows.Forms.Label MailServersLabel;
        private System.Windows.Forms.Label DefaultBodyLabel;
        private System.Windows.Forms.TextBox AddressTo;
        private System.Windows.Forms.TextBox DefaultMessage;
        private System.Windows.Forms.ComboBox MailServersDropDown;
        private System.Windows.Forms.Label DefaultSubjectLabel;
        private System.Windows.Forms.TextBox DefaultSubject;
        private System.Windows.Forms.Label SenderNameLabel;
        private System.Windows.Forms.TextBox SenderName;
        private System.Windows.Forms.Label SMTPPasswordLabel;
        private System.Windows.Forms.Label SMTPUsernameLabel;
        private System.Windows.Forms.Label STMPPortNumberLabel;
        private System.Windows.Forms.Label SMTPHostnameLabel;
        private System.Windows.Forms.TextBox SMTPPortNumber;
        private System.Windows.Forms.TextBox SMTPHostname;
        private System.Windows.Forms.TextBox SMTPUsername;
        private System.Windows.Forms.TextBox SMTPPassword;
        private System.Windows.Forms.Button SaveMailSetup;
        private System.Windows.Forms.Label MailIDLabel;
        private System.Windows.Forms.TextBox MailID;
    }
}