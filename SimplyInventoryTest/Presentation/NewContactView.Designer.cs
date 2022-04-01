namespace SimplyInventoryTest.Presentation
{
    partial class NewContactView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewContactView));
            this.AddContact = new System.Windows.Forms.Button();
            this.CancelAddContact = new System.Windows.Forms.Button();
            this.EMailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EMail = new System.Windows.Forms.TextBox();
            this.ContactName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddContact
            // 
            this.AddContact.Location = new System.Drawing.Point(165, 103);
            this.AddContact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddContact.Name = "AddContact";
            this.AddContact.Size = new System.Drawing.Size(75, 23);
            this.AddContact.TabIndex = 2;
            this.AddContact.Text = "&Add";
            this.AddContact.UseVisualStyleBackColor = true;
            this.AddContact.Click += new System.EventHandler(this.AddContact_Click);
            // 
            // CancelAddContact
            // 
            this.CancelAddContact.Location = new System.Drawing.Point(246, 103);
            this.CancelAddContact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelAddContact.Name = "CancelAddContact";
            this.CancelAddContact.Size = new System.Drawing.Size(75, 23);
            this.CancelAddContact.TabIndex = 1;
            this.CancelAddContact.Text = "C&ancel";
            this.CancelAddContact.UseVisualStyleBackColor = true;
            // 
            // EMailLabel
            // 
            this.EMailLabel.AutoSize = true;
            this.EMailLabel.Location = new System.Drawing.Point(20, 60);
            this.EMailLabel.Name = "EMailLabel";
            this.EMailLabel.Size = new System.Drawing.Size(43, 15);
            this.EMailLabel.TabIndex = 3;
            this.EMailLabel.Text = "E-Mail";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(24, 31);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 15);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name";
            // 
            // EMail
            // 
            this.EMail.Location = new System.Drawing.Point(68, 57);
            this.EMail.Name = "EMail";
            this.EMail.Size = new System.Drawing.Size(253, 23);
            this.EMail.TabIndex = 7;
            // 
            // ContactName
            // 
            this.ContactName.Location = new System.Drawing.Point(68, 28);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(253, 23);
            this.ContactName.TabIndex = 8;
            this.ContactName.TextChanged += new System.EventHandler(this.ContactName_TextChanged);
            // 
            // NewContactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 148);
            this.Controls.Add(this.ContactName);
            this.Controls.Add(this.EMail);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EMailLabel);
            this.Controls.Add(this.CancelAddContact);
            this.Controls.Add(this.AddContact);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewContactView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Untitled - Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddContact;
        private System.Windows.Forms.Button CancelAddContact;
        private System.Windows.Forms.Label EMailLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox EMail;
        private System.Windows.Forms.TextBox ContactName;
    }
}