namespace Programming.View.Panels
{
    partial class MoviesControl
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
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 277);
            this.groupBox2.TabIndex = 10;
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
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(285, 277);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox MoviesRatingTextBox;
        private System.Windows.Forms.TextBox MoviesGenreTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button MoviesFindButton;
        private System.Windows.Forms.TextBox MoviesYearOfReleaseTextBox;
        private System.Windows.Forms.TextBox MoviesDurationTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MoviesNameTextBox;
        private System.Windows.Forms.ListBox MoviesListBox;
    }
}
