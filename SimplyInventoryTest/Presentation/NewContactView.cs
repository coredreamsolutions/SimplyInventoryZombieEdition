using SimplyInventoryTest.Model;
using SimplyInventoryTest.Repositories;
using SimplyInventoryTest.Validators;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimplyInventoryTest.Presentation
{
    public partial class NewContactView : Form
    {
        public Contact ActiveModel { get; set; }

        public NewContactView(Contact contact)
        {
            InitializeComponent();

            ActiveModel = contact ?? throw new ArgumentNullException("contact");
            ActiveModel = contact;

            BindModel(this.ActiveModel);

        }

        private void BindModel(Contact contact)
        {
            this.ContactName.DataBindings.Add("Text", contact, "ContactName", true, DataSourceUpdateMode.OnPropertyChanged);
            this.EMail.DataBindings.Add("Text", contact, "ContactEMail", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ContactName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddContact_Click(object sender, EventArgs e)
        {
            AddNewContact();
        }

        private void AddNewContact()
        {
            CheckResult checkResult = ContactValidator.ValidateSave(this.ActiveModel);
            if (checkResult.Failed)
            {
                MessageBox.Show(checkResult.Items[0].Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ContactRepository.SaveContact(this.ActiveModel, null);
            MessageBox.Show("Contact has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            base.Close();
            List<Contact> contacts = ContactRepository.GetContacts();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = contacts;
        }
    }
}
