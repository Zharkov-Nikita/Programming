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
            this.EnumsTabControl = new System.Windows.Forms.TabControl();
            this.Classes = new System.Windows.Forms.TabPage();
            this.Rectangles = new System.Windows.Forms.TabPage();
            this.seasonsControl1 = new Programming.View.Panels.SeasonsControl();
            this.weekdayParsingControl1 = new Programming.View.Panels.WeekdayParsingControl();
            this.allEnumerationsControl1 = new Programming.View.Panels.AllEnumerationsControl();
            this.moviesControl1 = new Programming.View.Panels.MoviesControl();
            this.rectanglesControl1 = new Programming.View.Panels.RectanglesControl();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.Enums.SuspendLayout();
            this.EnumsTabControl.SuspendLayout();
            this.Classes.SuspendLayout();
            this.Rectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enums
            // 
            this.Enums.BackColor = System.Drawing.Color.Transparent;
            this.Enums.Controls.Add(this.seasonsControl1);
            this.Enums.Controls.Add(this.weekdayParsingControl1);
            this.Enums.Controls.Add(this.allEnumerationsControl1);
            this.Enums.Location = new System.Drawing.Point(4, 22);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(681, 425);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
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
            this.EnumsTabControl.Size = new System.Drawing.Size(689, 451);
            this.EnumsTabControl.TabIndex = 0;
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.moviesControl1);
            this.Classes.Controls.Add(this.rectanglesControl1);
            this.Classes.Location = new System.Drawing.Point(4, 22);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(681, 425);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // Rectangles
            // 
            this.Rectangles.Controls.Add(this.rectanglesCollisionControl1);
            this.Rectangles.Location = new System.Drawing.Point(4, 22);
            this.Rectangles.Name = "Rectangles";
            this.Rectangles.Size = new System.Drawing.Size(681, 425);
            this.Rectangles.TabIndex = 2;
            this.Rectangles.Text = "Rectangles";
            this.Rectangles.UseVisualStyleBackColor = true;
            // 
            // seasonsControl1
            // 
            this.seasonsControl1.Location = new System.Drawing.Point(331, 258);
            this.seasonsControl1.Name = "seasonsControl1";
            this.seasonsControl1.Size = new System.Drawing.Size(344, 145);
            this.seasonsControl1.TabIndex = 5;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(0, 249);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(330, 148);
            this.weekdayParsingControl1.TabIndex = 4;
            // 
            // allEnumerationsControl1
            // 
            this.allEnumerationsControl1.Location = new System.Drawing.Point(0, 0);
            this.allEnumerationsControl1.Name = "allEnumerationsControl1";
            this.allEnumerationsControl1.Size = new System.Drawing.Size(680, 252);
            this.allEnumerationsControl1.TabIndex = 3;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(302, 0);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(297, 291);
            this.moviesControl1.TabIndex = 11;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(296, 329);
            this.rectanglesControl1.TabIndex = 10;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(681, 425);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(689, 451);
            this.Controls.Add(this.EnumsTabControl);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Enums.ResumeLayout(false);
            this.EnumsTabControl.ResumeLayout(false);
            this.Classes.ResumeLayout(false);
            this.Rectangles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.TabControl EnumsTabControl;
        private TabPage Classes;
        private TabPage Rectangles;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.RectanglesControl rectanglesControl1;
        private View.Panels.MoviesControl moviesControl1;
        private View.Panels.AllEnumerationsControl allEnumerationsControl1;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private View.Panels.SeasonsControl seasonsControl1;
    }
}

