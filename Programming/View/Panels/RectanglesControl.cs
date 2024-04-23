using Programming.Model.Geometry;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Programming.Resources;

namespace Programming.View.Panels
{
    public partial class RectanglesControl : UserControl
    {
        public RectanglesControl()
        {
            InitializeComponent();

            //Заполнения массива с прямоугольниками
            for (int i = 0; i < 5; i++)
            {
                Model.Rectangle rectangle = RectangleFactory.Randomize();
                _rectangles[i] = rectangle;

                string _item = ($"{rectangle.Id}: (X = {rectangle.Center.X}; Y = {rectangle.Center.Y}; W = {rectangle.Width}; H = {rectangle.Lenght})").ToString();
            }
        }

        Random rand = new Random(); //Функция для рандомного числа

        private Model.Rectangle[] _rectangles = new Model.Rectangle[5]; //Массив с прямоугольниками
        private Model.Rectangle _currentRectangle;

        public Model.Color[] _color = Enum.GetValues(typeof(Model.Color)).Cast<Model.Color>().ToArray(); //Перечисление цветов

        /// <summary>
        /// Заполняет поля данными из выбранного прямоугольника
        /// </summary>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
                RectanglesLenghtTextBox.Text = _currentRectangle.Lenght.ToString();
                RectanglesWidthTextBox.Text = _currentRectangle.Width.ToString();
                RectanglesColorTextBox.Text = _currentRectangle.Color.ToString();
                RectanglesCenterXTextBox.Text = _currentRectangle.Center.X.ToString();
                RectanglesCenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
                RectanglesIdTextBox.Text = _currentRectangle.Id.ToString();
                if (!RectanglesLenghtTextBox.Enabled)
                {
                    RectanglesLenghtTextBox.Enabled = true;
                    RectanglesWidthTextBox.Enabled = true;
                    RectanglesColorTextBox.Enabled = true;
                }
            }
            catch { }
        }

        /// <summary>
        /// Меняет длину прямоугольника на введённую
        /// </summary>
        private void RectanglesLenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Lenght = Convert.ToInt32(RectanglesLenghtTextBox.Text);
                RectanglesLenghtTextBox.BackColor = AppColors.textBoxColor;
            }
            catch
            {
                RectanglesLenghtTextBox.BackColor = AppColors.textBoxColorWrong;
            }
        }

        /// <summary>
        /// Меняет ширину прямоугольника на введённую
        /// </summary>
        private void RectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToInt32(RectanglesWidthTextBox.Text);
                RectanglesWidthTextBox.BackColor = AppColors.textBoxColor;
            }
            catch
            {
                RectanglesWidthTextBox.BackColor = AppColors.textBoxColorWrong;
            }
        }

        /// <summary>
        /// Меняет цвет прямоугольника на введённый
        /// </summary>
        private void RectanglesColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = RectanglesColorTextBox.Text;
        }

        /// <summary>
        /// Находит прямоугольник с наибольшей шириной
        /// </summary>
        /// <param name="rectangles">Массив прямоугольников</param>
        /// <returns>Возвращает индекс найденного прямоугольника</returns>
        private int FindRectangleWithMaxWidth(Model.Rectangle[] rectangles)
        {
            int max = 0;
            int maxIndex = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        /// <summary>
        /// Выделяет полученный прямоугольник
        /// </summary>
        private void RectanglesFindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void RectanglesCenterXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RectanglesCenterYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RectanglesIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
