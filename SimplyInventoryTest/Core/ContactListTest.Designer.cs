namespace SimplyInventoryTest.Core
{
    partial class ContactListTest
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
            this.CloseContacts = new System.Windows.Forms.Button();
            this.ContactsView = new System.Windows.Forms.ListView();
            this.headName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CloseContacts
            // 
            this.CloseContacts.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CloseContacts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseContacts.Location = new System.Drawing.Point(549, 238);
            this.CloseContacts.Name = "CloseContacts";
            this.CloseContacts.Size = new System.Drawing.Size(107, 43);
            this.CloseContacts.TabIndex = 3;
            this.CloseContacts.Text = "&Close";
            this.CloseContacts.UseVisualStyleBackColor = true;
            // 
            // ContactsView
            // 
            this.ContactsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headName,
            this.headEmail});
            this.ContactsView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactsView.HideSelection = false;
            this.ContactsView.Location = new System.Drawing.Point(12, 12);
            this.ContactsView.Name = "ContactsView";
            this.ContactsView.Size = new System.Drawing.Size(644, 220);
            this.ContactsView.TabIndex = 2;
            this.ContactsView.UseCompatibleStateImageBehavior = false;
            this.ContactsView.View = System.Windows.Forms.View.Details;
            // 
            // headName
            // 
            this.headName.Text = "Name";
            this.headName.Width = 150;
            // 
            // headEmail
            // 
            this.headEmail.Text = "E-Mail";
            this.headEmail.Width = 250;
            // 
            // ContactListTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(673, 298);
            this.Controls.Add(this.ContactsView);
            this.Controls.Add(this.CloseContacts);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactListTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseContacts;
        private System.Windows.Forms.ListView ContactsView;
        private System.Windows.Forms.ColumnHeader headName;
        private System.Windows.Forms.ColumnHeader headEmail;
    }
}