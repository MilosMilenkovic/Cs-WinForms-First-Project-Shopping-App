namespace ShoppingApp.Forms
{
    partial class AdminScreen
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
            tabAdministration = new TabControl();
            tabCategory = new TabPage();
            btnDeleteCategory = new Button();
            btnEditCategory = new Button();
            btnAddCategory = new Button();
            lblCategoryName = new Label();
            tbCategoryName = new TextBox();
            lbCategories = new ListBox();
            tabItems = new TabPage();
            cbCategoryName = new ComboBox();
            btnDeleteItem = new Button();
            btnEditItem = new Button();
            btnAddItem = new Button();
            lblUnit = new Label();
            tbItemUnit = new TextBox();
            lblItemPrice = new Label();
            tbItemPrice = new TextBox();
            lblItemName = new Label();
            tbItemName = new TextBox();
            lblItemCategoryName = new Label();
            lbItems = new ListBox();
            tabStatistics = new TabPage();
            panelStatistics = new Panel();
            dateTimePicker1 = new DateTimePicker();
            btnAdminBack = new Button();
            tabAdministration.SuspendLayout();
            tabCategory.SuspendLayout();
            tabItems.SuspendLayout();
            tabStatistics.SuspendLayout();
            SuspendLayout();
            // 
            // tabAdministration
            // 
            tabAdministration.Controls.Add(tabCategory);
            tabAdministration.Controls.Add(tabItems);
            tabAdministration.Controls.Add(tabStatistics);
            tabAdministration.Location = new Point(12, 12);
            tabAdministration.Name = "tabAdministration";
            tabAdministration.SelectedIndex = 0;
            tabAdministration.Size = new Size(718, 372);
            tabAdministration.TabIndex = 0;
            tabAdministration.SelectedIndexChanged += tabAdministration_SelectedIndexChanged;
            // 
            // tabCategory
            // 
            tabCategory.Controls.Add(btnDeleteCategory);
            tabCategory.Controls.Add(btnEditCategory);
            tabCategory.Controls.Add(btnAddCategory);
            tabCategory.Controls.Add(lblCategoryName);
            tabCategory.Controls.Add(tbCategoryName);
            tabCategory.Controls.Add(lbCategories);
            tabCategory.Location = new Point(4, 24);
            tabCategory.Name = "tabCategory";
            tabCategory.Padding = new Padding(3);
            tabCategory.Size = new Size(710, 344);
            tabCategory.TabIndex = 0;
            tabCategory.Text = "Update categories";
            tabCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Enabled = false;
            btnDeleteCategory.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteCategory.Location = new Point(7, 265);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(422, 38);
            btnDeleteCategory.TabIndex = 6;
            btnDeleteCategory.Text = "Delete Category";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Enabled = false;
            btnEditCategory.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditCategory.Location = new Point(7, 221);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(422, 38);
            btnEditCategory.TabIndex = 5;
            btnEditCategory.Text = "Edit Category";
            btnEditCategory.UseVisualStyleBackColor = true;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCategory.Location = new Point(7, 177);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(422, 38);
            btnAddCategory.TabIndex = 4;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(7, 120);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(91, 15);
            lblCategoryName.TabIndex = 3;
            lblCategoryName.Text = "Category name:";
            // 
            // tbCategoryName
            // 
            tbCategoryName.Location = new Point(7, 138);
            tbCategoryName.Name = "tbCategoryName";
            tbCategoryName.Size = new Size(422, 23);
            tbCategoryName.TabIndex = 2;
            // 
            // lbCategories
            // 
            lbCategories.FormattingEnabled = true;
            lbCategories.HorizontalScrollbar = true;
            lbCategories.ItemHeight = 15;
            lbCategories.Location = new Point(435, 6);
            lbCategories.Name = "lbCategories";
            lbCategories.Size = new Size(269, 319);
            lbCategories.TabIndex = 1;
            lbCategories.SelectedIndexChanged += lbCategories_SelectedIndexChanged;
            // 
            // tabItems
            // 
            tabItems.AutoScroll = true;
            tabItems.Controls.Add(cbCategoryName);
            tabItems.Controls.Add(btnDeleteItem);
            tabItems.Controls.Add(btnEditItem);
            tabItems.Controls.Add(btnAddItem);
            tabItems.Controls.Add(lblUnit);
            tabItems.Controls.Add(tbItemUnit);
            tabItems.Controls.Add(lblItemPrice);
            tabItems.Controls.Add(tbItemPrice);
            tabItems.Controls.Add(lblItemName);
            tabItems.Controls.Add(tbItemName);
            tabItems.Controls.Add(lblItemCategoryName);
            tabItems.Controls.Add(lbItems);
            tabItems.Location = new Point(4, 24);
            tabItems.Name = "tabItems";
            tabItems.Padding = new Padding(3);
            tabItems.Size = new Size(710, 344);
            tabItems.TabIndex = 1;
            tabItems.Text = "Update items";
            tabItems.UseVisualStyleBackColor = true;
            // 
            // cbCategoryName
            // 
            cbCategoryName.FormattingEnabled = true;
            cbCategoryName.Location = new Point(6, 30);
            cbCategoryName.Name = "cbCategoryName";
            cbCategoryName.Size = new Size(417, 23);
            cbCategoryName.TabIndex = 14;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Enabled = false;
            btnDeleteItem.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteItem.Location = new Point(6, 291);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(422, 38);
            btnDeleteItem.TabIndex = 13;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.Enabled = false;
            btnEditItem.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditItem.Location = new Point(3, 247);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(422, 38);
            btnEditItem.TabIndex = 12;
            btnEditItem.Text = "Edit Item";
            btnEditItem.UseVisualStyleBackColor = true;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddItem.Location = new Point(3, 203);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(422, 38);
            btnAddItem.TabIndex = 11;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(8, 152);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(183, 15);
            lblUnit.TabIndex = 10;
            lblUnit.Text = "Unit of measurement of the item:";
            // 
            // tbItemUnit
            // 
            tbItemUnit.Location = new Point(7, 171);
            tbItemUnit.Name = "tbItemUnit";
            tbItemUnit.Size = new Size(418, 23);
            tbItemUnit.TabIndex = 9;
            // 
            // lblItemPrice
            // 
            lblItemPrice.AutoSize = true;
            lblItemPrice.Location = new Point(8, 104);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new Size(63, 15);
            lblItemPrice.TabIndex = 8;
            lblItemPrice.Text = "Item price:";
            // 
            // tbItemPrice
            // 
            tbItemPrice.Location = new Point(7, 123);
            tbItemPrice.Name = "tbItemPrice";
            tbItemPrice.Size = new Size(418, 23);
            tbItemPrice.TabIndex = 7;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(7, 59);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(67, 15);
            lblItemName.TabIndex = 6;
            lblItemName.Text = "Item name:";
            // 
            // tbItemName
            // 
            tbItemName.Location = new Point(6, 78);
            tbItemName.Name = "tbItemName";
            tbItemName.Size = new Size(418, 23);
            tbItemName.TabIndex = 5;
            // 
            // lblItemCategoryName
            // 
            lblItemCategoryName.AutoSize = true;
            lblItemCategoryName.Location = new Point(7, 12);
            lblItemCategoryName.Name = "lblItemCategoryName";
            lblItemCategoryName.Size = new Size(91, 15);
            lblItemCategoryName.TabIndex = 4;
            lblItemCategoryName.Text = "Category name:";
            // 
            // lbItems
            // 
            lbItems.FormattingEnabled = true;
            lbItems.HorizontalScrollbar = true;
            lbItems.ItemHeight = 15;
            lbItems.Location = new Point(435, 6);
            lbItems.Name = "lbItems";
            lbItems.Size = new Size(269, 319);
            lbItems.TabIndex = 2;
            lbItems.SelectedIndexChanged += lbItems_SelectedIndexChanged;
            // 
            // tabStatistics
            // 
            tabStatistics.Controls.Add(panelStatistics);
            tabStatistics.Controls.Add(dateTimePicker1);
            tabStatistics.Location = new Point(4, 24);
            tabStatistics.Name = "tabStatistics";
            tabStatistics.Padding = new Padding(3);
            tabStatistics.Size = new Size(710, 344);
            tabStatistics.TabIndex = 2;
            tabStatistics.Text = "Statistics";
            tabStatistics.UseVisualStyleBackColor = true;
            // 
            // panelStatistics
            // 
            panelStatistics.AutoScroll = true;
            panelStatistics.Location = new Point(22, 80);
            panelStatistics.Name = "panelStatistics";
            panelStatistics.Size = new Size(676, 251);
            panelStatistics.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(238, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(207, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnAdminBack
            // 
            btnAdminBack.FlatStyle = FlatStyle.Flat;
            btnAdminBack.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminBack.Location = new Point(16, 386);
            btnAdminBack.Name = "btnAdminBack";
            btnAdminBack.Size = new Size(135, 37);
            btnAdminBack.TabIndex = 1;
            btnAdminBack.Text = "Back";
            btnAdminBack.UseVisualStyleBackColor = true;
            btnAdminBack.Click += btnAdminBack_Click;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 430);
            Controls.Add(btnAdminBack);
            Controls.Add(tabAdministration);
            Name = "AdminScreen";
            Text = "AdminScreen";
            FormClosed += AdminScreen_FormClosed;
            tabAdministration.ResumeLayout(false);
            tabCategory.ResumeLayout(false);
            tabCategory.PerformLayout();
            tabItems.ResumeLayout(false);
            tabItems.PerformLayout();
            tabStatistics.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAdministration;
        private TabPage tabCategory;
        private TabPage tabItems;
        private TabPage tabStatistics;
        private Button btnDeleteCategory;
        private Button btnEditCategory;
        private Button btnAddCategory;
        private Label lblCategoryName;
        private TextBox tbCategoryName;
        private ListBox lbCategories;
        private Label lblUnit;
        private TextBox tbItemUnit;
        private Label lblItemPrice;
        private TextBox tbItemPrice;
        private Label lblItemName;
        private TextBox tbItemName;
        private Label lblItemCategoryName;
        private ListBox lbItems;
        private Button btnDeleteItem;
        private Button btnEditItem;
        private Button btnAddItem;
        private ComboBox cbCategoryName;
        private Button btnAdminBack;
        private DateTimePicker dateTimePicker1;
        private Panel panelStatistics;
    }
}