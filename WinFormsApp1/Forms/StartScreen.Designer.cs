namespace WinFormsApp1
{
    partial class StartScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdministration = new Button();
            btnSale = new Button();
            SuspendLayout();
            // 
            // btnAdministration
            // 
            btnAdministration.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdministration.Location = new Point(12, 22);
            btnAdministration.Name = "btnAdministration";
            btnAdministration.Size = new Size(283, 46);
            btnAdministration.TabIndex = 0;
            btnAdministration.Text = "Administration and Statistics";
            btnAdministration.UseVisualStyleBackColor = true;
            btnAdministration.Click += btnAdministration_Click;
            // 
            // btnSale
            // 
            btnSale.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSale.Location = new Point(12, 74);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(283, 46);
            btnSale.TabIndex = 1;
            btnSale.Text = "Sale/Payment";
            btnSale.UseVisualStyleBackColor = true;
            btnSale.Click += btnSale_Click;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 136);
            Controls.Add(btnSale);
            Controls.Add(btnAdministration);
            Name = "StartScreen";
            Text = "Shopping App";
            FormClosed += StartScreen_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdministration;
        private Button btnSale;
    }
}