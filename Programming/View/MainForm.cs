using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SetSelected(0, true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (EnumsListBox.SelectedItem)
            {
                case "Color":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Model.Color));
                    break;
                case "EducationForm":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(EducationForm));
                    break;
                case "Genre":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case "Manufactures":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Manufactures));
                    break;
                case "Season":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                case "Weekday":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (EnumsListBox.SelectedItem)
            {
                case "Color":
                    IntValuesTextBox.Text = Convert.ToString((int)(Model.Color)this.ValuesListBox.SelectedItem);
                    break;
                case "EducationForm":
                    IntValuesTextBox.Text = Convert.ToString((int)(EducationForm)this.ValuesListBox.SelectedItem);
                    break;
                case "Genre":
                    IntValuesTextBox.Text = Convert.ToString((int)(Genre)this.ValuesListBox.SelectedItem);
                    break;
                case "Manufactures":
                    IntValuesTextBox.Text = Convert.ToString((int)(Manufactures)this.ValuesListBox.SelectedItem);
                    break;
                case "Season":
                    IntValuesTextBox.Text = Convert.ToString((int)(Season)this.ValuesListBox.SelectedItem);
                    break;
                case "Weekday":
                    IntValuesTextBox.Text = Convert.ToString((int)(Weekday)this.ValuesListBox.SelectedItem);
                    break;
            }
        }

        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            string day = WeekdayParsingTextBox.Text;
            foreach (Weekday weekday in Enum.GetValues(typeof(Weekday)))
            {
                Weekday weekdayValue = (Weekday)Enum.Parse(typeof(Weekday), weekday.ToString());

                if (day == weekdayValue.ToString())
                {
                    WeekdayParsingLabel.Text = $"Это день недели ({weekday} = {(int)weekday})";
                    break;
                }
                WeekdayParsingLabel.Text = "Нет такого дня недели";
            }
        }

        private void WeekdayParsingTextBox_KeyPress(object sender, KeyPressEventArgs e) //Защита от написания чисел и спецсимволов
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
