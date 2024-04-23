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

namespace Programming.View.Panels
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
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
    }
}
