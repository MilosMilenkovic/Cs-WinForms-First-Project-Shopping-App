using Microsoft.VisualBasic;
using ShoppingApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp1.Classes;

namespace ShoppingApp.Forms
{
    public partial class Sale : Form
    {
        public delegate void AlcoholDelegate(string category);


        public Sale()
        {

            InitializeComponent();
            lblTotal.Text = "0.00€";
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnDot.Enabled = false;
            btnX.Enabled = false;
            btnFinish.Enabled = false;

        }


        public Button selectedButtonCategory = new Button();
        public Button selectedButtonItem = new Button();
        public double total = 0;


        List<Category> categories = new List<Category>();
        List<Item> items = new List<Item>();

        public void Sale_Load(object sender, EventArgs e)
        {
            var posx = 20;
            Functions.readCategories(Functions.path_categories, categories);
            foreach (var category in categories)
            {
                Button button = new Button();
                this.panelCategory.Controls.Add(button);
                button.Location = new System.Drawing.Point(posx, 20);
                button.Text = category.CategoryName;
                button.Tag = category.selfId;
                button.Size = new System.Drawing.Size(80, 50);
                posx += 85;
                button.UseVisualStyleBackColor = true;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.Black;
                button.BackColor = Color.Lavender;
                button.Click += Button_Click;
            }

        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            List<string> lines = File.ReadAllLines(Functions.path_items).ToList();
            var posx = 20;
            string buttonId = button.Tag.ToString();
            panelItems.Controls.Clear();
            items.Clear();
            Functions.readItems(Functions.path_items, items);
            foreach (var item in items)
            {

                if (item.CategoryId == int.Parse(button.Tag.ToString()))
                {

                    Button buttonItem = new Button();
                    this.panelItems.Controls.Add(buttonItem);
                    buttonItem.Location = new System.Drawing.Point(posx, 20);
                    buttonItem.Text = item.ItemName;
                    buttonItem.Tag = item.CategoryId;
                    buttonItem.Size = new System.Drawing.Size(100, 100);
                    posx += 100;
                    buttonItem.UseVisualStyleBackColor = true;
                    buttonItem.FlatStyle = FlatStyle.Flat;
                    buttonItem.FlatAppearance.BorderColor = Color.Black;
                    buttonItem.BackColor = Color.Lavender;
                    buttonItem.Click += ButtonItem_Click;

                }

            }
            if (selectedButtonCategory != null)
            {
                selectedButtonCategory.BackColor = Color.Lavender;
            }

            selectedButtonCategory = button;
            selectedButtonCategory.BackColor = Color.LightBlue;

        }

        private void ButtonItem_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Functions.readItems(Functions.path_items, items);

            if (selectedButtonItem != null)
            {
                selectedButtonItem.BackColor = Color.Lavender;
            }

            selectedButtonItem = button;
            selectedButtonItem.BackColor = Color.LightBlue;

            {
                btn0.Enabled = true;
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btnDot.Enabled = true;
                btnX.Enabled = true;
            }
            tbQuantity.Text = button.Text;
            AlcoholDelegateCheck();


        }

        public void AlcoholCheck(string category)
        {
            DateTime time = DateTime.Now;
            DateTime time_check = new DateTime(time.Year, time.Month, time.Day, 22, 0, 0);
            if (selectedButtonCategory.Text == category && time >= time_check)
            {

                Directory.CreateDirectory("CanceledBills");
                DateTime date = DateTime.UtcNow.Date;
                string path = $"CanceledBills\\CanceledBill_{date.ToString("d.MM.yyyy")}.csv";
                foreach (var item in lbInput.Items)
                {
                    ;
                    string line = item.ToString();
                    string[] content = line.Split(' ');
                    string quantity_string = content[content.Length - 1];
                    Array.Resize(ref content, content.Length - 1);
                    string itemName = string.Join(" ", content);
                    var quantity = double.Parse(Regex.Match(quantity_string, @"\d+(\.\d+)?").Value);

                    using (StreamWriter writer = new StreamWriter(path, append: true))
                    {
                        writer.WriteLine($"{itemName}, {quantity}");
                        writer.Close();
                    }
                }

                btnNewTransaction.PerformClick();
                MessageBox.Show("It's too late to buy alcohol!");
                using (StreamWriter writer = new StreamWriter(path, append: true))
                {
                    writer.WriteLine($"\n=================================================================\n");
                    writer.Close();
                }
            }

        }
        private void AlcoholDelegateCheck()
        {

            AlcoholDelegate alcoholCheck = new AlcoholDelegate(AlcoholCheck);


            alcoholCheck("Alcohol");
        }
        private void btnAdminBack_Click(object sender, EventArgs e)
        {
            StartScreen form = new StartScreen();
            form.Show();
            this.Hide();
        }

        private void tabInput_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text != "")
            {
                tbQuantity.Text += " x ";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbQuantity.Text = "";
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnDot.Enabled = false;
            btnX.Enabled = false;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {

            if (tbQuantity.Text != "")
            {
                tbQuantity.Text += ".";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text != "")
            {
                tbQuantity.Text += "0";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text != "")
            {
                tbQuantity.Text += "3";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text != "")
            {
                tbQuantity.Text += "2";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text != "")
            {
                tbQuantity.Text += "1";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text != "")
            {
                tbQuantity.Text += "6";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text != "")
            {
                tbQuantity.Text += "5";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text != "")
            {
                tbQuantity.Text += "4";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text != "")
            {
                tbQuantity.Text += "9";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text != "")
            {
                tbQuantity.Text += "8";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text != "")
            {
                tbQuantity.Text += "7";
            }
        }
        private void lbInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbInput.SelectedIndex)
            {
                case 0:
                    lbBill.Items.Clear();
                    btnFinish.Enabled = false;
                    break;
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string line = tbQuantity.Text;
            string[] words = line.Split(' ');
            string lastWord = words[words.Length - 1];
            var displayUnit = "";
            string name = selectedButtonItem.Text;
            foreach (var item in items)
            {
                {
                    if (name == item.ItemName)
                    {

                        if (double.TryParse(lastWord, out double multiplier))
                        {
                            total += item.Price * double.Parse(lastWord);
                            displayUnit = $"({lastWord}{item.UnitOfMeasurement})";
                            lblTotal.Text = Math.Round(total, 2).ToString() + "€";
                            lbInput.Items.Add($"{item.ItemName} {displayUnit}");
                        }
                        else
                        {
                            total += item.Price;
                            displayUnit = item.UnitOfMeasurement;
                            lblTotal.Text = Math.Round(total, 2).ToString() + "€";
                            lbInput.Items.Add($"{item.ItemName} (1{displayUnit})");
                        }
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbInput.SelectedIndex != -1)
            {
                string line = lbInput.GetItemText(lbInput.SelectedItem);
                string[] words = line.Split(' ');
                string lastWord = words[words.Length - 1];
                Array.Resize(ref words, words.Length - 1);
                string result = string.Join(" ", words);
                var quantity = Regex.Match(lastWord, @"\d+(\.\d+)?").Value;
                foreach (var item in items)
                {
                    if (item.ItemName == result)
                    {
                        if (quantity != "")
                        {

                            var lblTotalSum = Regex.Match(lblTotal.Text, @"\d+(\.\d+)?").Value;
                            total -= item.Price * double.Parse(quantity);
                            lblTotal.Text = Math.Round(total, 2).ToString() + "€";
                            lbInput.Items.RemoveAt(lbInput.SelectedIndex);
                        }
                        else
                        {
                            var lblTotalSum = Regex.Match(lblTotal.Text, @"\d+(\.\d+)?").Value;
                            total -= item.Price;
                            lblTotal.Text = Math.Round(total, 2).ToString() + "€";
                            lbInput.Items.RemoveAt(lbInput.SelectedIndex);
                        }
                    }
                }
            }
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {

            panelItems.Controls.Clear();
            tbQuantity.Text = "";
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnDot.Enabled = false;
            btnX.Enabled = false;
            btnFinish.Enabled = false;
            lbInput.Items.Clear();
            lbBill.Items.Clear();
            lblTotal.Text = "0.00€";
            if (selectedButtonCategory != null)
            {
                selectedButtonCategory.BackColor = Color.Lavender;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            panelItems.Controls.Clear();
            if (selectedButtonCategory != null)
            {
                selectedButtonCategory.BackColor = Color.Lavender;
            }
            tabTransaction.SelectedIndex = 1;
            if (lbInput.Items.Count > 0)
            {
                foreach (var el in lbInput.Items)
                {
                    string line = el.ToString();
                    string[] words = line.Split(' ');
                    string lastWord = words[words.Length - 1];
                    Array.Resize(ref words, words.Length - 1);
                    string result = string.Join(" ", words);
                    var quantity = Regex.Match(lastWord, @"\d+(\.\d+)?").Value;
                    foreach (var item in items)
                    {

                        if (item.ItemName == result)
                        {
                            if (quantity == "")
                                lbBill.Items.Add($"{item.ItemName} {Math.Round(item.Price, 2)}€");
                            else
                                lbBill.Items.Add($"{item.ItemName} {Math.Round(double.Parse(quantity) * item.Price, 2)}€");
                        }
                    }

                }

                lbBill.Items.Add($"Total: {Math.Round(total, 2)}€");

            }
            if (lbBill.Items.Count > 0)
            {
                btnFinish.Enabled = true;
            }

        }

        private void tabTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabTransaction.SelectedIndex)
            {
                case 0:
                    lbBill.Items.Clear();
                    break;

            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("Bills");
            DateTime date = DateTime.UtcNow.Date;
            string path = $"Bills\\Bill_{date.ToString("d.MM.yyyy")}.csv";

            if (!File.Exists(path))
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (var item in items)
                    {
                        writer.WriteLine($"{item.ItemName}, 0");
                    }
                    writer.Close();
                }

            }

            foreach (var el in lbBill.Items)
            {
                string line = el.ToString();
                string[] content = line.Split(' ');
                string quantity_string = content[content.Length - 1];
                Array.Resize(ref content, content.Length - 1);
                string itemName = string.Join(" ", content);
                double quantity = double.Parse(Regex.Match(quantity_string, @"\d+(\.\d+)?").Value);
                List<string> lines = File.ReadAllLines(path).ToList();

                foreach (var item in items)
                {
                    if (item.ItemName == itemName)
                    {
                        for (int i = 0; i < lines.Count; i++)
                        {
                            string[] values = lines[i].Split(',');
                            if (values.Length == 2 && values[0] == item.ItemName)
                            {

                                double currentQuantity = double.Parse(values[1]);
                                double newQuantity = Math.Ceiling(currentQuantity + quantity / item.Price);
                                lines[i] = $"{values[0]}, {newQuantity}";
                            }
                        }
                    }
                }
                File.WriteAllLines(path, lines);
            }
            total = 0;
            lblTotal.Text = "0.00€";
            lbBill.Items.Clear();
            lbInput.Items.Clear();
            tabTransaction.SelectedIndex = 0;
            btnFinish.Enabled = false;
        }

        private void Sale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}



