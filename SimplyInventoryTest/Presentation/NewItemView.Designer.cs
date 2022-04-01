namespace SimplyInventoryTest.Presentation
{
    partial class NewItemView
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
            this.NewCategoryName = new System.Windows.Forms.TextBox();
            this.NewItemName = new System.Windows.Forms.TextBox();
            this.NewQtyLeftoverLabel = new System.Windows.Forms.Label();
            this.NewItemNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewQtyNeededLabel = new System.Windows.Forms.Label();
            this.CancelAddItem = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.NewQtyNeeded = new System.Windows.Forms.NumericUpDown();
            this.NewQtyLeftover = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NewQtyNeeded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewQtyLeftover)).BeginInit();
            this.SuspendLayout();
            // 
            // NewCategoryName
            // 
            this.NewCategoryName.Location = new System.Drawing.Point(22, 41);
            this.NewCategoryName.Name = "NewCategoryName";
            this.NewCategoryName.Size = new System.Drawing.Size(213, 27);
            this.NewCategoryName.TabIndex = 6;
            // 
            // NewItemName
            // 
            this.NewItemName.Location = new System.Drawing.Point(22, 101);
            this.NewItemName.Name = "NewItemName";
            this.NewItemName.Size = new System.Drawing.Size(213, 27);
            this.NewItemName.TabIndex = 7;
            // 
            // NewQtyLeftoverLabel
            // 
            this.NewQtyLeftoverLabel.AutoSize = true;
            this.NewQtyLeftoverLabel.Location = new System.Drawing.Point(246, 79);
            this.NewQtyLeftoverLabel.Name = "NewQtyLeftoverLabel";
            this.NewQtyLeftoverLabel.Size = new System.Drawing.Size(89, 19);
            this.NewQtyLeftoverLabel.TabIndex = 9;
            this.NewQtyLeftoverLabel.Text = "Qty Leftover";
            // 
            // NewItemNameLabel
            // 
            this.NewItemNameLabel.AutoSize = true;
            this.NewItemNameLabel.Location = new System.Drawing.Point(18, 79);
            this.NewItemNameLabel.Name = "NewItemNameLabel";
            this.NewItemNameLabel.Size = new System.Drawing.Size(80, 19);
            this.NewItemNameLabel.TabIndex = 3;
            this.NewItemNameLabel.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category Name";
            // 
            // NewQtyNeededLabel
            // 
            this.NewQtyNeededLabel.AutoSize = true;
            this.NewQtyNeededLabel.Location = new System.Drawing.Point(246, 19);
            this.NewQtyNeededLabel.Name = "NewQtyNeededLabel";
            this.NewQtyNeededLabel.Size = new System.Drawing.Size(86, 19);
            this.NewQtyNeededLabel.TabIndex = 8;
            this.NewQtyNeededLabel.Text = "Qty Needed";
            // 
            // CancelAddItem
            // 
            this.CancelAddItem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddItem.Location = new System.Drawing.Point(147, 160);
            this.CancelAddItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelAddItem.Name = "CancelAddItem";
            this.CancelAddItem.Size = new System.Drawing.Size(86, 43);
            this.CancelAddItem.TabIndex = 1;
            this.CancelAddItem.Text = "C&ancel";
            this.CancelAddItem.UseVisualStyleBackColor = true;
            this.CancelAddItem.Click += new System.EventHandler(this.CancelAddItem_Click);
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(239, 160);
            this.AddItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(86, 43);
            this.AddItem.TabIndex = 0;
            this.AddItem.Text = "&Add";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // NewQtyNeeded
            // 
            this.NewQtyNeeded.Location = new System.Drawing.Point(250, 42);
            this.NewQtyNeeded.Name = "NewQtyNeeded";
            this.NewQtyNeeded.Size = new System.Drawing.Size(75, 27);
            this.NewQtyNeeded.TabIndex = 12;
            // 
            // NewQtyLeftover
            // 
            this.NewQtyLeftover.Location = new System.Drawing.Point(250, 102);
            this.NewQtyLeftover.Name = "NewQtyLeftover";
            this.NewQtyLeftover.Size = new System.Drawing.Size(75, 27);
            this.NewQtyLeftover.TabIndex = 14;
            // 
            // NewItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(349, 227);
            this.Controls.Add(this.NewQtyLeftover);
            this.Controls.Add(this.NewQtyNeeded);
            this.Controls.Add(this.CancelAddItem);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.NewQtyNeededLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewItemNameLabel);
            this.Controls.Add(this.NewQtyLeftoverLabel);
            this.Controls.Add(this.NewItemName);
            this.Controls.Add(this.NewCategoryName);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewItemView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Item";
            ((System.ComponentModel.ISupportInitialize)(this.NewQtyNeeded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewQtyLeftover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewCategoryName;
        private System.Windows.Forms.TextBox NewItemName;
        private System.Windows.Forms.Label NewQtyLeftoverLabel;
        private System.Windows.Forms.Label NewItemNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NewQtyNeededLabel;
        private System.Windows.Forms.Button CancelAddItem;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.NumericUpDown NewQtyNeeded;
        private System.Windows.Forms.NumericUpDown NewQtyLeftover;
    }
}