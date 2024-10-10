namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            this.label7 = new System.Windows.Forms.Label();
            this.OrderAmountLabel = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OrderAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.OrderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderCreatedTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearOrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OrderDeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(351, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Amount:";
            // 
            // OrderAmountLabel
            // 
            this.OrderAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderAmountLabel.Location = new System.Drawing.Point(315, 407);
            this.OrderAmountLabel.Name = "OrderAmountLabel";
            this.OrderAmountLabel.Size = new System.Drawing.Size(103, 23);
            this.OrderAmountLabel.TabIndex = 31;
            this.OrderAmountLabel.Text = "0";
            this.OrderAmountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 15;
            this.OrderItemsListBox.Location = new System.Drawing.Point(13, 280);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(383, 109);
            this.OrderItemsListBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Order Items";
            // 
            // OrderAddressControl
            // 
            this.OrderAddressControl.Address = null;
            this.OrderAddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderAddressControl.Location = new System.Drawing.Point(10, 106);
            this.OrderAddressControl.Name = "OrderAddressControl";
            this.OrderAddressControl.Size = new System.Drawing.Size(441, 152);
            this.OrderAddressControl.TabIndex = 27;
            // 
            // OrderStatusComboBox
            // 
            this.OrderStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderStatusComboBox.FormattingEnabled = true;
            this.OrderStatusComboBox.Location = new System.Drawing.Point(76, 79);
            this.OrderStatusComboBox.Name = "OrderStatusComboBox";
            this.OrderStatusComboBox.Size = new System.Drawing.Size(122, 21);
            this.OrderStatusComboBox.TabIndex = 26;
            this.OrderStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderStatusComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Status:";
            // 
            // OrderCreatedTextBox
            // 
            this.OrderCreatedTextBox.Enabled = false;
            this.OrderCreatedTextBox.Location = new System.Drawing.Point(76, 51);
            this.OrderCreatedTextBox.Name = "OrderCreatedTextBox";
            this.OrderCreatedTextBox.Size = new System.Drawing.Size(122, 20);
            this.OrderCreatedTextBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Created:";
            // 
            // OrderIdTextBox
            // 
            this.OrderIdTextBox.Enabled = false;
            this.OrderIdTextBox.Location = new System.Drawing.Point(76, 25);
            this.OrderIdTextBox.Name = "OrderIdTextBox";
            this.OrderIdTextBox.Size = new System.Drawing.Size(122, 20);
            this.OrderIdTextBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "SelectedOrder";
            // 
            // AddItemButton
            // 
            this.AddItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddItemButton.Location = new System.Drawing.Point(13, 434);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(103, 39);
            this.AddItemButton.TabIndex = 32;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveItemButton.Location = new System.Drawing.Point(122, 434);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(103, 39);
            this.RemoveItemButton.TabIndex = 34;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearOrderButton.Location = new System.Drawing.Point(315, 434);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(103, 39);
            this.ClearOrderButton.TabIndex = 33;
            this.ClearOrderButton.Text = "Clear Order";
            this.ClearOrderButton.UseVisualStyleBackColor = true;
            this.ClearOrderButton.Click += new System.EventHandler(this.ClearOrderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(233, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Priority Options";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Delivery Time:";
            // 
            // OrderDeliveryTimeComboBox
            // 
            this.OrderDeliveryTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderDeliveryTimeComboBox.FormattingEnabled = true;
            this.OrderDeliveryTimeComboBox.Items.AddRange(new object[] {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"});
            this.OrderDeliveryTimeComboBox.Location = new System.Drawing.Point(319, 25);
            this.OrderDeliveryTimeComboBox.Name = "OrderDeliveryTimeComboBox";
            this.OrderDeliveryTimeComboBox.Size = new System.Drawing.Size(122, 21);
            this.OrderDeliveryTimeComboBox.TabIndex = 37;
            this.OrderDeliveryTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderDeliveryTimeComboBox_SelectedIndexChanged);
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrderDeliveryTimeComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.ClearOrderButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OrderAmountLabel);
            this.Controls.Add(this.OrderItemsListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OrderAddressControl);
            this.Controls.Add(this.OrderStatusComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrderCreatedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(461, 478);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label OrderAmountLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Label label6;
        private Controls.AddressControl OrderAddressControl;
        private System.Windows.Forms.ComboBox OrderStatusComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OrderCreatedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrderIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox OrderDeliveryTimeComboBox;
    }
}
