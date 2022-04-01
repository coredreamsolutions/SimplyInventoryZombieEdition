using SimplyInventoryTest.Model;
using SimplyInventoryTest.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyInventoryTest.Presentation
{
    public partial class ContactList : Form
    {
        public Contacts Contacts { get; set; }
        public Contact Contact { get; set; }

        public ContactList()
        {
            InitializeComponent();

            ConfigureGrid();
            BindModel(Contacts);
        }

        public void UpdateDataSet()
        {
            List<Contact> contacts = ContactRepository.GetContacts();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = contacts;
            this.ContactsView.DataSource = bindingSource;
            this.BindModel(this.Contacts);
        }
        private void ConfigureGrid()
        {
            ContactsView.AutoGenerateColumns = false;
            ContactsView.RowHeadersVisible = false;
            ContactsView.Columns[0].Visible = true;
        }

        private void AddContact_Click(object sender, EventArgs e)
        {
            AddContactToDatabase();
        }
        private void BindModel(Contacts contact)
        {
            SelectedTo.DataBindings.Add("Text", contact, "ContactEmail", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        public void AddContactToDatabase()
        {
            Contact contact = new Contact();
            using (NewContactView newContact = new NewContactView(contact))
            {
                newContact.ShowDialog();
            }
        }

        private void ContactsView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ContactsView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                TextBox selectedTo = this.SelectedTo;
                selectedTo.Text = selectedTo.Text + this.ContactsView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + ", ";
            }
        }
    }
}
