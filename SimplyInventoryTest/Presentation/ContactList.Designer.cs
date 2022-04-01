namespace SimplyInventoryTest.Presentation
{
    partial class ContactList
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
            this.ContactsView = new System.Windows.Forms.DataGridView();
            this.SelectedTo = new System.Windows.Forms.TextBox();
            this.rcContactList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddTo = new System.Windows.Forms.Button();
            this.AddCc = new System.Windows.Forms.Button();
            this.SelectedCc = new System.Windows.Forms.TextBox();
            this.OkAdd = new System.Windows.Forms.Button();
            this.CancelAdd = new System.Windows.Forms.Button();
            this.deleteContact = new System.Windows.Forms.ToolStripMenuItem();
            this.newContact = new System.Windows.Forms.ToolStripMenuItem();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactEMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsView)).BeginInit();
            this.rcContactList.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactsView
            // 
            this.ContactsView.AllowUserToAddRows = false;
            this.ContactsView.AllowUserToDeleteRows = false;
            this.ContactsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactName,
            this.ContactEMail});
            this.ContactsView.ContextMenuStrip = this.rcContactList;
            this.ContactsView.Location = new System.Drawing.Point(13, 13);
            this.ContactsView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContactsView.MultiSelect = false;
            this.ContactsView.Name = "ContactsView";
            this.ContactsView.ReadOnly = true;
            this.ContactsView.RowHeadersVisible = false;
            this.ContactsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ContactsView.Size = new System.Drawing.Size(571, 262);
            this.ContactsView.TabIndex = 7;
            this.ContactsView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContactsView_CellContentDoubleClick);
            // 
            // SelectedTo
            // 
            this.SelectedTo.Location = new System.Drawing.Point(85, 281);
            this.SelectedTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectedTo.Name = "SelectedTo";
            this.SelectedTo.Size = new System.Drawing.Size(499, 27);
            this.SelectedTo.TabIndex = 1;
            // 
            // rcContactList
            // 
            this.rcContactList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteContact,
            this.newContact});
            this.rcContactList.Name = "rcContactList";
            this.rcContactList.Size = new System.Drawing.Size(129, 48);
            // 
            // AddTo
            // 
            this.AddTo.Location = new System.Drawing.Point(13, 281);
            this.AddTo.Name = "AddTo";
            this.AddTo.Size = new System.Drawing.Size(65, 26);
            this.AddTo.TabIndex = 2;
            this.AddTo.Text = "To ->";
            this.AddTo.UseVisualStyleBackColor = true;
            // 
            // AddCc
            // 
            this.AddCc.Location = new System.Drawing.Point(13, 314);
            this.AddCc.Name = "AddCc";
            this.AddCc.Size = new System.Drawing.Size(65, 26);
            this.AddCc.TabIndex = 4;
            this.AddCc.Text = "Cc ->";
            this.AddCc.UseVisualStyleBackColor = true;
            // 
            // SelectedCc
            // 
            this.SelectedCc.Location = new System.Drawing.Point(85, 313);
            this.SelectedCc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectedCc.Name = "SelectedCc";
            this.SelectedCc.Size = new System.Drawing.Size(500, 27);
            this.SelectedCc.TabIndex = 3;
            // 
            // OkAdd
            // 
            this.OkAdd.Location = new System.Drawing.Point(428, 345);
            this.OkAdd.Name = "OkAdd";
            this.OkAdd.Size = new System.Drawing.Size(75, 32);
            this.OkAdd.TabIndex = 5;
            this.OkAdd.Text = "&OK";
            this.OkAdd.UseVisualStyleBackColor = true;
            // 
            // CancelAdd
            // 
            this.CancelAdd.Location = new System.Drawing.Point(509, 345);
            this.CancelAdd.Name = "CancelAdd";
            this.CancelAdd.Size = new System.Drawing.Size(75, 32);
            this.CancelAdd.TabIndex = 6;
            this.CancelAdd.Text = "C&ancel";
            this.CancelAdd.UseVisualStyleBackColor = true;
            // 
            // deleteContact
            // 
            this.deleteContact.Name = "deleteContact";
            this.deleteContact.Size = new System.Drawing.Size(128, 22);
            this.deleteContact.Text = "Delete";
            // 
            // newContact
            // 
            this.newContact.Name = "newContact";
            this.newContact.Size = new System.Drawing.Size(128, 22);
            this.newContact.Text = "New Entry";
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "ContactName";
            this.ContactName.HeaderText = "Name";
            this.ContactName.Name = "ContactName";
            this.ContactName.ReadOnly = true;
            this.ContactName.Width = 150;
            // 
            // ContactEMail
            // 
            this.ContactEMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ContactEMail.DataPropertyName = "ContactEMail";
            this.ContactEMail.HeaderText = "E-Mail Address";
            this.ContactEMail.Name = "ContactEMail";
            this.ContactEMail.ReadOnly = true;
            this.ContactEMail.Width = 132;
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(597, 392);
            this.Controls.Add(this.CancelAdd);
            this.Controls.Add(this.OkAdd);
            this.Controls.Add(this.SelectedCc);
            this.Controls.Add(this.AddCc);
            this.Controls.Add(this.AddTo);
            this.Controls.Add(this.SelectedTo);
            this.Controls.Add(this.ContactsView);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactList";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact List";
            ((System.ComponentModel.ISupportInitialize)(this.ContactsView)).EndInit();
            this.rcContactList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ContactsView;
        private System.Windows.Forms.Button AddContact;
        private System.Windows.Forms.TextBox SelectedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactEMail;
        private System.Windows.Forms.ContextMenuStrip rcContactList;
        private System.Windows.Forms.ToolStripMenuItem deleteContact;
        private System.Windows.Forms.ToolStripMenuItem newContact;
        private System.Windows.Forms.Button AddTo;
        private System.Windows.Forms.Button AddCc;
        private System.Windows.Forms.TextBox SelectedCc;
        private System.Windows.Forms.Button OkAdd;
        private System.Windows.Forms.Button CancelAdd;
    }
}