using Programming.Model;
using Programming.Resources;
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
    public partial class SeasonsControl : UserControl
    {
        public SeasonsControl()
        {
            InitializeComponent();

            SeasonHandleCombobox.DataSource = Enum.GetValues(typeof(Season)); //Заполнение Combobox названиями времён года
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
                    this.BackColor = AppColors.spring; //Изменить цвет
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!"); //Вывод окна с сообщением
                    break;
                case "Autumn":
                    this.BackColor = AppColors.autumn; //Изменить цвет
                    break;
            }
        }
    }
}
