namespace ShoppingApp.Forms
{
    partial class Sale
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
            panelCategory = new Panel();
            btnNewTransaction = new Button();
            tabTransaction = new TabControl();
            tabInput = new TabPage();
            lblTotal = new Label();
            btnNext = new Button();
            btnDelete = new Button();
            lbInput = new ListBox();
            tabBill = new TabPage();
            btnFinish = new Button();
            lbBill = new ListBox();
            btnAdminBack = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnX = new Button();
            tbQuantity = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            panelItems = new FlowLayoutPanel();
            tabTransaction.SuspendLayout();
            tabInput.SuspendLayout();
            tabBill.SuspendLayout();
            SuspendLayout();
            // 
            // panelCategory
            // 
            panelCategory.AutoScroll = true;
            panelCategory.Location = new Point(7, 4);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(450, 93);
            panelCategory.TabIndex = 0;
            // 
            // btnNewTransaction
            // 
            btnNewTransaction.FlatStyle = FlatStyle.Flat;
            btnNewTransaction.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewTransaction.Location = new Point(463, 4);
            btnNewTransaction.Name = "btnNewTransaction";
            btnNewTransaction.Size = new Size(153, 41);
            btnNewTransaction.TabIndex = 2;
            btnNewTransaction.Text = "New transaction";
            btnNewTransaction.UseVisualStyleBackColor = true;
            btnNewTransaction.Click += btnNewTransaction_Click;
            // 
            // tabTransaction
            // 
            tabTransaction.Controls.Add(tabInput);
            tabTransaction.Controls.Add(tabBill);
            tabTransaction.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabTransaction.Location = new Point(463, 49);
            tabTransaction.Name = "tabTransaction";
            tabTransaction.SelectedIndex = 0;
            tabTransaction.Size = new Size(325, 195);
            tabTransaction.TabIndex = 3;
            tabTransaction.SelectedIndexChanged += tabTransaction_SelectedIndexChanged;
            // 
            // tabInput
            // 
            tabInput.Controls.Add(lblTotal);
            tabInput.Controls.Add(btnNext);
            tabInput.Controls.Add(btnDelete);
            tabInput.Controls.Add(lbInput);
            tabInput.Location = new Point(4, 25);
            tabInput.Name = "tabInput";
            tabInput.Padding = new Padding(3);
            tabInput.Size = new Size(317, 166);
            tabInput.TabIndex = 0;
            tabInput.Text = "Input/Processing";
            tabInput.UseVisualStyleBackColor = true;
            tabInput.Click += tabInput_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(6, 121);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 22);
            lblTotal.TabIndex = 3;
            // 
            // btnNext
            // 
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(189, 116);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(122, 34);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next =>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(219, 32);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 56);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbInput
            // 
            lbInput.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbInput.FormattingEnabled = true;
            lbInput.HorizontalScrollbar = true;
            lbInput.ItemHeight = 16;
            lbInput.Location = new Point(6, 3);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(207, 100);
            lbInput.TabIndex = 0;
            // 
            // tabBill
            // 
            tabBill.Controls.Add(btnFinish);
            tabBill.Controls.Add(lbBill);
            tabBill.Location = new Point(4, 25);
            tabBill.Name = "tabBill";
            tabBill.Padding = new Padding(3);
            tabBill.Size = new Size(317, 166);
            tabBill.TabIndex = 1;
            tabBill.Text = "Fiscal Bill";
            tabBill.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            btnFinish.FlatStyle = FlatStyle.System;
            btnFinish.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinish.Location = new Point(189, 46);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(113, 73);
            btnFinish.TabIndex = 1;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // lbBill
            // 
            lbBill.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbBill.FormattingEnabled = true;
            lbBill.HorizontalScrollbar = true;
            lbBill.ItemHeight = 16;
            lbBill.Location = new Point(6, 8);
            lbBill.MaximumSize = new Size(177, 0);
            lbBill.Name = "lbBill";
            lbBill.Size = new Size(177, 148);
            lbBill.TabIndex = 0;
            // 
            // btnAdminBack
            // 
            btnAdminBack.FlatStyle = FlatStyle.Flat;
            btnAdminBack.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminBack.Location = new Point(7, 533);
            btnAdminBack.Name = "btnAdminBack";
            btnAdminBack.Size = new Size(135, 37);
            btnAdminBack.TabIndex = 4;
            btnAdminBack.Text = "Back";
            btnAdminBack.UseVisualStyleBackColor = true;
            btnAdminBack.Click += btnAdminBack_Click;
            // 
            // btn7
            // 
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(463, 334);
            btn7.Name = "btn7";
            btn7.Size = new Size(54, 51);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(523, 334);
            btn8.Name = "btn8";
            btn8.Size = new Size(54, 51);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(583, 334);
            btn9.Name = "btn9";
            btn9.Size = new Size(54, 51);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(463, 391);
            btn4.Name = "btn4";
            btn4.Size = new Size(54, 51);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(523, 391);
            btn5.Name = "btn5";
            btn5.Size = new Size(54, 51);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(583, 391);
            btn6.Name = "btn6";
            btn6.Size = new Size(54, 51);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(463, 448);
            btn1.Name = "btn1";
            btn1.Size = new Size(54, 51);
            btn1.TabIndex = 11;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(523, 448);
            btn2.Name = "btn2";
            btn2.Size = new Size(54, 51);
            btn2.TabIndex = 12;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(583, 448);
            btn3.Name = "btn3";
            btn3.Size = new Size(54, 51);
            btn3.TabIndex = 13;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnDot
            // 
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.Location = new Point(583, 505);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(54, 51);
            btnDot.TabIndex = 14;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(463, 505);
            btn0.Name = "btn0";
            btn0.Size = new Size(114, 51);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnX
            // 
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnX.Location = new Point(463, 279);
            btnX.Name = "btnX";
            btnX.Size = new Size(54, 51);
            btnX.TabIndex = 16;
            btnX.Text = "x";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // tbQuantity
            // 
            tbQuantity.Enabled = false;
            tbQuantity.Location = new Point(463, 252);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(331, 23);
            tbQuantity.TabIndex = 17;
            // 
            // btnConfirm
            // 
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.Location = new Point(643, 345);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(148, 74);
            btnConfirm.TabIndex = 18;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(643, 425);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(148, 74);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panelItems
            // 
            panelItems.AutoScroll = true;
            panelItems.Location = new Point(8, 105);
            panelItems.Name = "panelItems";
            panelItems.Size = new Size(449, 422);
            panelItems.TabIndex = 20;
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 574);
            Controls.Add(panelItems);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(tbQuantity);
            Controls.Add(btnX);
            Controls.Add(btn0);
            Controls.Add(btnDot);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnAdminBack);
            Controls.Add(tabTransaction);
            Controls.Add(btnNewTransaction);
            Controls.Add(panelCategory);
            Name = "Sale";
            Text = "Sale/Payment";
            FormClosed += Sale_FormClosed;
            Load += Sale_Load;
            tabTransaction.ResumeLayout(false);
            tabInput.ResumeLayout(false);
            tabInput.PerformLayout();
            tabBill.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCategory;
        private Button btnNewTransaction;
        private TabControl tabTransaction;
        private TabPage tabInput;
        private Label lblTotal;
        private Button btnNext;
        private Button btnDelete;
        private ListBox lbInput;
        private TabPage tabBill;
        private Button btnAdminBack;
        private Button btnFinish;
        private ListBox lbBill;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnDot;
        private Button btn0;
        private Button btnX;
        private TextBox tbQuantity;
        private Button btnConfirm;
        private Button btnCancel;
        private FlowLayoutPanel panelItems;
    }
}