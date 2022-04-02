using OfficeOpenXml;
using OfficeOpenXml.Style;
using SimplyInventoryTest.Model;
using SimplyInventoryTest.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace SimplyInventoryTest.Presentation
{
    public partial class MainApp : Form
    {
        public Inventory Inventory { get; private set; }
        public static bool mailSent;
        public MainApp()
        {
            InitializeComponent();

            CheckBranding();
            CheckMailSettings();
            ConfigureGrid();
            UpdateDataGrid();
        }

        private void NewInventoryItem_MouseHover(object sender, EventArgs e)
        {
         //   NewInventoryItem.BackColor = Color.Chartreuse;
        }

        private void SendInventory_MouseHover(object sender, EventArgs e)
        {
        //    SendInventory.BackColor = Color.Chartreuse;
        }

        private void ManualMailer_MouseHover(object sender, EventArgs e)
        {
        //    ManualMailer.BackColor = Color.Chartreuse;
        }

        private void ClearQuery_MouseHover(object sender, EventArgs e)
        {
          //  ClearQuery.BackColor = Color.Chartreuse;
        }

        private void Search_MouseHover(object sender, EventArgs e)
        {
          //  Search.BackColor = Color.Chartreuse;
        }

        private void CheckBranding()
        {
            Setting settings = SettingRepository.GetSettings();

            if (settings.ShowStoreLogo)
            {
                AppLogo.Visible = false;
            //    StoreLogo.Visible = true;
            } 
            else
            {
                AppLogo.Visible = true;
             //   StoreLogo.Visible = false;
            }
        }

        private void CheckMailSettings()
        {
            long rowCount = MailRepository.CountRows();

            if (rowCount == 0)
            {
                Mail mail = new Mail();
                using (MailSetupView mailSetup = new MailSetupView(mail))
                {
                    mailSetup.ShowDialog();
                    return;
                }
            }
        }

        private void UpdateDataGrid()
        {
            List<Inventory> allInventory = InventoryRepository.GetAllInventory();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = allInventory;
            InventoryGrid.DataSource = bindingSource;
        }

        private void ConfigureGrid()
        {
            InventoryGrid.AutoGenerateColumns = false;
            InventoryGrid.RowHeadersVisible = false;
            InventoryGrid.Columns[0].Visible = true;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchForData();
        }

        private void SearchForData()
        {
            //List<Inventory> dataSource = InventoryRepository.SearchInventory(SearchCategory.Text, SearchItem.Text);
            List<Inventory> dataSource = InventoryRepository.SearchInventory(SearchData.Text);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataSource;
            InventoryGrid.DataSource = dataSource;
        }

        private void ClearQuery_Click(object sender, EventArgs e)
        {
            SearchData.Clear();
            List<Inventory> dataSource = InventoryRepository.SearchInventory(SearchData.Text);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataSource;
            InventoryGrid.DataSource = dataSource;
        }

        private void ManualMailer_Click(object sender, EventArgs e)
        {
      //      using (Mailer mailer = new Mailer())
       //     {
       //         mailer.ShowDialog();
       //     }
        }

        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            ((SmtpClient)sender).Dispose();
            string caption = (string)e.UserState;
            if (e.Cancelled)
            {
                MessageBox.Show("E-Mail sending was cancelled.", caption);
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
            }
            else
            {
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Invlist.xlsx"))
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "Invlist.xlsx");
                }
                MessageBox.Show("E-Mail has been sent.", "Response", MessageBoxButtons.OK);
                List<Inventory> dataSource = InventoryRepository.SearchInventory(SearchData.Text);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataSource;
                this.InventoryGrid.DataSource = dataSource;
            }
            MainApp.mailSent = true;
        }

        private void SendInventory_Click(object sender, EventArgs e)
        {
            Mail enabledMailSetting = MailRepository.GetEnabledMailSetting();
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Invlist.xlsx");
            File.Delete(path);
            using (FileStream fileStream = File.Create(path))
            {
                using (ExcelPackage excelPackage = new ExcelPackage(fileStream))
                {
                    ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets.Add("Inventory List");
                    for (int i = 1; i < this.InventoryGrid.Columns.Count + 1; i++)
                    {
                        excelWorksheet.Cells[1, i].Value = this.InventoryGrid.Columns[i - 1].HeaderText;
                    }
                    for (int j = 0; j < this.InventoryGrid.Rows.Count - 1; j++)
                    {
                        for (int k = 0; k < this.InventoryGrid.Columns.Count; k++)
                        {
                            excelWorksheet.Cells[j + 2, k + 1].Value = this.InventoryGrid.Rows[j].Cells[k].Value.ToString();
                        }
                    }
                    using (ExcelRange excelRange = excelWorksheet.Cells[1, 1, 1, 6])
                    {
                        excelRange.Style.Font.Bold = true;
                        excelRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        excelRange.Style.Fill.BackgroundColor.SetColor(Color.DarkBlue);
                        excelRange.Style.Font.Color.SetColor(Color.White);
                    }
                    excelWorksheet.Cells.AutoFitColumns(0.0);
                    excelWorksheet.HeaderFooter.OddHeader.CenteredText = "&24&U&\"Arial,Regular Bold\" Inventory";
                    excelWorksheet.HeaderFooter.OddFooter.RightAlignedText = string.Format("Page {0} of {1}", "&P", "&N");
                    excelWorksheet.HeaderFooter.OddFooter.CenteredText = "&A";
                    excelPackage.Workbook.Properties.Title = "Invertory List - Go Daddy";
                    excelPackage.Workbook.Properties.Author = "CulinArt, Inc.";
                    excelPackage.Save();
                    excelPackage.Dispose();
                    fileStream.Close();
                }
            }
            string smtpHostname = enabledMailSetting.SMTPHostname;
            int smtpPortNumber = Convert.ToInt32(enabledMailSetting.SMTPPortNumber);
            try
            {
                SmtpClient smtpClient = new SmtpClient(smtpHostname, smtpPortNumber);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                string smtpUsername = enabledMailSetting.SMTPUsername;
                string smtpPassword = enabledMailSetting.SMTPPassword;
                string senderName = enabledMailSetting.SenderName;
                string addressTo = enabledMailSetting.AddressTo;
                string defaultSubject = enabledMailSetting.DefaultSubject;
                string defaultMessage = enabledMailSetting.DefaultMessage;
                MailMessage msg = new MailMessage();
                new MailAddress(addressTo, senderName);
                msg.From = new MailAddress(smtpUsername, senderName);
                msg.To.Add(addressTo);
                msg.Body = defaultMessage;
                msg.Subject = defaultSubject;
                msg.SubjectEncoding = Encoding.UTF8;
                msg.Attachments.Add(new Attachment(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "InvList.xlsx")));
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword, "");
                smtpClient.Timeout = 300000;
                smtpClient.SendCompleted += delegate (object s, AsyncCompletedEventArgs tuna)
                {
                    msg.Dispose();
                    this.SendCompletedCallback(s, tuna);
                };
                smtpClient.SendAsync(msg, "emailsend");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InventoryGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn dataGridViewColumn = this.InventoryGrid.Columns[e.ColumnIndex];
            DataGridViewColumn sortedColumn = this.InventoryGrid.SortedColumn;
            string headerText;
            if ((headerText = dataGridViewColumn.HeaderText) != null)
            {
                if (headerText == "Category")
                {
                    List<Inventory> allInventory = InventoryRepository.GetAllInventory();
                    dataGridViewColumn.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = allInventory;
                    this.InventoryGrid.DataSource = bindingSource;
                    return;
                }
                if (!(headerText == "Item"))
                {
                    return;
                }
                List<Inventory> allInventoryByDescription = InventoryRepository.GetAllInventoryByDescription();
                dataGridViewColumn.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                BindingSource bindingSource2 = new BindingSource();
                bindingSource2.DataSource = allInventoryByDescription;
                InventoryGrid.DataSource = bindingSource2;
            }
        }

        private void EditSettings_Click(object sender, EventArgs e)
        {
            Mail enabledMailSetting = MailRepository.GetEnabledMailSetting();
            Setting settings = SettingRepository.GetSettings();

            using (EditSettings editSettings = new EditSettings(enabledMailSetting, settings))
            {
                editSettings.ShowDialog();
            }
        }

        private void PrintList_Click(object sender, EventArgs e)
        {
            //PrintGrid.Print_DataGridView(this.InventoryGrid);
        }

        private void NewInventoryItem_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            using (NewItemView newItem = new NewItemView(inventory))
            {
                newItem.ShowDialog();
            }

            UpdateDataGrid();
        }

        private void SearchData_TextChanged(object sender, EventArgs e)
        {
            SearchForData();
        }
    }
}
