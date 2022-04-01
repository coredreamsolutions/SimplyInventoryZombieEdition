using SimplyInventoryTest.Model;
using SimplyInventoryTest.Validators;
using System.Windows.Forms;
using SimplyInventoryTest.Core;
using System;
using SimplyInventoryTest.Repositories;

namespace SimplyInventoryTest.Presentation
{
    public partial class MailSetupView : Form
    {
        public Mail ActiveModel { get; set; }

        public MailSetupView(Mail mail)
        {
            InitializeComponent();

            ActiveModel = mail ?? throw new ArgumentNullException("mail");
            ActiveModel = mail;

            BindModel(ActiveModel);
        }

        private void MailServersDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mailServer = MailServersDropDown.SelectedItem.ToString();
            
            PopulateCommonSettings(mailServer);
        }

        private void BindModel(Mail mail)
        {     
            MailID.DataBindings.Add("Text", mail, "MailID", true, DataSourceUpdateMode.OnPropertyChanged);
            SMTPUsername.DataBindings.Add("Text", mail, "SMTPUsername", true, DataSourceUpdateMode.OnPropertyChanged);
            SMTPPassword.DataBindings.Add("Text", mail, "SMTPPassword", true, DataSourceUpdateMode.OnPropertyChanged);
            SMTPHostname.DataBindings.Add("Text", mail, "SMTPHostname", true, DataSourceUpdateMode.OnPropertyChanged);
            SMTPPortNumber.DataBindings.Add("Text", mail, "SMTPPortNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            SenderName.DataBindings.Add("Text", mail, "SenderName", true, DataSourceUpdateMode.OnPropertyChanged);
            AddressTo.DataBindings.Add("Text", mail, "AddressTo", true, DataSourceUpdateMode.OnPropertyChanged);
            DefaultSubject.DataBindings.Add("Text", mail, "DefaultSubject", true, DataSourceUpdateMode.OnPropertyChanged);
            DefaultMessage.DataBindings.Add("Text", mail, "DefaultMessage", true, DataSourceUpdateMode.OnPropertyChanged);      
        }

        private void PopulateCommonSettings(string mailServer)
        {
            switch (mailServer)
            {
                case "AOL":
                    SMTPHostname.Text = "stmp.aol.com";
                    SMTPUsername.Text = "<account email>";
                    SMTPPortNumber.Text = "587";
                    break;
                case "GMail":
                    SMTPHostname.Text = "stmp.gmail.com";
                    SMTPUsername.Text = "<account email>";
                    SMTPPortNumber.Text = "587";
                    break;
                case "Namecheap Hosting":
                    SMTPUsername.Text = "<mailbox email>";
                    SMTPHostname.Text = "<your domain>";
                    SMTPPortNumber.Text = "465";
                    break;
                default:
                    break;
            }     
        }

        private void SaveMailSetup_Click(object sender, EventArgs e)
        {
            SaveMailSetupToDatabase();
        }

        private void SaveMailSetupToDatabase()
        {
            CheckResult checkResult = MailValidator.ValidateSave(ActiveModel);
            if (checkResult.Failed)
            {
                MessageBox.Show(checkResult.Items[0].Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MailRepository.SaveMail(ActiveModel, null);
            MessageBox.Show("Mail setup has been completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }
    }
}
