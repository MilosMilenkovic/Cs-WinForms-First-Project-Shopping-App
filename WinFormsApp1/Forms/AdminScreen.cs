using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinFormsApp1.Classes;
using ShoppingApp.Classes;
using ShoppingApp.Forms;
using WinFormsApp1;

namespace ShoppingApp.Forms
{
    public partial class AdminScreen : Form
    {
        List<Category> categories = new List<Category>();
        List<Item> items = new List<Item>();

        public AdminScreen()
        {
            InitializeComponent();
            Functions.readCategories(Functions.path_categories, categories);
            foreach (var category in categories)
            {
                lbCategories.Items.Add($"{category.selfId}| {category.CategoryName}");
            }

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {


            using (StreamWriter writer = new StreamWriter(Functions.path_categories, append: true))
            {
                categories.Add(new Category($"{tbCategoryName.Text}"));
                writer.WriteLine($"{Category.Id}, {tbCategoryName.Text}");
                lbCategories.Items.Add($"{Category.Id}| {tbCategoryName.Text}");
                writer.Close();
            }
        }

        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCategories.SelectedIndex != -1)
            {
                btnEditCategory.Enabled = true;
                btnDeleteCategory.Enabled = true;
            }
        }

        private void tabAdministration_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabAdministration.SelectedIndex)
            {
                case 1:
                    lbItems.Items.Clear();
                    items.Clear();
                    Functions.readItems(Functions.path_items, items);
                    foreach (var item in items)
                    {
                        lbItems.Items.Add($"{item.ItemName} {item.UnitOfMeasurement} {item.Price}€");
                    }
                    cbCategoryName.Items.Clear();
                    foreach (var category in categories)
                    {
                        cbCategoryName.Items.Add(category);
                    }
                    break;
                case 2:
                    break;
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            categories[lbCategories.SelectedIndex].CategoryName = tbCategoryName.Text;
            lbCategories.Items.Clear();
            using (StreamWriter writer = new StreamWriter(Functions.path_categories))
            {
                foreach (var category in categories)
                {
                    writer.WriteLine($"{category.selfId}, {category.CategoryName}");
                    lbCategories.Items.Add($"{category.selfId}| {category.CategoryName}");
                }
            }

            btnEditCategory.Enabled = false;
            btnDeleteCategory.Enabled = false;

        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            List<string> lines = File.ReadAllLines(Functions.path_categories).ToList();
            lines.RemoveAt(lbCategories.SelectedIndex);
            lines.RemoveAll(s => string.IsNullOrEmpty(s));
            File.WriteAllLines(Functions.path_categories, lines);
            categories.Clear();
            lbCategories.Items.Clear();
            Functions.readCategories(Functions.path_categories, categories);
            foreach (var category in categories)
            {
                lbCategories.Items.Add($"{category.selfId}| {category.CategoryName}");
            }

            btnEditCategory.Enabled = false;
            btnDeleteCategory.Enabled = false;

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int categoryID = 0;
            if (cbCategoryName.SelectedItem is Category category)
            {
                categoryID = category.selfId;
            }
            using (StreamWriter writer = new StreamWriter(Functions.path_items, append: true))
            {
                items.Add(new Item(tbItemName.Text, categoryID, double.Parse(tbItemPrice.Text), tbItemUnit.Text));
                writer.WriteLine($"{tbItemName.Text}, {categoryID}, {double.Parse(tbItemPrice.Text)}, {tbItemUnit.Text}");
                lbItems.Items.Add($"{tbItemName.Text} {tbItemUnit.Text} {double.Parse(tbItemPrice.Text)}€");
                writer.Close();
            }
            cbCategoryName.SelectedIndex = -1;
            tbItemName.Text = "";
            tbItemPrice.Text = "";
            tbItemUnit.Text = "";
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            int categoryID = 0;
            if (cbCategoryName.SelectedItem is Category category)
            {
                categoryID = category.selfId;
            }
            items[lbItems.SelectedIndex].CategoryId = categoryID;
            items[lbItems.SelectedIndex].ItemName = tbItemName.Text;
            items[lbItems.SelectedIndex].Price = double.Parse(tbItemPrice.Text);
            items[lbItems.SelectedIndex].UnitOfMeasurement = tbItemUnit.Text;
            lbItems.Items.Clear();
            using (StreamWriter writer = new StreamWriter(Functions.path_items))
            {
                foreach (var item in items)
                {
                    writer.WriteLine($"{item.ItemName}, {item.CategoryId}, {item.Price}, {item.UnitOfMeasurement}");
                    lbItems.Items.Add($"{item.ItemName} {item.UnitOfMeasurement} {item.Price} ");
                }
            }

            btnEditItem.Enabled = false;
            btnDeleteItem.Enabled = false;
            cbCategoryName.SelectedIndex = -1;
            tbItemName.Text = "";
            tbItemPrice.Text = "";
            tbItemUnit.Text = "";
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            List<string> lines = File.ReadAllLines(Functions.path_items).ToList();
            lines.RemoveAt(lbItems.SelectedIndex);
            lines.RemoveAll(s => string.IsNullOrEmpty(s));
            File.WriteAllLines(Functions.path_items, lines);
            items.Clear();
            lbItems.Items.Clear();
            Functions.readItems(Functions.path_items, items);
            foreach (var item in items)
            {
                lbItems.Items.Add($"{item.ItemName} {item.UnitOfMeasurement} {item.Price}€");
            }

            btnEditItem.Enabled = false;
            btnDeleteItem.Enabled = false;
            cbCategoryName.SelectedIndex = -1;
            tbItemName.Text = "";
            tbItemPrice.Text = "";
            tbItemUnit.Text = "";
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex != -1)
            {
                btnEditItem.Enabled = true;
                btnDeleteItem.Enabled = true;
            }
        }

        private void btnAdminBack_Click(object sender, EventArgs e)
        {

            StartScreen form = new StartScreen();
            form.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            panelStatistics.Controls.Clear();
            DateTime date = dateTimePicker1.Value.Date;
            string path = $"Bills\\Bill_{date.ToString("d.MM.yyyy")}.csv";
            int totalValue = 0;

            if (File.Exists(path))
            {
                string directoryPath = "Bills\\";


                string[] csvFiles = Directory.GetFiles(directoryPath, "*.csv");

                foreach (string csvFile in csvFiles)
                {
                    using (StreamReader reader = new StreamReader(csvFile))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] values = line.Split(',');

                            if (values.Length >= 2)
                            {
                                if (int.TryParse(values[1], out int value))
                                {
                                    totalValue += value;
                                }
                            }
                        }
                        reader.Close();
                    }
                }
                using (StreamReader reader = new StreamReader(path))
                {
                    var posy = 20;
                    var posx = 20;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        if (values.Length == 2 && int.Parse(values[1]) != 0)
                        {
                            Label label = new Label();
                            Label label_sold = new Label();
                            panelStatistics.Controls.Add(label);
                            panelStatistics.Controls.Add(label_sold);
                            label.Text = values[0];
                            label.Location = new System.Drawing.Point(posx, posy);
                            label.Size = new Size(350, 20);
                            ProgressBar progressBar = new ProgressBar();
                            panelStatistics.Controls.Add(progressBar);
                            progressBar.Location = new System.Drawing.Point(posx + 370, posy);
                            progressBar.Size = new Size(100, 15);
                            double value = (double.Parse(values[1]) / totalValue) * 100;
                            progressBar.Value = Convert.ToInt32(value);
                            label_sold.Text = $"{double.Parse(values[1])} sold";
                            label_sold.Location = new System.Drawing.Point(posx + 475, posy);
                            label_sold.Size = new Size(100, 20);
                            posy += 20;
                            posx = 20;
                        }
                    }
                    reader.Close();
                }
            }
            else
            {
                MessageBox.Show("No data for given day.");
            }
        }

        private void AdminScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}



