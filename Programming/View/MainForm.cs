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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.SetSelected(0, true); //Выбор первого элемента в EnumsListBox
            SeasonHandleCombobox.DataSource = Enum.GetValues(typeof(Season)); //Заполнение Combobox названиями времён года
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e) //Заполнение ValuesListBox элементами выбранной категории
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

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e) //Вывод ID выбранного в ValuesListBox элемента
        {
            switch (EnumsListBox.SelectedItem)
            {
                case "Color":
                    IntValuesTextBox.Text = Convert.ToString((int)(Model.Color)ValuesListBox.SelectedItem);
                    break;
                case "EducationForm":
                    IntValuesTextBox.Text = Convert.ToString((int)(EducationForm)ValuesListBox.SelectedItem);
                    break;
                case "Genre":
                    IntValuesTextBox.Text = Convert.ToString((int)(Genre)ValuesListBox.SelectedItem);
                    break;
                case "Manufactures":
                    IntValuesTextBox.Text = Convert.ToString((int)(Manufactures)ValuesListBox.SelectedItem);
                    break;
                case "Season":
                    IntValuesTextBox.Text = Convert.ToString((int)(Season)ValuesListBox.SelectedItem);
                    break;
                case "Weekday":
                    IntValuesTextBox.Text = Convert.ToString((int)(Weekday)ValuesListBox.SelectedItem);
                    break;
            }
        }

        private void WeekdayParsingButton_Click(object sender, EventArgs e) //Кнопка "Parse"
        {
            try
            {
                string day = WeekdayParsingTextBox.Text; //Текст из Textbox
                Weekday weekdayValue = (Weekday)Enum.Parse(typeof(Weekday), day.ToString());
                WeekdayParsingLabel.Text = $"Это день недели ({weekdayValue} = {(int)weekdayValue})";
            }
            catch
            {
                WeekdayParsingLabel.Text = "Нет такого дня недели";
            }
        }

        private void WeekdayParsingTextBox_KeyPress(object sender, KeyPressEventArgs e) //Защита от написания чисел и спецсимволов
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void SeasonHandleButton_Click(object sender, EventArgs e) //Кнопка "Go!"
        {
            this.BackColor = ColorTranslator.FromHtml("#FFFFFF"); //Замена цвета заднего фона на белый
            switch (SeasonHandleCombobox.SelectedItem.ToString()) //В зависимости от выбранного значения в Combobox
            {
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!"); //Вывод окна с сообщением
                    break;
                case "Spring":
                    this.BackColor = ColorTranslator.FromHtml("#559c45"); //Изменить цвет
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!"); //Вывод окна с сообщением
                    break;
                case "Autumn":
                    this.BackColor = ColorTranslator.FromHtml("#e29c45"); //Изменить цвет
                    break;
            }
        }
    }
}
