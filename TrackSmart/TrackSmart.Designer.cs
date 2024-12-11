namespace TrackSmart
{
    partial class TrackSmart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackSmart));
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnViewExpenses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // category
            // 
            this.category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(130, 62);
            this.category.Margin = new System.Windows.Forms.Padding(2);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(247, 21);
            this.category.TabIndex = 2;
            // 
            // vendor
            // 
            this.vendor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendor.FormattingEnabled = true;
            this.vendor.Location = new System.Drawing.Point(130, 131);
            this.vendor.Margin = new System.Windows.Forms.Padding(2);
            this.vendor.Name = "vendor";
            this.vendor.Size = new System.Drawing.Size(247, 21);
            this.vendor.TabIndex = 3;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(130, 161);
            this.amount.Margin = new System.Windows.Forms.Padding(2);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(247, 20);
            this.amount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(42, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(62, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(42, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vendor:";
            // 
            // date
            // 
            this.date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date.Location = new System.Drawing.Point(130, 95);
            this.date.Margin = new System.Windows.Forms.Padding(2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(247, 20);
            this.date.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(29, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category:";
            // 
            // finishButton
            // 
            this.finishButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.finishButton.Location = new System.Drawing.Point(381, 61);
            this.finishButton.Margin = new System.Windows.Forms.Padding(2);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(107, 30);
            this.finishButton.TabIndex = 10;
            this.finishButton.Text = "Add expense";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteExpense.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteExpense.Location = new System.Drawing.Point(492, 104);
            this.btnDeleteExpense.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(124, 30);
            this.btnDeleteExpense.TabIndex = 11;
            this.btnDeleteExpense.Text = "Delete selected";
            this.btnDeleteExpense.UseVisualStyleBackColor = true;
            this.btnDeleteExpense.Click += new System.EventHandler(this.btnDeleteExpense_Click);
            // 
            // listViewExpenses
            // 
            this.listViewExpenses.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listViewExpenses.HideSelection = false;
            this.listViewExpenses.Location = new System.Drawing.Point(66, 238);
            this.listViewExpenses.Margin = new System.Windows.Forms.Padding(2);
            this.listViewExpenses.Name = "listViewExpenses";
            this.listViewExpenses.Size = new System.Drawing.Size(520, 249);
            this.listViewExpenses.TabIndex = 12;
            this.listViewExpenses.UseCompatibleStateImageBehavior = false;
            this.listViewExpenses.View = System.Windows.Forms.View.Details;
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSettings.Location = new System.Drawing.Point(381, 104);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(107, 30);
            this.btnSettings.TabIndex = 16;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSelected.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditSelected.Location = new System.Drawing.Point(492, 61);
            this.btnEditSelected.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(124, 30);
            this.btnEditSelected.TabIndex = 17;
            this.btnEditSelected.Text = "Edit Selected";
            this.btnEditSelected.UseVisualStyleBackColor = true;
            this.btnEditSelected.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(256, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "TrackSmart";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(254, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Expense Logs";
            // 
            // btnViewExpenses
            // 
            this.btnViewExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewExpenses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewExpenses.Location = new System.Drawing.Point(381, 147);
            this.btnViewExpenses.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewExpenses.Name = "btnViewExpenses";
            this.btnViewExpenses.Size = new System.Drawing.Size(235, 33);
            this.btnViewExpenses.TabIndex = 22;
            this.btnViewExpenses.Text = " View Expenses";
            this.btnViewExpenses.UseVisualStyleBackColor = true;
            this.btnViewExpenses.Click += new System.EventHandler(this.btnViewExpenses_Click);
            // 
            // TrackSmart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(656, 498);
            this.Controls.Add(this.btnViewExpenses);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEditSelected);
            this.Controls.Add(this.btnSettings);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(999, 999);
            this.Name = "TrackSmart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackSmart";
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
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnViewExpenses;
    }
}

