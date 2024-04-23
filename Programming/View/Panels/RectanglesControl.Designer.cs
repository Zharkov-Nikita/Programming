namespace Programming.View.Panels
{
    partial class RectanglesControl
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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesIdTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.RectanglesCenterYTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.RectanglesCenterXTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.RectanglesFindButton = new System.Windows.Forms.Button();
            this.RectanglesColorTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesWidthTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RectanglesLenghtTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.RectanglesGroupBox.Controls.Add(this.RectanglesIdTextBox);
            this.RectanglesGroupBox.Controls.Add(this.label16);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesCenterYTextBox);
            this.RectanglesGroupBox.Controls.Add(this.label15);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesCenterXTextBox);
            this.RectanglesGroupBox.Controls.Add(this.label14);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesFindButton);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesWidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.label6);
            this.RectanglesGroupBox.Controls.Add(this.label7);
            this.RectanglesGroupBox.Controls.Add(this.label8);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesLenghtTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(8, 8);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(285, 315);
            this.RectanglesGroupBox.TabIndex = 2;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectanglesIdTextBox
            // 
            this.RectanglesIdTextBox.Location = new System.Drawing.Point(135, 233);
            this.RectanglesIdTextBox.Name = "RectanglesIdTextBox";
            this.RectanglesIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesIdTextBox.TabIndex = 14;
            this.RectanglesIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RectanglesIdTextBox_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(132, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Id:";
            // 
            // RectanglesCenterYTextBox
            // 
            this.RectanglesCenterYTextBox.Location = new System.Drawing.Point(135, 193);
            this.RectanglesCenterYTextBox.Name = "RectanglesCenterYTextBox";
            this.RectanglesCenterYTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesCenterYTextBox.TabIndex = 12;
            this.RectanglesCenterYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RectanglesCenterYTextBox_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(132, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Center Y:";
            // 
            // RectanglesCenterXTextBox
            // 
            this.RectanglesCenterXTextBox.Location = new System.Drawing.Point(135, 153);
            this.RectanglesCenterXTextBox.Name = "RectanglesCenterXTextBox";
            this.RectanglesCenterXTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesCenterXTextBox.TabIndex = 10;
            this.RectanglesCenterXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RectanglesCenterXTextBox_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(132, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Center X:";
            // 
            // RectanglesFindButton
            // 
            this.RectanglesFindButton.Location = new System.Drawing.Point(135, 276);
            this.RectanglesFindButton.Name = "RectanglesFindButton";
            this.RectanglesFindButton.Size = new System.Drawing.Size(100, 20);
            this.RectanglesFindButton.TabIndex = 8;
            this.RectanglesFindButton.Text = "Find";
            this.RectanglesFindButton.UseVisualStyleBackColor = true;
            this.RectanglesFindButton.Click += new System.EventHandler(this.RectanglesFindButton_Click);
            // 
            // RectanglesColorTextBox
            // 
            this.RectanglesColorTextBox.Enabled = false;
            this.RectanglesColorTextBox.Location = new System.Drawing.Point(135, 115);
            this.RectanglesColorTextBox.Name = "RectanglesColorTextBox";
            this.RectanglesColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesColorTextBox.TabIndex = 7;
            this.RectanglesColorTextBox.TextChanged += new System.EventHandler(this.RectanglesColorTextBox_TextChanged);
            // 
            // RectanglesWidthTextBox
            // 
            this.RectanglesWidthTextBox.Enabled = false;
            this.RectanglesWidthTextBox.Location = new System.Drawing.Point(135, 75);
            this.RectanglesWidthTextBox.Name = "RectanglesWidthTextBox";
            this.RectanglesWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesWidthTextBox.TabIndex = 6;
            this.RectanglesWidthTextBox.TextChanged += new System.EventHandler(this.RectanglesWidthTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Color:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Width:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Lenght:";
            // 
            // RectanglesLenghtTextBox
            // 
            this.RectanglesLenghtTextBox.Enabled = false;
            this.RectanglesLenghtTextBox.Location = new System.Drawing.Point(135, 35);
            this.RectanglesLenghtTextBox.Name = "RectanglesLenghtTextBox";
            this.RectanglesLenghtTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesLenghtTextBox.TabIndex = 2;
            this.RectanglesLenghtTextBox.TextChanged += new System.EventHandler(this.RectanglesLenghtTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Items.AddRange(new object[] {
            "Rectangle 1",
            "Rectangle 2",
            "Rectangle 3",
            "Rectangle 4",
            "Rectangle 5"});
            this.RectanglesListBox.Location = new System.Drawing.Point(6, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(120, 277);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesGroupBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(285, 315);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.TextBox RectanglesIdTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox RectanglesCenterYTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox RectanglesCenterXTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button RectanglesFindButton;
        private System.Windows.Forms.TextBox RectanglesColorTextBox;
        private System.Windows.Forms.TextBox RectanglesWidthTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RectanglesLenghtTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
