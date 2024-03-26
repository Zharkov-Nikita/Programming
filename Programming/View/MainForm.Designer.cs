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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.Classes = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MoviesRatingTextBox = new System.Windows.Forms.TextBox();
            this.MoviesGenreTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MoviesFindButton = new System.Windows.Forms.Button();
            this.MoviesYearOfReleaseTextBox = new System.Windows.Forms.TextBox();
            this.MoviesDurationTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MoviesNameTextBox = new System.Windows.Forms.TextBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
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
            this.Rectangles = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.RectanglesRectanglesHeightTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesRectanglesWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesRectanglesCenterYTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesRectanglesCenterXTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesRectanglesIdTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.DeleteRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.RectanglesCanvasPanel = new System.Windows.Forms.Panel();
            this.RectanglesRectanglesListBox = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Enums.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.WeekdayParsing.SuspendLayout();
            this.Enumerations.SuspendLayout();
            this.EnumsTabControl.SuspendLayout();
            this.Classes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.Rectangles.SuspendLayout();
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
            this.EnumsTabControl.Controls.Add(this.Classes);
            this.EnumsTabControl.Controls.Add(this.Rectangles);
            this.EnumsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.Size = new System.Drawing.Size(684, 450);
            this.EnumsTabControl.TabIndex = 0;
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.groupBox2);
            this.Classes.Controls.Add(this.RectanglesGroupBox);
            this.Classes.Location = new System.Drawing.Point(4, 22);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(676, 424);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.MoviesRatingTextBox);
            this.groupBox2.Controls.Add(this.MoviesGenreTextBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.MoviesFindButton);
            this.groupBox2.Controls.Add(this.MoviesYearOfReleaseTextBox);
            this.groupBox2.Controls.Add(this.MoviesDurationTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.MoviesNameTextBox);
            this.groupBox2.Controls.Add(this.MoviesListBox);
            this.groupBox2.Location = new System.Drawing.Point(310, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 277);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movies";
            // 
            // MoviesRatingTextBox
            // 
            this.MoviesRatingTextBox.Enabled = false;
            this.MoviesRatingTextBox.Location = new System.Drawing.Point(135, 193);
            this.MoviesRatingTextBox.Name = "MoviesRatingTextBox";
            this.MoviesRatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.MoviesRatingTextBox.TabIndex = 12;
            this.MoviesRatingTextBox.TextChanged += new System.EventHandler(this.MoviesRatingTextBox_TextChanged);
            // 
            // MoviesGenreTextBox
            // 
            this.MoviesGenreTextBox.Enabled = false;
            this.MoviesGenreTextBox.Location = new System.Drawing.Point(135, 154);
            this.MoviesGenreTextBox.Name = "MoviesGenreTextBox";
            this.MoviesGenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.MoviesGenreTextBox.TabIndex = 11;
            this.MoviesGenreTextBox.TextChanged += new System.EventHandler(this.MoviesGenreTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Rating:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Genre:";
            // 
            // MoviesFindButton
            // 
            this.MoviesFindButton.Location = new System.Drawing.Point(135, 237);
            this.MoviesFindButton.Name = "MoviesFindButton";
            this.MoviesFindButton.Size = new System.Drawing.Size(100, 20);
            this.MoviesFindButton.TabIndex = 8;
            this.MoviesFindButton.Text = "Find";
            this.MoviesFindButton.UseVisualStyleBackColor = true;
            this.MoviesFindButton.Click += new System.EventHandler(this.MoviesFindButton_Click);
            // 
            // MoviesYearOfReleaseTextBox
            // 
            this.MoviesYearOfReleaseTextBox.Enabled = false;
            this.MoviesYearOfReleaseTextBox.Location = new System.Drawing.Point(135, 115);
            this.MoviesYearOfReleaseTextBox.Name = "MoviesYearOfReleaseTextBox";
            this.MoviesYearOfReleaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.MoviesYearOfReleaseTextBox.TabIndex = 7;
            this.MoviesYearOfReleaseTextBox.TextChanged += new System.EventHandler(this.MoviesYearOfReleaseTextBox_TextChanged);
            // 
            // MoviesDurationTextBox
            // 
            this.MoviesDurationTextBox.Enabled = false;
            this.MoviesDurationTextBox.Location = new System.Drawing.Point(135, 75);
            this.MoviesDurationTextBox.Name = "MoviesDurationTextBox";
            this.MoviesDurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.MoviesDurationTextBox.TabIndex = 6;
            this.MoviesDurationTextBox.TextChanged += new System.EventHandler(this.MoviesDurationTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Year of release:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Duration:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Name:";
            // 
            // MoviesNameTextBox
            // 
            this.MoviesNameTextBox.Enabled = false;
            this.MoviesNameTextBox.Location = new System.Drawing.Point(135, 35);
            this.MoviesNameTextBox.Name = "MoviesNameTextBox";
            this.MoviesNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.MoviesNameTextBox.TabIndex = 2;
            this.MoviesNameTextBox.TextChanged += new System.EventHandler(this.MoviesNameTextBox_TextChanged);
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Items.AddRange(new object[] {
            "Movie 1",
            "Movie 2",
            "Movie 3",
            "Movie 4",
            "Movie 5"});
            this.MoviesListBox.Location = new System.Drawing.Point(6, 19);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(120, 238);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
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
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(285, 315);
            this.RectanglesGroupBox.TabIndex = 1;
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
            // Rectangles
            // 
            this.Rectangles.Controls.Add(this.label23);
            this.Rectangles.Controls.Add(this.label22);
            this.Rectangles.Controls.Add(this.label21);
            this.Rectangles.Controls.Add(this.label20);
            this.Rectangles.Controls.Add(this.label19);
            this.Rectangles.Controls.Add(this.RectanglesRectanglesHeightTextBox);
            this.Rectangles.Controls.Add(this.RectanglesRectanglesWidthTextBox);
            this.Rectangles.Controls.Add(this.RectanglesRectanglesCenterYTextBox);
            this.Rectangles.Controls.Add(this.RectanglesRectanglesCenterXTextBox);
            this.Rectangles.Controls.Add(this.RectanglesRectanglesIdTextBox);
            this.Rectangles.Controls.Add(this.label18);
            this.Rectangles.Controls.Add(this.DeleteRectangleButton);
            this.Rectangles.Controls.Add(this.AddRectangleButton);
            this.Rectangles.Controls.Add(this.RectanglesCanvasPanel);
            this.Rectangles.Controls.Add(this.RectanglesRectanglesListBox);
            this.Rectangles.Controls.Add(this.label17);
            this.Rectangles.Location = new System.Drawing.Point(4, 22);
            this.Rectangles.Name = "Rectangles";
            this.Rectangles.Size = new System.Drawing.Size(676, 424);
            this.Rectangles.TabIndex = 2;
            this.Rectangles.Text = "Rectangles";
            this.Rectangles.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 342);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "Height:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 316);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "Width:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(38, 290);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Y:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(38, 264);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "X:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(38, 238);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Id:";
            // 
            // RectanglesRectanglesHeightTextBox
            // 
            this.RectanglesRectanglesHeightTextBox.Enabled = false;
            this.RectanglesRectanglesHeightTextBox.Location = new System.Drawing.Point(63, 339);
            this.RectanglesRectanglesHeightTextBox.Name = "RectanglesRectanglesHeightTextBox";
            this.RectanglesRectanglesHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesRectanglesHeightTextBox.TabIndex = 10;
            this.RectanglesRectanglesHeightTextBox.TextChanged += new System.EventHandler(this.RectanglesRectanglesHeightTextBox_TextChanged);
            // 
            // RectanglesRectanglesWidthTextBox
            // 
            this.RectanglesRectanglesWidthTextBox.Enabled = false;
            this.RectanglesRectanglesWidthTextBox.Location = new System.Drawing.Point(63, 313);
            this.RectanglesRectanglesWidthTextBox.Name = "RectanglesRectanglesWidthTextBox";
            this.RectanglesRectanglesWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesRectanglesWidthTextBox.TabIndex = 9;
            this.RectanglesRectanglesWidthTextBox.TextChanged += new System.EventHandler(this.RectanglesRectanglesWidthTextBox_TextChanged);
            // 
            // RectanglesRectanglesCenterYTextBox
            // 
            this.RectanglesRectanglesCenterYTextBox.Enabled = false;
            this.RectanglesRectanglesCenterYTextBox.Location = new System.Drawing.Point(63, 287);
            this.RectanglesRectanglesCenterYTextBox.Name = "RectanglesRectanglesCenterYTextBox";
            this.RectanglesRectanglesCenterYTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesRectanglesCenterYTextBox.TabIndex = 8;
            this.RectanglesRectanglesCenterYTextBox.TextChanged += new System.EventHandler(this.RectanglesRectanglesCenterYTextBox_TextChanged);
            // 
            // RectanglesRectanglesCenterXTextBox
            // 
            this.RectanglesRectanglesCenterXTextBox.Enabled = false;
            this.RectanglesRectanglesCenterXTextBox.Location = new System.Drawing.Point(63, 261);
            this.RectanglesRectanglesCenterXTextBox.Name = "RectanglesRectanglesCenterXTextBox";
            this.RectanglesRectanglesCenterXTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesRectanglesCenterXTextBox.TabIndex = 7;
            this.RectanglesRectanglesCenterXTextBox.TextChanged += new System.EventHandler(this.RectanglesRectanglesCenterXTextBox_TextChanged);
            // 
            // RectanglesRectanglesIdTextBox
            // 
            this.RectanglesRectanglesIdTextBox.Location = new System.Drawing.Point(63, 235);
            this.RectanglesRectanglesIdTextBox.Name = "RectanglesRectanglesIdTextBox";
            this.RectanglesRectanglesIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesRectanglesIdTextBox.TabIndex = 6;
            this.RectanglesRectanglesIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RectanglesRectanglesIdTextBox_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 210);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Selected Rectangle:";
            // 
            // DeleteRectangleButton
            // 
            this.DeleteRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRectangleButton.Image")));
            this.DeleteRectangleButton.Location = new System.Drawing.Point(118, 160);
            this.DeleteRectangleButton.Name = "DeleteRectangleButton";
            this.DeleteRectangleButton.Size = new System.Drawing.Size(35, 32);
            this.DeleteRectangleButton.TabIndex = 4;
            this.DeleteRectangleButton.UseVisualStyleBackColor = true;
            this.DeleteRectangleButton.Click += new System.EventHandler(this.DeleteRectangleButton_Click);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.BackColor = System.Drawing.Color.Transparent;
            this.AddRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("AddRectangleButton.Image")));
            this.AddRectangleButton.Location = new System.Drawing.Point(38, 160);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(35, 32);
            this.AddRectangleButton.TabIndex = 3;
            this.AddRectangleButton.UseVisualStyleBackColor = false;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // RectanglesCanvasPanel
            // 
            this.RectanglesCanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesCanvasPanel.Location = new System.Drawing.Point(284, 16);
            this.RectanglesCanvasPanel.Name = "RectanglesCanvasPanel";
            this.RectanglesCanvasPanel.Size = new System.Drawing.Size(384, 400);
            this.RectanglesCanvasPanel.TabIndex = 2;
            // 
            // RectanglesRectanglesListBox
            // 
            this.RectanglesRectanglesListBox.FormattingEnabled = true;
            this.RectanglesRectanglesListBox.Location = new System.Drawing.Point(12, 33);
            this.RectanglesRectanglesListBox.Name = "RectanglesRectanglesListBox";
            this.RectanglesRectanglesListBox.Size = new System.Drawing.Size(266, 108);
            this.RectanglesRectanglesListBox.TabIndex = 1;
            this.RectanglesRectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesRectanglesListBox_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Rectangles:";
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
            this.Classes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.Rectangles.ResumeLayout(false);
            this.Rectangles.PerformLayout();
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
        private TabPage Classes;
        private GroupBox RectanglesGroupBox;
        private TextBox RectanglesLenghtTextBox;
        private ListBox RectanglesListBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button RectanglesFindButton;
        private TextBox RectanglesColorTextBox;
        private TextBox RectanglesWidthTextBox;
        private GroupBox groupBox2;
        private Button MoviesFindButton;
        private TextBox MoviesYearOfReleaseTextBox;
        private TextBox MoviesDurationTextBox;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox MoviesNameTextBox;
        private ListBox MoviesListBox;
        private Label label12;
        private Label label13;
        private TextBox MoviesRatingTextBox;
        private TextBox MoviesGenreTextBox;
        private Label label14;
        private TextBox RectanglesCenterYTextBox;
        private Label label15;
        private TextBox RectanglesCenterXTextBox;
        private TextBox RectanglesIdTextBox;
        private Label label16;
        private TabPage Rectangles;
        private ListBox RectanglesRectanglesListBox;
        private Label label17;
        private Panel RectanglesCanvasPanel;
        private Button AddRectangleButton;
        private Button DeleteRectangleButton;
        private Label label18;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private TextBox RectanglesRectanglesHeightTextBox;
        private TextBox RectanglesRectanglesWidthTextBox;
        private TextBox RectanglesRectanglesCenterYTextBox;
        private TextBox RectanglesRectanglesCenterXTextBox;
        private TextBox RectanglesRectanglesIdTextBox;
    }
}

