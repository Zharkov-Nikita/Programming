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
    public partial class AllEnumerationsControl : UserControl
    {
        public AllEnumerationsControl()
        {
            InitializeComponent();

            EnumsListBox.SetSelected(0, true); //Выбор первого элемента в EnumsListBox
        }

        /// <summary>
        /// Заполнение ValuesListBox элементами выбранной категории
        /// </summary>
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

        /// <summary>
        /// Вывод ID выбранного в ValuesListBox элемента
        /// </summary>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
