namespace TrackSmart
{
    partial class settingsForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.VendorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddExpenseCategoryButton = new System.Windows.Forms.Button();
            this.AddExpenseVendorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save and Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(548, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add new Expense Category:";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(294, 77);
            this.CategoryTextBox.Multiline = true;
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(179, 24);
            this.CategoryTextBox.TabIndex = 5;
            // 
            // VendorTextBox
            // 
            this.VendorTextBox.Location = new System.Drawing.Point(294, 114);
            this.VendorTextBox.Multiline = true;
            this.VendorTextBox.Name = "VendorTextBox";
            this.VendorTextBox.Size = new System.Drawing.Size(179, 24);
            this.VendorTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add new Expense Vendor:";
            // 
            // AddExpenseCategoryButton
            // 
            this.AddExpenseCategoryButton.Location = new System.Drawing.Point(479, 77);
            this.AddExpenseCategoryButton.Name = "AddExpenseCategoryButton";
            this.AddExpenseCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.AddExpenseCategoryButton.TabIndex = 8;
            this.AddExpenseCategoryButton.Text = "Add";
            this.AddExpenseCategoryButton.UseVisualStyleBackColor = true;
            this.AddExpenseCategoryButton.Click += new System.EventHandler(this.AddExpenseCategoryButton_Click);
            // 
            // AddExpenseVendorButton
            // 
            this.AddExpenseVendorButton.Location = new System.Drawing.Point(479, 114);
            this.AddExpenseVendorButton.Name = "AddExpenseVendorButton";
            this.AddExpenseVendorButton.Size = new System.Drawing.Size(75, 23);
            this.AddExpenseVendorButton.TabIndex = 9;
            this.AddExpenseVendorButton.Text = "Add ";
            this.AddExpenseVendorButton.UseVisualStyleBackColor = true;
            this.AddExpenseVendorButton.Click += new System.EventHandler(this.AddExpenseVendorButton_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddExpenseVendorButton);
            this.Controls.Add(this.AddExpenseCategoryButton);
            this.Controls.Add(this.VendorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "settingsForm";
            this.Text = "settingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox VendorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddExpenseCategoryButton;
        private System.Windows.Forms.Button AddExpenseVendorButton;
    }
}