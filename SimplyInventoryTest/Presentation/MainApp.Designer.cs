namespace SimplyInventoryTest.Presentation
{
    partial class MainApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.InventoryGrid = new System.Windows.Forms.DataGridView();
            this.QuitApp = new System.Windows.Forms.Button();
            this.SearchCategoryLabel = new System.Windows.Forms.Label();
            this.NewInventoryItem = new System.Windows.Forms.Button();
            this.SendInventory = new System.Windows.Forms.Button();
            this.ManualMailer = new System.Windows.Forms.Button();
            this.ClearQuery = new System.Windows.Forms.Button();
            this.SearchCategory = new System.Windows.Forms.TextBox();
            this.SearchItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtyNeeded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtyLeftOver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchItemLabel = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.PopupKeyboard = new System.Windows.Forms.Button();
            this.EditSettings = new System.Windows.Forms.Button();
            this.PrintList = new System.Windows.Forms.Button();
            this.AppLogo = new System.Windows.Forms.PictureBox();
            this.StoreLogo = new System.Windows.Forms.PictureBox();
            this.SearchData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryGrid
            // 
            this.InventoryGrid.AllowUserToAddRows = false;
            this.InventoryGrid.AllowUserToDeleteRows = false;
            this.InventoryGrid.AllowUserToResizeColumns = false;
            this.InventoryGrid.AllowUserToResizeRows = false;
            this.InventoryGrid.BackgroundColor = System.Drawing.Color.White;
            this.InventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCategory,
            this.colDescription,
            this.colQtyNeeded,
            this.colQtyLeftOver});
            this.InventoryGrid.GridColor = System.Drawing.Color.Black;
            this.InventoryGrid.Location = new System.Drawing.Point(5, 7);
            this.InventoryGrid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.InventoryGrid.MultiSelect = false;
            this.InventoryGrid.Name = "InventoryGrid";
            this.InventoryGrid.RowHeadersVisible = false;
            this.InventoryGrid.Size = new System.Drawing.Size(749, 542);
            this.InventoryGrid.TabIndex = 0;
            this.InventoryGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.InventoryGrid_ColumnHeaderMouseClick);
            // 
            // QuitApp
            // 
            this.QuitApp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitApp.Location = new System.Drawing.Point(775, 555);
            this.QuitApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuitApp.Name = "QuitApp";
            this.QuitApp.Size = new System.Drawing.Size(378, 82);
            this.QuitApp.TabIndex = 8;
            this.QuitApp.Text = "E&XIT";
            this.QuitApp.UseVisualStyleBackColor = true;
            // 
            // SearchCategoryLabel
            // 
            this.SearchCategoryLabel.AutoSize = true;
            this.SearchCategoryLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCategoryLabel.Location = new System.Drawing.Point(961, 142);
            this.SearchCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchCategoryLabel.Name = "SearchCategoryLabel";
            this.SearchCategoryLabel.Size = new System.Drawing.Size(120, 19);
            this.SearchCategoryLabel.TabIndex = 2;
            this.SearchCategoryLabel.Text = "Search Category";
            // 
            // NewInventoryItem
            // 
            this.NewInventoryItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewInventoryItem.Location = new System.Drawing.Point(775, 276);
            this.NewInventoryItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewInventoryItem.Name = "NewInventoryItem";
            this.NewInventoryItem.Size = new System.Drawing.Size(197, 67);
            this.NewInventoryItem.TabIndex = 5;
            this.NewInventoryItem.Text = "NEW ITEM";
            this.NewInventoryItem.UseVisualStyleBackColor = true;
            this.NewInventoryItem.Click += new System.EventHandler(this.NewInventoryItem_Click);
            this.NewInventoryItem.MouseHover += new System.EventHandler(this.NewInventoryItem_MouseHover);
            // 
            // SendInventory
            // 
            this.SendInventory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SendInventory.Location = new System.Drawing.Point(775, 379);
            this.SendInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SendInventory.Name = "SendInventory";
            this.SendInventory.Size = new System.Drawing.Size(197, 72);
            this.SendInventory.TabIndex = 7;
            this.SendInventory.Text = "SEND INVENTORY";
            this.SendInventory.UseVisualStyleBackColor = true;
            this.SendInventory.Click += new System.EventHandler(this.SendInventory_Click);
            this.SendInventory.MouseHover += new System.EventHandler(this.SendInventory_MouseHover);
            // 
            // ManualMailer
            // 
            this.ManualMailer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualMailer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManualMailer.Location = new System.Drawing.Point(775, 459);
            this.ManualMailer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManualMailer.Name = "ManualMailer";
            this.ManualMailer.Size = new System.Drawing.Size(197, 76);
            this.ManualMailer.TabIndex = 11;
            this.ManualMailer.Text = "SEND MAIL";
            this.ManualMailer.UseVisualStyleBackColor = true;
            this.ManualMailer.Click += new System.EventHandler(this.ManualMailer_Click);
            this.ManualMailer.MouseHover += new System.EventHandler(this.ManualMailer_MouseHover);
            // 
            // ClearQuery
            // 
            this.ClearQuery.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearQuery.Location = new System.Drawing.Point(775, 201);
            this.ClearQuery.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ClearQuery.Name = "ClearQuery";
            this.ClearQuery.Size = new System.Drawing.Size(181, 67);
            this.ClearQuery.TabIndex = 4;
            this.ClearQuery.Text = "CLEAR";
            this.ClearQuery.UseVisualStyleBackColor = true;
            this.ClearQuery.Click += new System.EventHandler(this.ClearQuery_Click);
            this.ClearQuery.MouseHover += new System.EventHandler(this.ClearQuery_MouseHover);
            // 
            // SearchCategory
            // 
            this.SearchCategory.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCategory.Location = new System.Drawing.Point(775, 165);
            this.SearchCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchCategory.Name = "SearchCategory";
            this.SearchCategory.Size = new System.Drawing.Size(181, 23);
            this.SearchCategory.TabIndex = 2;
            // 
            // SearchItem
            // 
            this.SearchItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchItem.Location = new System.Drawing.Point(965, 165);
            this.SearchItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchItem.Name = "SearchItem";
            this.SearchItem.Size = new System.Drawing.Size(188, 23);
            this.SearchItem.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 559);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 57);
            this.label3.TabIndex = 17;
            this.label3.Text = "Store Address\r\nGoes Here\r\nLa La La";
            // 
            // colCategory
            // 
            this.colCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCategory.DataPropertyName = "CategoryName";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCategory.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCategory.FillWeight = 203F;
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Width = 92;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDescription.DataPropertyName = "DescriptionName";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescription.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDescription.FillWeight = 83F;
            this.colDescription.HeaderText = "Item";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 63;
            // 
            // colQtyNeeded
            // 
            this.colQtyNeeded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colQtyNeeded.DataPropertyName = "QtyNeeded";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQtyNeeded.DefaultCellStyle = dataGridViewCellStyle3;
            this.colQtyNeeded.HeaderText = "Need";
            this.colQtyNeeded.Name = "colQtyNeeded";
            this.colQtyNeeded.Width = 68;
            // 
            // colQtyLeftOver
            // 
            this.colQtyLeftOver.DataPropertyName = "QtyLeftOver";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQtyLeftOver.DefaultCellStyle = dataGridViewCellStyle4;
            this.colQtyLeftOver.FillWeight = 60F;
            this.colQtyLeftOver.HeaderText = "Left";
            this.colQtyLeftOver.Name = "colQtyLeftOver";
            this.colQtyLeftOver.Width = 60;
            // 
            // SearchItemLabel
            // 
            this.SearchItemLabel.AutoSize = true;
            this.SearchItemLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchItemLabel.Location = new System.Drawing.Point(771, 142);
            this.SearchItemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchItemLabel.Name = "SearchItemLabel";
            this.SearchItemLabel.Size = new System.Drawing.Size(90, 19);
            this.SearchItemLabel.TabIndex = 0;
            this.SearchItemLabel.Text = "Search Item";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Image = global::SimplyInventoryTest.Properties.Resources.search;
            this.Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Search.Location = new System.Drawing.Point(1029, 196);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(124, 67);
            this.Search.TabIndex = 13;
            this.Search.Text = "SEARCH";
            this.Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            this.Search.MouseHover += new System.EventHandler(this.Search_MouseHover);
            // 
            // PopupKeyboard
            // 
            this.PopupKeyboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopupKeyboard.Image = global::SimplyInventoryTest.Properties.Resources.keyboard;
            this.PopupKeyboard.Location = new System.Drawing.Point(666, 559);
            this.PopupKeyboard.Margin = new System.Windows.Forms.Padding(4);
            this.PopupKeyboard.Name = "PopupKeyboard";
            this.PopupKeyboard.Size = new System.Drawing.Size(88, 82);
            this.PopupKeyboard.TabIndex = 10;
            this.PopupKeyboard.UseVisualStyleBackColor = false;
            // 
            // EditSettings
            // 
            this.EditSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSettings.Image = global::SimplyInventoryTest.Properties.Resources.settings;
            this.EditSettings.Location = new System.Drawing.Point(570, 559);
            this.EditSettings.Margin = new System.Windows.Forms.Padding(4);
            this.EditSettings.Name = "EditSettings";
            this.EditSettings.Size = new System.Drawing.Size(88, 82);
            this.EditSettings.TabIndex = 11;
            this.EditSettings.UseVisualStyleBackColor = false;
            this.EditSettings.Click += new System.EventHandler(this.EditSettings_Click);
            // 
            // PrintList
            // 
            this.PrintList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintList.Image = global::SimplyInventoryTest.Properties.Resources.print;
            this.PrintList.Location = new System.Drawing.Point(474, 559);
            this.PrintList.Margin = new System.Windows.Forms.Padding(4);
            this.PrintList.Name = "PrintList";
            this.PrintList.Size = new System.Drawing.Size(88, 82);
            this.PrintList.TabIndex = 13;
            this.PrintList.UseVisualStyleBackColor = false;
            this.PrintList.Click += new System.EventHandler(this.PrintList_Click);
            // 
            // AppLogo
            // 
            this.AppLogo.Image = global::SimplyInventoryTest.Properties.Resources.logo;
            this.AppLogo.Location = new System.Drawing.Point(813, 7);
            this.AppLogo.Margin = new System.Windows.Forms.Padding(4);
            this.AppLogo.Name = "AppLogo";
            this.AppLogo.Size = new System.Drawing.Size(300, 100);
            this.AppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AppLogo.TabIndex = 18;
            this.AppLogo.TabStop = false;
            // 
            // StoreLogo
            // 
            this.StoreLogo.Enabled = false;
            this.StoreLogo.Image = global::SimplyInventoryTest.Properties.Resources.banner;
            this.StoreLogo.Location = new System.Drawing.Point(813, 7);
            this.StoreLogo.Margin = new System.Windows.Forms.Padding(4);
            this.StoreLogo.Name = "StoreLogo";
            this.StoreLogo.Size = new System.Drawing.Size(300, 100);
            this.StoreLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.StoreLogo.TabIndex = 6;
            this.StoreLogo.TabStop = false;
            // 
            // SearchData
            // 
            this.SearchData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchData.Location = new System.Drawing.Point(775, 115);
            this.SearchData.Margin = new System.Windows.Forms.Padding(4);
            this.SearchData.Name = "SearchData";
            this.SearchData.Size = new System.Drawing.Size(378, 23);
            this.SearchData.TabIndex = 19;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 662);
            this.Controls.Add(this.SearchData);
            this.Controls.Add(this.SearchItemLabel);
            this.Controls.Add(this.AppLogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchItem);
            this.Controls.Add(this.SearchCategory);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ClearQuery);
            this.Controls.Add(this.ManualMailer);
            this.Controls.Add(this.SendInventory);
            this.Controls.Add(this.NewInventoryItem);
            this.Controls.Add(this.SearchCategoryLabel);
            this.Controls.Add(this.QuitApp);
            this.Controls.Add(this.StoreLogo);
            this.Controls.Add(this.PopupKeyboard);
            this.Controls.Add(this.EditSettings);
            this.Controls.Add(this.PrintList);
            this.Controls.Add(this.InventoryGrid);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simply Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InventoryGrid;
        private System.Windows.Forms.Button PrintList;
        private System.Windows.Forms.Button EditSettings;
        private System.Windows.Forms.Button PopupKeyboard;
        private System.Windows.Forms.Button QuitApp;
        private System.Windows.Forms.Label SearchCategoryLabel;
        private System.Windows.Forms.Button NewInventoryItem;
        private System.Windows.Forms.Button SendInventory;
        private System.Windows.Forms.Button ManualMailer;
        private System.Windows.Forms.Button ClearQuery;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SearchCategory;
        private System.Windows.Forms.TextBox SearchItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtyNeeded;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtyLeftOver;
        private System.Windows.Forms.Label SearchItemLabel;
        private System.Windows.Forms.PictureBox AppLogo;
        private System.Windows.Forms.PictureBox StoreLogo;
        private System.Windows.Forms.TextBox SearchData;
    }
}