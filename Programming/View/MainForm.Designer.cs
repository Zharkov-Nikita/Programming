using System.Drawing;
using System.Windows.Forms;

namespace Programming
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
            this.Enums = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SeasonHandleButton = new System.Windows.Forms.Button();
            this.SeasonHandleCombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WeekdayParsing = new System.Windows.Forms.GroupBox();
            this.WeekdayParsingLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingButton = new System.Windows.Forms.Button();
            this.WeekdayParsingTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Enumerations = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IntValuesTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumsTabControl = new System.Windows.Forms.TabControl();
            this.Enums.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.WeekdayParsing.SuspendLayout();
            this.Enumerations.SuspendLayout();
            this.EnumsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enums
            // 
            this.Enums.BackColor = System.Drawing.Color.Transparent;
            this.Enums.Controls.Add(this.groupBox1);
            this.Enums.Controls.Add(this.WeekdayParsing);
            this.Enums.Controls.Add(this.Enumerations);
            this.Enums.Location = new System.Drawing.Point(4, 22);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(676, 424);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SeasonHandleButton);
            this.groupBox1.Controls.Add(this.SeasonHandleCombobox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(336, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Season Handle";
            // 
            // SeasonHandleButton
            // 
            this.SeasonHandleButton.Location = new System.Drawing.Point(190, 49);
            this.SeasonHandleButton.Name = "SeasonHandleButton";
            this.SeasonHandleButton.Size = new System.Drawing.Size(75, 20);
            this.SeasonHandleButton.TabIndex = 2;
            this.SeasonHandleButton.Text = "Go!";
            this.SeasonHandleButton.UseVisualStyleBackColor = true;
            this.SeasonHandleButton.Click += new System.EventHandler(this.SeasonHandleButton_Click);
            // 
            // SeasonHandleCombobox
            // 
            this.SeasonHandleCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeasonHandleCombobox.FormattingEnabled = true;
            this.SeasonHandleCombobox.Location = new System.Drawing.Point(9, 49);
            this.SeasonHandleCombobox.Name = "SeasonHandleCombobox";
            this.SeasonHandleCombobox.Size = new System.Drawing.Size(163, 21);
            this.SeasonHandleCombobox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choose season:";
            // 
            // WeekdayParsing
            // 
            this.WeekdayParsing.Controls.Add(this.WeekdayParsingLabel);
            this.WeekdayParsing.Controls.Add(this.WeekdayParsingButton);
            this.WeekdayParsing.Controls.Add(this.WeekdayParsingTextBox);
            this.WeekdayParsing.Controls.Add(this.label4);
            this.WeekdayParsing.Location = new System.Drawing.Point(0, 249);
            this.WeekdayParsing.Name = "WeekdayParsing";
            this.WeekdayParsing.Size = new System.Drawing.Size(318, 137);
            this.WeekdayParsing.TabIndex = 1;
            this.WeekdayParsing.TabStop = false;
            this.WeekdayParsing.Text = "Weekday parsing";
            // 
            // WeekdayParsingLabel
            // 
            this.WeekdayParsingLabel.AutoSize = true;
            this.WeekdayParsingLabel.ForeColor = System.Drawing.Color.Gray;
            this.WeekdayParsingLabel.Location = new System.Drawing.Point(8, 82);
            this.WeekdayParsingLabel.Name = "WeekdayParsingLabel";
            this.WeekdayParsingLabel.Size = new System.Drawing.Size(0, 13);
            this.WeekdayParsingLabel.TabIndex = 3;
            // 
            // WeekdayParsingButton
            // 
            this.WeekdayParsingButton.Location = new System.Drawing.Point(191, 49);
            this.WeekdayParsingButton.Name = "WeekdayParsingButton";
            this.WeekdayParsingButton.Size = new System.Drawing.Size(75, 20);
            this.WeekdayParsingButton.TabIndex = 2;
            this.WeekdayParsingButton.Text = "Parse";
            this.WeekdayParsingButton.UseVisualStyleBackColor = true;
            this.WeekdayParsingButton.Click += new System.EventHandler(this.WeekdayParsingButton_Click);
            // 
            // WeekdayParsingTextBox
            // 
            this.WeekdayParsingTextBox.Location = new System.Drawing.Point(11, 49);
            this.WeekdayParsingTextBox.Name = "WeekdayParsingTextBox";
            this.WeekdayParsingTextBox.Size = new System.Drawing.Size(174, 20);
            this.WeekdayParsingTextBox.TabIndex = 1;
            this.WeekdayParsingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeekdayParsingTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type value for parsing:";
            // 
            // Enumerations
            // 
            this.Enumerations.BackColor = System.Drawing.Color.Transparent;
            this.Enumerations.Controls.Add(this.label3);
            this.Enumerations.Controls.Add(this.label2);
            this.Enumerations.Controls.Add(this.label1);
            this.Enumerations.Controls.Add(this.IntValuesTextBox);
            this.Enumerations.Controls.Add(this.ValuesListBox);
            this.Enumerations.Controls.Add(this.EnumsListBox);
            this.Enumerations.Location = new System.Drawing.Point(0, 0);
            this.Enumerations.Name = "Enumerations";
            this.Enumerations.Size = new System.Drawing.Size(671, 235);
            this.Enumerations.TabIndex = 0;
            this.Enumerations.TabStop = false;
            this.Enumerations.Text = "Enumerations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Int value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose enumeration:";
            // 
            // IntValuesTextBox
            // 
            this.IntValuesTextBox.Location = new System.Drawing.Point(311, 38);
            this.IntValuesTextBox.Name = "IntValuesTextBox";
            this.IntValuesTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntValuesTextBox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(161, 38);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(120, 186);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Color",
            "EducationForm",
            "Genre",
            "Manufactures",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(8, 38);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(120, 186);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.Enums);
            this.EnumsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.Size = new System.Drawing.Size(684, 450);
            this.EnumsTabControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.EnumsTabControl);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Enums.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.WeekdayParsing.ResumeLayout(false);
            this.WeekdayParsing.PerformLayout();
            this.Enumerations.ResumeLayout(false);
            this.Enumerations.PerformLayout();
            this.EnumsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.TabControl EnumsTabControl;
        private System.Windows.Forms.GroupBox Enumerations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IntValuesTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.GroupBox WeekdayParsing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WeekdayParsingTextBox;
        private System.Windows.Forms.Button WeekdayParsingButton;
        private System.Windows.Forms.Label WeekdayParsingLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SeasonHandleButton;
        private System.Windows.Forms.ComboBox SeasonHandleCombobox;
    }
}

