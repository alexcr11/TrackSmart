namespace TrackSmart
{
    partial class Form1
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
            this.category = new System.Windows.Forms.ComboBox();
            this.vendor = new System.Windows.Forms.ComboBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.listViewExpenses = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.btnYTD = new System.Windows.Forms.Button();
            this.btnMTD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Gas",
            "Vehicle Maintenance",
            "Office Supplies",
            "Training /Certifications",
            "Food Receipts-Self",
            "Food Receipts-Client",
            "Outings",
            "Internet",
            "Cell Phone",
            "Electric-Home",
            "Gas-Home",
            "Renters Insurance-Home",
            "Auto Insurance-Home",
            "License/Tags"});
            this.category.Location = new System.Drawing.Point(172, 26);
            this.category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(209, 24);
            this.category.TabIndex = 2;
            // 
            // vendor
            // 
            this.vendor.FormattingEnabled = true;
            this.vendor.Items.AddRange(new object[] {
            "Get Go Gas",
            "Meijers Gas",
            "Speedway",
            "BP Gas",
            "Walmart",
            "Amazon",
            "Target",
            "Tractor Supply",
            "Best Buy",
            "Staples",
            "Hobby Lobby"});
            this.vendor.Location = new System.Drawing.Point(172, 143);
            this.vendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vendor.Name = "vendor";
            this.vendor.Size = new System.Drawing.Size(209, 24);
            this.vendor.TabIndex = 3;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(172, 193);
            this.amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(209, 22);
            this.amount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dollar ammount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Expense Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(20, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Expense Vendor";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(172, 85);
            this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(209, 22);
            this.date.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Expense Category";
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(24, 223);
            this.finishButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(173, 37);
            this.finishButton.TabIndex = 10;
            this.finishButton.Text = "Add expense";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.Location = new System.Drawing.Point(203, 265);
            this.btnDeleteExpense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(179, 37);
            this.btnDeleteExpense.TabIndex = 11;
            this.btnDeleteExpense.Text = "Delete selected";
            this.btnDeleteExpense.UseVisualStyleBackColor = true;
            this.btnDeleteExpense.Click += new System.EventHandler(this.btnDeleteExpense_Click);
            // 
            // listViewExpenses
            // 
            this.listViewExpenses.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listViewExpenses.HideSelection = false;
            this.listViewExpenses.Location = new System.Drawing.Point(412, 30);
            this.listViewExpenses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewExpenses.Name = "listViewExpenses";
            this.listViewExpenses.Size = new System.Drawing.Size(667, 358);
            this.listViewExpenses.TabIndex = 12;
            this.listViewExpenses.UseCompatibleStateImageBehavior = false;
            this.listViewExpenses.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "$";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(24, 265);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(173, 37);
            this.btnSettings.TabIndex = 16;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.Location = new System.Drawing.Point(203, 223);
            this.btnEditSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(179, 37);
            this.btnEditSelected.TabIndex = 17;
            this.btnEditSelected.Text = "Edit Selected";
            this.btnEditSelected.UseVisualStyleBackColor = true;
            this.btnEditSelected.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // btnYTD
            // 
            this.btnYTD.Location = new System.Drawing.Point(24, 352);
            this.btnYTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYTD.Name = "btnYTD";
            this.btnYTD.Size = new System.Drawing.Size(357, 37);
            this.btnYTD.TabIndex = 18;
            this.btnYTD.Text = "View YTD Expenses";
            this.btnYTD.UseVisualStyleBackColor = true;
            this.btnYTD.Click += new System.EventHandler(this.btnYTD_Click);
            // 
            // btnMTD
            // 
            this.btnMTD.Location = new System.Drawing.Point(24, 306);
            this.btnMTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMTD.Name = "btnMTD";
            this.btnMTD.Size = new System.Drawing.Size(357, 37);
            this.btnMTD.TabIndex = 19;
            this.btnMTD.Text = "View MTD Expenses";
            this.btnMTD.UseVisualStyleBackColor = true;
            this.btnMTD.Click += new System.EventHandler(this.btnMTD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1095, 393);
            this.Controls.Add(this.btnMTD);
            this.Controls.Add(this.btnYTD);
            this.Controls.Add(this.btnEditSelected);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewExpenses);
            this.Controls.Add(this.btnDeleteExpense);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.vendor);
            this.Controls.Add(this.category);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1234, 440);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.ComboBox vendor;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.ListView listViewExpenses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.Button btnYTD;
        private System.Windows.Forms.Button btnMTD;
    }
}

