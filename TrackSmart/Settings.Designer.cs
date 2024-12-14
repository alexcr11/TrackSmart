namespace TrackSmart
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.closeButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.VendorTextBox = new System.Windows.Forms.TextBox();
            this.AddExpenseCategoryButton = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.ComboBox();
            this.vendor = new System.Windows.Forms.ComboBox();
            this.RemoveExpenseCategoryButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddExpenseVendorButton = new System.Windows.Forms.Button();
            this.RemoveExpenseVendorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateChecker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButon
            // 
            this.closeButon.Location = new System.Drawing.Point(434, 288);
            this.closeButon.Name = "closeButon";
            this.closeButon.Size = new System.Drawing.Size(92, 34);
            this.closeButon.TabIndex = 2;
            this.closeButon.Text = "Close";
            this.closeButon.UseVisualStyleBackColor = true;
            this.closeButon.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(226, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Settings";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CategoryTextBox.Location = new System.Drawing.Point(215, 105);
            this.CategoryTextBox.Multiline = true;
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(179, 24);
            this.CategoryTextBox.TabIndex = 5;
            // 
            // VendorTextBox
            // 
            this.VendorTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VendorTextBox.Location = new System.Drawing.Point(215, 143);
            this.VendorTextBox.Multiline = true;
            this.VendorTextBox.Name = "VendorTextBox";
            this.VendorTextBox.Size = new System.Drawing.Size(179, 24);
            this.VendorTextBox.TabIndex = 7;
            // 
            // AddExpenseCategoryButton
            // 
            this.AddExpenseCategoryButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddExpenseCategoryButton.Location = new System.Drawing.Point(400, 103);
            this.AddExpenseCategoryButton.Name = "AddExpenseCategoryButton";
            this.AddExpenseCategoryButton.Size = new System.Drawing.Size(81, 32);
            this.AddExpenseCategoryButton.TabIndex = 8;
            this.AddExpenseCategoryButton.Text = "Add";
            this.AddExpenseCategoryButton.UseVisualStyleBackColor = true;
            this.AddExpenseCategoryButton.Click += new System.EventHandler(this.AddExpenseCategoryButton_Click);
            // 
            // category
            // 
            this.category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(215, 193);
            this.category.Margin = new System.Windows.Forms.Padding(2);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(179, 21);
            this.category.TabIndex = 12;
            // 
            // vendor
            // 
            this.vendor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vendor.FormattingEnabled = true;
            this.vendor.Location = new System.Drawing.Point(214, 228);
            this.vendor.Margin = new System.Windows.Forms.Padding(2);
            this.vendor.Name = "vendor";
            this.vendor.Size = new System.Drawing.Size(179, 21);
            this.vendor.TabIndex = 13;
            // 
            // RemoveExpenseCategoryButton
            // 
            this.RemoveExpenseCategoryButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveExpenseCategoryButton.Location = new System.Drawing.Point(399, 186);
            this.RemoveExpenseCategoryButton.Name = "RemoveExpenseCategoryButton";
            this.RemoveExpenseCategoryButton.Size = new System.Drawing.Size(81, 32);
            this.RemoveExpenseCategoryButton.TabIndex = 14;
            this.RemoveExpenseCategoryButton.Text = "Remove";
            this.RemoveExpenseCategoryButton.UseVisualStyleBackColor = true;
            this.RemoveExpenseCategoryButton.Click += new System.EventHandler(this.RemoveExpenseCategoryButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Version 1.0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(12, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "@2024 Created by Alexander Crone";
            // 
            // AddExpenseVendorButton
            // 
            this.AddExpenseVendorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddExpenseVendorButton.Location = new System.Drawing.Point(400, 138);
            this.AddExpenseVendorButton.Name = "AddExpenseVendorButton";
            this.AddExpenseVendorButton.Size = new System.Drawing.Size(81, 32);
            this.AddExpenseVendorButton.TabIndex = 19;
            this.AddExpenseVendorButton.Text = "Add";
            this.AddExpenseVendorButton.UseVisualStyleBackColor = true;
            this.AddExpenseVendorButton.Click += new System.EventHandler(this.AddExpenseVendorButton_Click);
            // 
            // RemoveExpenseVendorButton
            // 
            this.RemoveExpenseVendorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveExpenseVendorButton.Location = new System.Drawing.Point(398, 228);
            this.RemoveExpenseVendorButton.Name = "RemoveExpenseVendorButton";
            this.RemoveExpenseVendorButton.Size = new System.Drawing.Size(81, 32);
            this.RemoveExpenseVendorButton.TabIndex = 20;
            this.RemoveExpenseVendorButton.Text = "Remove";
            this.RemoveExpenseVendorButton.UseVisualStyleBackColor = true;
            this.RemoveExpenseVendorButton.Click += new System.EventHandler(this.RemoveExpenseVendorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(76, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Create new Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(86, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Create new Vendor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(95, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Remove Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(102, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Remove Vendor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(76, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(412, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "WARNING! anything done in this window will save automatically.";
            // 
            // btnUpdateChecker
            // 
            this.btnUpdateChecker.Location = new System.Drawing.Point(283, 288);
            this.btnUpdateChecker.Name = "btnUpdateChecker";
            this.btnUpdateChecker.Size = new System.Drawing.Size(120, 34);
            this.btnUpdateChecker.TabIndex = 26;
            this.btnUpdateChecker.Text = "Check for updates";
            this.btnUpdateChecker.UseVisualStyleBackColor = true;
            this.btnUpdateChecker.Click += new System.EventHandler(this.btnUpdateChecker_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(541, 331);
            this.Controls.Add(this.btnUpdateChecker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveExpenseVendorButton);
            this.Controls.Add(this.AddExpenseVendorButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RemoveExpenseCategoryButton);
            this.Controls.Add(this.vendor);
            this.Controls.Add(this.category);
            this.Controls.Add(this.AddExpenseCategoryButton);
            this.Controls.Add(this.VendorTextBox);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox VendorTextBox;
        private System.Windows.Forms.Button AddExpenseCategoryButton;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.ComboBox vendor;
        private System.Windows.Forms.Button RemoveExpenseCategoryButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddExpenseVendorButton;
        private System.Windows.Forms.Button RemoveExpenseVendorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateChecker;
    }
}