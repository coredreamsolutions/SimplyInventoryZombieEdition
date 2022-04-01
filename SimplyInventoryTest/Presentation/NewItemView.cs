using System.Windows.Forms;
using SimplyInventoryTest.Model;
using SimplyInventoryTest.Validators;
using SimplyInventoryTest.Core;
using System;
using SimplyInventoryTest.Repositories;

namespace SimplyInventoryTest.Presentation
{
    public partial class NewItemView : Form
    {
        public Inventory ActiveModel { get; set; }
        public NewItemView(Inventory inventory)
        {
            InitializeComponent();

            ActiveModel = inventory ?? throw new ArgumentNullException("inventory");           
            ActiveModel = inventory;

            BindModel(ActiveModel);
        }

        private void BindModel(Inventory inventory)
        {
            this.NewCategoryName.DataBindings.Add("Text", inventory, "CategoryName", true, DataSourceUpdateMode.OnPropertyChanged);
            this.NewItemName.DataBindings.Add("Text", inventory, "DescriptionName", true, DataSourceUpdateMode.OnPropertyChanged);
            this.NewQtyNeeded.DataBindings.Add("Value", inventory, "QtyNeeded", true, DataSourceUpdateMode.OnPropertyChanged);
            this.NewQtyLeftover.DataBindings.Add("Value", inventory, "QtyLeftOver", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            CheckResult checkResult = InventoryValidator.ValidateSave(ActiveModel);
            if (checkResult.Failed)
            {
                MessageBox.Show(checkResult.Items[0].Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            InventoryRepository.SaveItem(ActiveModel, null);
            MessageBox.Show("Item has been added to database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }

        private void CancelAddItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
