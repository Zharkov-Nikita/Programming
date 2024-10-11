namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.OrdersIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersCreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersCustomerFullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersDeliveryAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderIdTextBox = new System.Windows.Forms.TextBox();
            this.OrderCreatedTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrderAmountLabel = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.OrderDeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PriorityOrderPanel = new System.Windows.Forms.Panel();
            this.OrderAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.PriorityOrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.AllowUserToResizeColumns = false;
            this.OrdersDataGridView.AllowUserToResizeRows = false;
            this.OrdersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdersIdColumn,
            this.OrdersCreatedColumn,
            this.OrdersStatusColumn,
            this.OrdersCustomerFullNameColumn,
            this.OrdersDeliveryAddressColumn,
            this.OrdersAmountColumn});
            this.OrdersDataGridView.Location = new System.Drawing.Point(3, 19);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.RowHeadersVisible = false;
            this.OrdersDataGridView.RowHeadersWidth = 51;
            this.OrdersDataGridView.Size = new System.Drawing.Size(367, 457);
            this.OrdersDataGridView.TabIndex = 0;
            this.OrdersDataGridView.SelectionChanged += new System.EventHandler(this.OrdersDataGridView_SelectionChanged);
            // 
            // OrdersIdColumn
            // 
            this.OrdersIdColumn.HeaderText = "Id";
            this.OrdersIdColumn.MinimumWidth = 6;
            this.OrdersIdColumn.Name = "OrdersIdColumn";
            this.OrdersIdColumn.ReadOnly = true;
            this.OrdersIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrdersIdColumn.Width = 125;
            // 
            // OrdersCreatedColumn
            // 
            this.OrdersCreatedColumn.HeaderText = "Created";
            this.OrdersCreatedColumn.MinimumWidth = 6;
            this.OrdersCreatedColumn.Name = "OrdersCreatedColumn";
            this.OrdersCreatedColumn.ReadOnly = true;
            this.OrdersCreatedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrdersCreatedColumn.Width = 125;
            // 
            // OrdersStatusColumn
            // 
            this.OrdersStatusColumn.HeaderText = "Order Status";
            this.OrdersStatusColumn.MinimumWidth = 6;
            this.OrdersStatusColumn.Name = "OrdersStatusColumn";
            this.OrdersStatusColumn.ReadOnly = true;
            this.OrdersStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrdersStatusColumn.Width = 125;
            // 
            // OrdersCustomerFullNameColumn
            // 
            this.OrdersCustomerFullNameColumn.HeaderText = "Customer Full Name";
            this.OrdersCustomerFullNameColumn.MinimumWidth = 6;
            this.OrdersCustomerFullNameColumn.Name = "OrdersCustomerFullNameColumn";
            this.OrdersCustomerFullNameColumn.ReadOnly = true;
            this.OrdersCustomerFullNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrdersCustomerFullNameColumn.Width = 125;
            // 
            // OrdersDeliveryAddressColumn
            // 
            this.OrdersDeliveryAddressColumn.HeaderText = "Delivery Address";
            this.OrdersDeliveryAddressColumn.MinimumWidth = 6;
            this.OrdersDeliveryAddressColumn.Name = "OrdersDeliveryAddressColumn";
            this.OrdersDeliveryAddressColumn.ReadOnly = true;
            this.OrdersDeliveryAddressColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrdersDeliveryAddressColumn.Width = 125;
            // 
            // OrdersAmountColumn
            // 
            this.OrdersAmountColumn.HeaderText = "Amount";
            this.OrdersAmountColumn.MinimumWidth = 6;
            this.OrdersAmountColumn.Name = "OrdersAmountColumn";
            this.OrdersAmountColumn.ReadOnly = true;
            this.OrdersAmountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrdersAmountColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(376, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "SelectedOrder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            // 
            // OrderIdTextBox
            // 
            this.OrderIdTextBox.Enabled = false;
            this.OrderIdTextBox.Location = new System.Drawing.Point(442, 25);
            this.OrderIdTextBox.Name = "OrderIdTextBox";
            this.OrderIdTextBox.Size = new System.Drawing.Size(122, 20);
            this.OrderIdTextBox.TabIndex = 4;
            // 
            // OrderCreatedTextBox
            // 
            this.OrderCreatedTextBox.Enabled = false;
            this.OrderCreatedTextBox.Location = new System.Drawing.Point(442, 51);
            this.OrderCreatedTextBox.Name = "OrderCreatedTextBox";
            this.OrderCreatedTextBox.Size = new System.Drawing.Size(122, 20);
            this.OrderCreatedTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Created:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status:";
            // 
            // OrderStatusComboBox
            // 
            this.OrderStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderStatusComboBox.FormattingEnabled = true;
            this.OrderStatusComboBox.Location = new System.Drawing.Point(442, 79);
            this.OrderStatusComboBox.Name = "OrderStatusComboBox";
            this.OrderStatusComboBox.Size = new System.Drawing.Size(122, 21);
            this.OrderStatusComboBox.TabIndex = 8;
            this.OrderStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderStatusComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(376, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Order Items";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(734, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Amount:";
            // 
            // OrderAmountLabel
            // 
            this.OrderAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderAmountLabel.Location = new System.Drawing.Point(681, 448);
            this.OrderAmountLabel.Name = "OrderAmountLabel";
            this.OrderAmountLabel.Size = new System.Drawing.Size(120, 23);
            this.OrderAmountLabel.TabIndex = 19;
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
            this.OrderItemsListBox.Location = new System.Drawing.Point(379, 280);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(394, 139);
            this.OrderItemsListBox.TabIndex = 17;
            // 
            // OrderDeliveryTimeComboBox
            // 
            this.OrderDeliveryTimeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDeliveryTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderDeliveryTimeComboBox.FormattingEnabled = true;
            this.OrderDeliveryTimeComboBox.Items.AddRange(new object[] {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"});
            this.OrderDeliveryTimeComboBox.Location = new System.Drawing.Point(91, 25);
            this.OrderDeliveryTimeComboBox.Name = "OrderDeliveryTimeComboBox";
            this.OrderDeliveryTimeComboBox.Size = new System.Drawing.Size(122, 21);
            this.OrderDeliveryTimeComboBox.TabIndex = 40;
            this.OrderDeliveryTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderDeliveryTimeComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Delivery Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "Priority Options";
            // 
            // PriorityOrderPanel
            // 
            this.PriorityOrderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriorityOrderPanel.Controls.Add(this.label9);
            this.PriorityOrderPanel.Controls.Add(this.OrderDeliveryTimeComboBox);
            this.PriorityOrderPanel.Controls.Add(this.label8);
            this.PriorityOrderPanel.Location = new System.Drawing.Point(581, 0);
            this.PriorityOrderPanel.Name = "PriorityOrderPanel";
            this.PriorityOrderPanel.Size = new System.Drawing.Size(216, 100);
            this.PriorityOrderPanel.TabIndex = 41;
            this.PriorityOrderPanel.Visible = false;
            // 
            // OrderAddressControl
            // 
            this.OrderAddressControl.Address = null;
            this.OrderAddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderAddressControl.Location = new System.Drawing.Point(376, 106);
            this.OrderAddressControl.Name = "OrderAddressControl";
            this.OrderAddressControl.Size = new System.Drawing.Size(458, 152);
            this.OrderAddressControl.TabIndex = 9;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PriorityOrderPanel);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrdersDataGridView);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(811, 479);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.PriorityOrderPanel.ResumeLayout(false);
            this.PriorityOrderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrderIdTextBox;
        private System.Windows.Forms.TextBox OrderCreatedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox OrderStatusComboBox;
        private Controls.AddressControl OrderAddressControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label OrderAmountLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersCreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersCustomerFullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersDeliveryAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersAmountColumn;
        private System.Windows.Forms.ComboBox OrderDeliveryTimeComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel PriorityOrderPanel;
    }
}
