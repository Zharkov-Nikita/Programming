namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomerRemoveButton = new System.Windows.Forms.Button();
            this.CustomerAddButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.CustomerFullNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CustomerDiscountsRemoveButton = new System.Windows.Forms.Button();
            this.CustomerDiscountsAddButton = new System.Windows.Forms.Button();
            this.CustomerDiscountsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerIsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomerAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.CustomersListBox);
            this.groupBox1.Controls.Add(this.CustomerRemoveButton);
            this.groupBox1.Controls.Add(this.CustomerAddButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.MinimumSize = new System.Drawing.Size(214, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 415);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(6, 19);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(200, 342);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomerRemoveButton
            // 
            this.CustomerRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomerRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerRemoveButton.Location = new System.Drawing.Point(87, 377);
            this.CustomerRemoveButton.Name = "CustomerRemoveButton";
            this.CustomerRemoveButton.Size = new System.Drawing.Size(75, 32);
            this.CustomerRemoveButton.TabIndex = 12;
            this.CustomerRemoveButton.Text = "Remove";
            this.CustomerRemoveButton.UseVisualStyleBackColor = true;
            this.CustomerRemoveButton.Click += new System.EventHandler(this.CustomerRemoveButton_Click);
            // 
            // CustomerAddButton
            // 
            this.CustomerAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomerAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerAddButton.Location = new System.Drawing.Point(6, 377);
            this.CustomerAddButton.Name = "CustomerAddButton";
            this.CustomerAddButton.Size = new System.Drawing.Size(75, 32);
            this.CustomerAddButton.TabIndex = 11;
            this.CustomerAddButton.Text = "Add";
            this.CustomerAddButton.UseVisualStyleBackColor = true;
            this.CustomerAddButton.Click += new System.EventHandler(this.CustomerAddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Full Name:";
            // 
            // CustomerIdTextBox
            // 
            this.CustomerIdTextBox.Enabled = false;
            this.CustomerIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerIdTextBox.Location = new System.Drawing.Point(77, 19);
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.Size = new System.Drawing.Size(111, 20);
            this.CustomerIdTextBox.TabIndex = 5;
            // 
            // CustomerFullNameTextBox
            // 
            this.CustomerFullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerFullNameTextBox.Enabled = false;
            this.CustomerFullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerFullNameTextBox.Location = new System.Drawing.Point(77, 44);
            this.CustomerFullNameTextBox.Name = "CustomerFullNameTextBox";
            this.CustomerFullNameTextBox.Size = new System.Drawing.Size(533, 20);
            this.CustomerFullNameTextBox.TabIndex = 6;
            this.CustomerFullNameTextBox.TextChanged += new System.EventHandler(this.CustomerFullNameTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CustomerDiscountsRemoveButton);
            this.groupBox2.Controls.Add(this.CustomerDiscountsAddButton);
            this.groupBox2.Controls.Add(this.CustomerDiscountsListBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CustomerIsPriorityCheckBox);
            this.groupBox2.Controls.Add(this.CustomerAddressControl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CustomerIdTextBox);
            this.groupBox2.Controls.Add(this.CustomerFullNameTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(215, 1);
            this.groupBox2.MinimumSize = new System.Drawing.Size(313, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 415);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Customer";
            // 
            // CustomerDiscountsRemoveButton
            // 
            this.CustomerDiscountsRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerDiscountsRemoveButton.Location = new System.Drawing.Point(326, 329);
            this.CustomerDiscountsRemoveButton.Name = "CustomerDiscountsRemoveButton";
            this.CustomerDiscountsRemoveButton.Size = new System.Drawing.Size(75, 32);
            this.CustomerDiscountsRemoveButton.TabIndex = 13;
            this.CustomerDiscountsRemoveButton.Text = "Remove";
            this.CustomerDiscountsRemoveButton.UseVisualStyleBackColor = true;
            this.CustomerDiscountsRemoveButton.Click += new System.EventHandler(this.CustomerDiscountsRemoveButton_Click);
            // 
            // CustomerDiscountsAddButton
            // 
            this.CustomerDiscountsAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerDiscountsAddButton.Location = new System.Drawing.Point(326, 283);
            this.CustomerDiscountsAddButton.Name = "CustomerDiscountsAddButton";
            this.CustomerDiscountsAddButton.Size = new System.Drawing.Size(75, 32);
            this.CustomerDiscountsAddButton.TabIndex = 13;
            this.CustomerDiscountsAddButton.Text = "Add";
            this.CustomerDiscountsAddButton.UseVisualStyleBackColor = true;
            this.CustomerDiscountsAddButton.Click += new System.EventHandler(this.CustomerDiscountsAddButton_Click);
            // 
            // CustomerDiscountsListBox
            // 
            this.CustomerDiscountsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerDiscountsListBox.FormattingEnabled = true;
            this.CustomerDiscountsListBox.Location = new System.Drawing.Point(12, 283);
            this.CustomerDiscountsListBox.Name = "CustomerDiscountsListBox";
            this.CustomerDiscountsListBox.Size = new System.Drawing.Size(308, 108);
            this.CustomerDiscountsListBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Discounts";
            // 
            // CustomerIsPriorityCheckBox
            // 
            this.CustomerIsPriorityCheckBox.AutoSize = true;
            this.CustomerIsPriorityCheckBox.Enabled = false;
            this.CustomerIsPriorityCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerIsPriorityCheckBox.Location = new System.Drawing.Point(77, 80);
            this.CustomerIsPriorityCheckBox.Name = "CustomerIsPriorityCheckBox";
            this.CustomerIsPriorityCheckBox.Size = new System.Drawing.Size(68, 17);
            this.CustomerIsPriorityCheckBox.TabIndex = 8;
            this.CustomerIsPriorityCheckBox.Text = "Is Priority";
            this.CustomerIsPriorityCheckBox.UseVisualStyleBackColor = true;
            this.CustomerIsPriorityCheckBox.CheckedChanged += new System.EventHandler(this.CustomerIsPriorityCheckBox_CheckedChanged);
            // 
            // CustomerAddressControl
            // 
            this.CustomerAddressControl.Address = null;
            this.CustomerAddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerAddressControl.Location = new System.Drawing.Point(9, 108);
            this.CustomerAddressControl.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerAddressControl.Name = "CustomerAddressControl";
            this.CustomerAddressControl.Size = new System.Drawing.Size(601, 150);
            this.CustomerAddressControl.TabIndex = 7;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(834, 419);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Button CustomerRemoveButton;
        private System.Windows.Forms.Button CustomerAddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerIdTextBox;
        private System.Windows.Forms.TextBox CustomerFullNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.AddressControl CustomerAddressControl;
        private System.Windows.Forms.CheckBox CustomerIsPriorityCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CustomerDiscountsListBox;
        private System.Windows.Forms.Button CustomerDiscountsRemoveButton;
        private System.Windows.Forms.Button CustomerDiscountsAddButton;
    }
}
