namespace BuildingsApp
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuildingsListBox = new System.Windows.Forms.ListBox();
            this.SelectedBuildingGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SelectedBuildingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuildingsListBox
            // 
            this.BuildingsListBox.FormattingEnabled = true;
            this.BuildingsListBox.Location = new System.Drawing.Point(13, 13);
            this.BuildingsListBox.Name = "BuildingsListBox";
            this.BuildingsListBox.Size = new System.Drawing.Size(276, 420);
            this.BuildingsListBox.TabIndex = 0;
            // 
            // SelectedBuildingGroupBox
            // 
            this.SelectedBuildingGroupBox.Controls.Add(this.RatingTextBox);
            this.SelectedBuildingGroupBox.Controls.Add(this.CategoryComboBox);
            this.SelectedBuildingGroupBox.Controls.Add(this.AddressTextBox);
            this.SelectedBuildingGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedBuildingGroupBox.Controls.Add(this.label4);
            this.SelectedBuildingGroupBox.Controls.Add(this.label3);
            this.SelectedBuildingGroupBox.Controls.Add(this.label2);
            this.SelectedBuildingGroupBox.Controls.Add(this.label1);
            this.SelectedBuildingGroupBox.Location = new System.Drawing.Point(295, 13);
            this.SelectedBuildingGroupBox.Name = "SelectedBuildingGroupBox";
            this.SelectedBuildingGroupBox.Size = new System.Drawing.Size(493, 121);
            this.SelectedBuildingGroupBox.TabIndex = 1;
            this.SelectedBuildingGroupBox.TabStop = false;
            this.SelectedBuildingGroupBox.Text = "Выбранное здание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Рейтинг:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Категория:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(77, 17);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(410, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(77, 42);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(410, 20);
            this.AddressTextBox.TabIndex = 5;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(77, 67);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(210, 21);
            this.CategoryComboBox.TabIndex = 6;
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(77, 92);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(51, 20);
            this.RatingTextBox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(296, 141);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(378, 141);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SelectedBuildingGroupBox);
            this.Controls.Add(this.BuildingsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SelectedBuildingGroupBox.ResumeLayout(false);
            this.SelectedBuildingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BuildingsListBox;
        private System.Windows.Forms.GroupBox SelectedBuildingGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

