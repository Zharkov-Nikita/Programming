namespace ObjectOrientedPractics.View.Tabs
{
    partial class InterfacesTestTab
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ItemCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemCostTextBox = new System.Windows.Forms.TextBox();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemRemoveButton = new System.Windows.Forms.Button();
            this.ItemAddButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemCloneButton = new System.Windows.Forms.Button();
            this.ItemsListBox2 = new System.Windows.Forms.ListBox();
            this.ItemEquialsButton = new System.Windows.Forms.Button();
            this.ItemCompareButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ItemCategoryComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ItemNameTextBox);
            this.groupBox2.Controls.Add(this.ItemDescriptionTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ItemIdTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ItemCostTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(215, 3);
            this.groupBox2.MinimumSize = new System.Drawing.Size(313, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 375);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Item";
            // 
            // ItemCategoryComboBox
            // 
            this.ItemCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemCategoryComboBox.Enabled = false;
            this.ItemCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemCategoryComboBox.FormattingEnabled = true;
            this.ItemCategoryComboBox.Location = new System.Drawing.Point(80, 78);
            this.ItemCategoryComboBox.Name = "ItemCategoryComboBox";
            this.ItemCategoryComboBox.Size = new System.Drawing.Size(121, 24);
            this.ItemCategoryComboBox.TabIndex = 12;
            this.ItemCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemCategoryComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Category:";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemNameTextBox.Enabled = false;
            this.ItemNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemNameTextBox.Location = new System.Drawing.Point(7, 132);
            this.ItemNameTextBox.Multiline = true;
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ItemNameTextBox.Size = new System.Drawing.Size(299, 77);
            this.ItemNameTextBox.TabIndex = 8;
            this.ItemNameTextBox.TextChanged += new System.EventHandler(this.ItemNameTextBox_TextChanged);
            // 
            // ItemDescriptionTextBox
            // 
            this.ItemDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemDescriptionTextBox.Enabled = false;
            this.ItemDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemDescriptionTextBox.Location = new System.Drawing.Point(7, 235);
            this.ItemDescriptionTextBox.Multiline = true;
            this.ItemDescriptionTextBox.Name = "ItemDescriptionTextBox";
            this.ItemDescriptionTextBox.Size = new System.Drawing.Size(299, 77);
            this.ItemDescriptionTextBox.TabIndex = 10;
            this.ItemDescriptionTextBox.TextChanged += new System.EventHandler(this.ItemDescriptionTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cost:";
            // 
            // ItemIdTextBox
            // 
            this.ItemIdTextBox.Enabled = false;
            this.ItemIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemIdTextBox.Location = new System.Drawing.Point(80, 19);
            this.ItemIdTextBox.Name = "ItemIdTextBox";
            this.ItemIdTextBox.Size = new System.Drawing.Size(121, 23);
            this.ItemIdTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name:";
            // 
            // ItemCostTextBox
            // 
            this.ItemCostTextBox.Enabled = false;
            this.ItemCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemCostTextBox.Location = new System.Drawing.Point(80, 47);
            this.ItemCostTextBox.Name = "ItemCostTextBox";
            this.ItemCostTextBox.Size = new System.Drawing.Size(121, 23);
            this.ItemCostTextBox.TabIndex = 6;
            this.ItemCostTextBox.TextChanged += new System.EventHandler(this.ItemCostTextBox_TextChanged);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 17;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 19);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(200, 293);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // ItemRemoveButton
            // 
            this.ItemRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemRemoveButton.Location = new System.Drawing.Point(87, 337);
            this.ItemRemoveButton.Name = "ItemRemoveButton";
            this.ItemRemoveButton.Size = new System.Drawing.Size(75, 32);
            this.ItemRemoveButton.TabIndex = 12;
            this.ItemRemoveButton.Text = "Remove";
            this.ItemRemoveButton.UseVisualStyleBackColor = true;
            this.ItemRemoveButton.Click += new System.EventHandler(this.ItemRemoveButton_Click);
            // 
            // ItemAddButton
            // 
            this.ItemAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemAddButton.Location = new System.Drawing.Point(6, 337);
            this.ItemAddButton.Name = "ItemAddButton";
            this.ItemAddButton.Size = new System.Drawing.Size(75, 32);
            this.ItemAddButton.TabIndex = 11;
            this.ItemAddButton.Text = "Add";
            this.ItemAddButton.UseVisualStyleBackColor = true;
            this.ItemAddButton.Click += new System.EventHandler(this.ItemAddButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ItemsListBox);
            this.groupBox1.Controls.Add(this.ItemRemoveButton);
            this.groupBox1.Controls.Add(this.ItemAddButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.MinimumSize = new System.Drawing.Size(214, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 375);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // ItemCloneButton
            // 
            this.ItemCloneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemCloneButton.Location = new System.Drawing.Point(9, 384);
            this.ItemCloneButton.Name = "ItemCloneButton";
            this.ItemCloneButton.Size = new System.Drawing.Size(75, 32);
            this.ItemCloneButton.TabIndex = 13;
            this.ItemCloneButton.Text = "Clone";
            this.ItemCloneButton.UseVisualStyleBackColor = true;
            this.ItemCloneButton.Click += new System.EventHandler(this.ItemCloneButton_Click);
            // 
            // ItemsListBox2
            // 
            this.ItemsListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsListBox2.FormattingEnabled = true;
            this.ItemsListBox2.ItemHeight = 17;
            this.ItemsListBox2.Location = new System.Drawing.Point(9, 433);
            this.ItemsListBox2.Name = "ItemsListBox2";
            this.ItemsListBox2.Size = new System.Drawing.Size(200, 293);
            this.ItemsListBox2.TabIndex = 17;
            // 
            // ItemEquialsButton
            // 
            this.ItemEquialsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemEquialsButton.Location = new System.Drawing.Point(90, 384);
            this.ItemEquialsButton.Name = "ItemEquialsButton";
            this.ItemEquialsButton.Size = new System.Drawing.Size(75, 32);
            this.ItemEquialsButton.TabIndex = 18;
            this.ItemEquialsButton.Text = "Equials";
            this.ItemEquialsButton.UseVisualStyleBackColor = true;
            this.ItemEquialsButton.Click += new System.EventHandler(this.ItemEquialsButton_Click);
            // 
            // ItemCompareButton
            // 
            this.ItemCompareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemCompareButton.Location = new System.Drawing.Point(171, 384);
            this.ItemCompareButton.Name = "ItemCompareButton";
            this.ItemCompareButton.Size = new System.Drawing.Size(75, 32);
            this.ItemCompareButton.TabIndex = 19;
            this.ItemCompareButton.Text = "Compare";
            this.ItemCompareButton.UseVisualStyleBackColor = true;
            this.ItemCompareButton.Click += new System.EventHandler(this.ItemCompareButton_Click);
            // 
            // InterfacesTestTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemCompareButton);
            this.Controls.Add(this.ItemEquialsButton);
            this.Controls.Add(this.ItemsListBox2);
            this.Controls.Add(this.ItemCloneButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InterfacesTestTab";
            this.Size = new System.Drawing.Size(576, 814);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ItemCategoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.TextBox ItemDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ItemIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemCostTextBox;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button ItemRemoveButton;
        private System.Windows.Forms.Button ItemAddButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ItemCloneButton;
        private System.Windows.Forms.ListBox ItemsListBox2;
        private System.Windows.Forms.Button ItemEquialsButton;
        private System.Windows.Forms.Button ItemCompareButton;
    }
}
