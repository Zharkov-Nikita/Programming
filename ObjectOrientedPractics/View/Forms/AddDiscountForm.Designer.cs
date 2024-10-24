namespace ObjectOrientedPractics.View.Forms
{
    partial class AddDiscountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddDiscountCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AddDiscountOkButton = new System.Windows.Forms.Button();
            this.AddDiscountCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Percent Discount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // AddDiscountCategoryComboBox
            // 
            this.AddDiscountCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDiscountCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddDiscountCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDiscountCategoryComboBox.FormattingEnabled = true;
            this.AddDiscountCategoryComboBox.Location = new System.Drawing.Point(70, 34);
            this.AddDiscountCategoryComboBox.Name = "AddDiscountCategoryComboBox";
            this.AddDiscountCategoryComboBox.Size = new System.Drawing.Size(198, 21);
            this.AddDiscountCategoryComboBox.TabIndex = 13;
            // 
            // AddDiscountOkButton
            // 
            this.AddDiscountOkButton.Location = new System.Drawing.Point(78, 86);
            this.AddDiscountOkButton.Name = "AddDiscountOkButton";
            this.AddDiscountOkButton.Size = new System.Drawing.Size(92, 35);
            this.AddDiscountOkButton.TabIndex = 14;
            this.AddDiscountOkButton.Text = "Ok";
            this.AddDiscountOkButton.UseVisualStyleBackColor = true;
            this.AddDiscountOkButton.Click += new System.EventHandler(this.AddDiscountOkButton_Click);
            // 
            // AddDiscountCancelButton
            // 
            this.AddDiscountCancelButton.Location = new System.Drawing.Point(176, 86);
            this.AddDiscountCancelButton.Name = "AddDiscountCancelButton";
            this.AddDiscountCancelButton.Size = new System.Drawing.Size(92, 35);
            this.AddDiscountCancelButton.TabIndex = 15;
            this.AddDiscountCancelButton.Text = "Cancel";
            this.AddDiscountCancelButton.UseVisualStyleBackColor = true;
            this.AddDiscountCancelButton.Click += new System.EventHandler(this.AddDiscountCancelButton_Click);
            // 
            // AddDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 142);
            this.Controls.Add(this.AddDiscountCancelButton);
            this.Controls.Add(this.AddDiscountOkButton);
            this.Controls.Add(this.AddDiscountCategoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDiscountForm";
            this.Text = "Add Discount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AddDiscountCategoryComboBox;
        private System.Windows.Forms.Button AddDiscountOkButton;
        private System.Windows.Forms.Button AddDiscountCancelButton;
    }
}