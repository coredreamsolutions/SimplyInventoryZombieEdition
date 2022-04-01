using SimplyInventoryTest.Model;
using SimplyInventoryTest.Repositories;
using System;
using System.Windows.Forms;

namespace SimplyInventoryTest.Presentation
{
    public partial class EditSettings : Form
    {
        public Mail ActiveModel { get; set; }
        public Setting SettingModel { get; set; }
        public EditSettings(Mail mail, Setting setting)
        {
            InitializeComponent();

            ActiveModel = mail ?? throw new ArgumentNullException("mail");      
            SettingModel = setting ?? throw new ArgumentNullException("setting");
            
            this.ActiveModel = mail;
            this.SettingModel = setting;

            BindModel(ActiveModel, SettingModel);
        }

        private void BindModel(Mail mail, Setting setting)
        {
            this.MailID.DataBindings.Add("Text", mail, "MailID", true, DataSourceUpdateMode.OnPropertyChanged);
            this.SMTPHostname.DataBindings.Add("Text", mail, "SMTPHostname", true, DataSourceUpdateMode.OnPropertyChanged);
            this.SMTPPortNumber.DataBindings.Add("Text", mail, "SMTPPortNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            this.SMTPUsername.DataBindings.Add("Text", mail, "SMTPUsername", true, DataSourceUpdateMode.OnPropertyChanged);
            this.SMTPPassword.DataBindings.Add("Text", mail, "SMTPPassword", true, DataSourceUpdateMode.OnPropertyChanged);
            this.SendTo.DataBindings.Add("Text", mail, "AddressTo", true, DataSourceUpdateMode.OnPropertyChanged);
            this.ShowStoreLogo.DataBindings.Add("CheckState", setting, "ShowStoreLogo", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            MailRepository.SaveMail(this.ActiveModel, null);
            SettingRepository.UpdateSettings(this.SettingModel, null);
            MessageBox.Show("Mail and General Settings have been updated.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }

        private void CancelSetting_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
