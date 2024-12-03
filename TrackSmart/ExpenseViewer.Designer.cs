namespace TrackSmart
{
    partial class ExpenseViewer
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
            this.label2 = new System.Windows.Forms.Label();
            this.closeButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expense Page (Still in works)";
            // 
            // closeButon
            // 
            this.closeButon.Location = new System.Drawing.Point(696, 404);
            this.closeButon.Name = "closeButon";
            this.closeButon.Size = new System.Drawing.Size(92, 34);
            this.closeButon.TabIndex = 3;
            this.closeButon.Text = "Close";
            this.closeButon.UseVisualStyleBackColor = true;
            this.closeButon.Click += new System.EventHandler(this.closeButon_Click);
            // 
            // ExpenseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButon);
            this.Controls.Add(this.label2);
            this.Name = "ExpenseViewer";
            this.Text = "ExpenseViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeButon;
    }
}