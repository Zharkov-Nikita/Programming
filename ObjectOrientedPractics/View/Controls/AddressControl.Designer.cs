namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.AddressApartmentTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressBuildingTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressStreetTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressCityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressCountryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressIndexTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.AddressApartmentTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AddressBuildingTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddressStreetTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddressCityTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddressCountryTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddressIndexTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery Address";
            // 
            // AddressApartmentTextBox
            // 
            this.AddressApartmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressApartmentTextBox.Enabled = false;
            this.AddressApartmentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressApartmentTextBox.Location = new System.Drawing.Point(286, 119);
            this.AddressApartmentTextBox.Name = "AddressApartmentTextBox";
            this.AddressApartmentTextBox.Size = new System.Drawing.Size(85, 21);
            this.AddressApartmentTextBox.TabIndex = 11;
            this.AddressApartmentTextBox.TextChanged += new System.EventHandler(this.AddressApartmentTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(213, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Apartment:";
            // 
            // AddressBuildingTextBox
            // 
            this.AddressBuildingTextBox.Enabled = false;
            this.AddressBuildingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressBuildingTextBox.Location = new System.Drawing.Point(79, 119);
            this.AddressBuildingTextBox.Name = "AddressBuildingTextBox";
            this.AddressBuildingTextBox.Size = new System.Drawing.Size(105, 21);
            this.AddressBuildingTextBox.TabIndex = 9;
            this.AddressBuildingTextBox.TextChanged += new System.EventHandler(this.AddressBuildingTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Building:";
            // 
            // AddressStreetTextBox
            // 
            this.AddressStreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressStreetTextBox.Enabled = false;
            this.AddressStreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressStreetTextBox.Location = new System.Drawing.Point(79, 92);
            this.AddressStreetTextBox.Name = "AddressStreetTextBox";
            this.AddressStreetTextBox.Size = new System.Drawing.Size(292, 21);
            this.AddressStreetTextBox.TabIndex = 7;
            this.AddressStreetTextBox.TextChanged += new System.EventHandler(this.AddressStreetTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Street:";
            // 
            // AddressCityTextBox
            // 
            this.AddressCityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressCityTextBox.Enabled = false;
            this.AddressCityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressCityTextBox.Location = new System.Drawing.Point(267, 65);
            this.AddressCityTextBox.Name = "AddressCityTextBox";
            this.AddressCityTextBox.Size = new System.Drawing.Size(104, 21);
            this.AddressCityTextBox.TabIndex = 5;
            this.AddressCityTextBox.TextChanged += new System.EventHandler(this.AddressCityTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(232, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "City:";
            // 
            // AddressCountryTextBox
            // 
            this.AddressCountryTextBox.Enabled = false;
            this.AddressCountryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressCountryTextBox.Location = new System.Drawing.Point(79, 65);
            this.AddressCountryTextBox.Name = "AddressCountryTextBox";
            this.AddressCountryTextBox.Size = new System.Drawing.Size(147, 21);
            this.AddressCountryTextBox.TabIndex = 3;
            this.AddressCountryTextBox.TextChanged += new System.EventHandler(this.AddressCountryTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country:";
            // 
            // AddressIndexTextBox
            // 
            this.AddressIndexTextBox.Enabled = false;
            this.AddressIndexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressIndexTextBox.Location = new System.Drawing.Point(79, 38);
            this.AddressIndexTextBox.Name = "AddressIndexTextBox";
            this.AddressIndexTextBox.Size = new System.Drawing.Size(105, 21);
            this.AddressIndexTextBox.TabIndex = 1;
            this.AddressIndexTextBox.TextChanged += new System.EventHandler(this.AddressIndexTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Post Index:";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(432, 152);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AddressIndexTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressCityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddressCountryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddressApartmentTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddressBuildingTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddressStreetTextBox;
        private System.Windows.Forms.Label label4;
    }
}
