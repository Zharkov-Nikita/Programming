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
    public partial class RectanglesCollisionControl : UserControl
    {
        public RectanglesCollisionControl()
        {
            InitializeComponent();

            //Заполнения массива с прямоугольниками
            for (int i = 0; i < 5; i++)
            {
                Model.Rectangle rectangle = RectangleFactory.Randomize();
                _rectangles2.Add(rectangle);

                string _item = ($"{rectangle.Id}: (X = {rectangle.Center.X}; Y = {rectangle.Center.Y}; W = {rectangle.Width}; H = {rectangle.Lenght})").ToString();
                RectanglesRectanglesListBox.Items.Add(_item);
                AddPanel(rectangle);
            }

            FindCollisions();
        }

        Random rand = new Random(); //Функция для рандомного числа

        private List<Model.Rectangle> _rectangles2 = new List<Model.Rectangle>(); //Список с прямоугольниками
        private List<Panel> _rectanglePanels = new List<Panel>(); //Список с панелями
        private Model.Rectangle _currentRectangle2;

        public Model.Color[] _color = Enum.GetValues(typeof(Model.Color)).Cast<Model.Color>().ToArray(); //Перечисление цветов

        private void RectanglesRectanglesIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Очищение текстбоксов с информацией о выбранном прямоугольнике
        /// </summary>
        private void ClearRectangleInfo()
        {
            RectanglesRectanglesListBox.Items.Clear();
            foreach (Model.Rectangle item in _rectangles2)
            {
                string _item = ($"{item.Id}: (X = {item.Center.X}; Y = {item.Center.Y}; W = {item.Width}; H = {item.Lenght})").ToString();
                RectanglesRectanglesListBox.Items.Add(_item);
            }
            RectanglesRectanglesHeightTextBox.Text = null;
            RectanglesRectanglesWidthTextBox.Text = null;
            RectanglesRectanglesCenterXTextBox.Text = null;
            RectanglesRectanglesCenterYTextBox.Text = null;
            RectanglesRectanglesIdTextBox.Text = null;

            RectanglesRectanglesHeightTextBox.Enabled = false;
            RectanglesRectanglesWidthTextBox.Enabled = false;
            RectanglesRectanglesCenterXTextBox.Enabled = false;
            RectanglesRectanglesCenterYTextBox.Enabled = false;

            RectanglesRectanglesHeightTextBox.BackColor = AppColors.textBoxColor;
            RectanglesRectanglesWidthTextBox.BackColor = AppColors.textBoxColor;
            RectanglesRectanglesCenterXTextBox.BackColor = AppColors.textBoxColor;
            RectanglesRectanglesCenterYTextBox.BackColor = AppColors.textBoxColor;
        }

        /// <summary>
        /// Обновление информации в ListBox с прямоугольниками
        /// </summary>
        private void RefreshRectanglesListBoxItem()
        {
            string _item = ($"{_currentRectangle2.Id}: (X = {_currentRectangle2.Center.X}; Y = {_currentRectangle2.Center.Y}; W = {_currentRectangle2.Width}; H = {_currentRectangle2.Lenght})").ToString();
            RectanglesRectanglesListBox.Items[RectanglesRectanglesListBox.SelectedIndex] = _item;

            EditingRectangle(_rectangles2[RectanglesRectanglesListBox.SelectedIndex]);
        }

        /// <summary>
        /// Изменение прямоугольника на экране
        /// </summary>
        /// <param name="rectangle">Изменяемый прямоугольник</param>
        private void EditingRectangle(Model.Rectangle rectangle)
        {
            _rectanglePanels[RectanglesRectanglesListBox.SelectedIndex].Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            _rectanglePanels[RectanglesRectanglesListBox.SelectedIndex].Width = rectangle.Width;
            _rectanglePanels[RectanglesRectanglesListBox.SelectedIndex].Height = rectangle.Lenght;

            FindCollisions();
        }

        /// <summary>
        /// Добавление прямоугольника на экран
        /// </summary>
        /// <param name="rectangle">Добавляемый прямоугольник</param>
        private void AddPanel(Model.Rectangle rectangle)
        {
            Panel panel = new Panel();
            panel.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            panel.Width = rectangle.Width;
            panel.Height = rectangle.Lenght;
            panel.BackColor = AppColors.greenPanel;
            _rectanglePanels.Add(panel);
            RectanglesCanvasPanel.Controls.Add(panel);
        }

        /// <summary>
        /// Заполняет поля данными из выбранного прямоугольника
        /// </summary>
        private void RectanglesRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateRectangleInfo(_rectangles2[RectanglesRectanglesListBox.SelectedIndex]);
                if (!RectanglesRectanglesHeightTextBox.Enabled)
                {
                    RectanglesRectanglesHeightTextBox.Enabled = true;
                    RectanglesRectanglesWidthTextBox.Enabled = true;
                    RectanglesRectanglesCenterXTextBox.Enabled = true;
                    RectanglesRectanglesCenterYTextBox.Enabled = true;
                }
            }
            catch { }
        }

        /// <summary>
        /// Заполнение текстбоксов информацией о прямоугольнике
        /// </summary>
        /// <param name="rectangle">Выбранный прямоугольник</param>
        private void UpdateRectangleInfo(Model.Rectangle rectangle)
        {
            _currentRectangle2 = rectangle;
            RectanglesRectanglesHeightTextBox.Text = _currentRectangle2.Lenght.ToString();
            RectanglesRectanglesWidthTextBox.Text = _currentRectangle2.Width.ToString();
            RectanglesRectanglesCenterXTextBox.Text = _currentRectangle2.Center.X.ToString();
            RectanglesRectanglesCenterYTextBox.Text = _currentRectangle2.Center.Y.ToString();
            RectanglesRectanglesIdTextBox.Text = _currentRectangle2.Id.ToString();
        }

        /// <summary>
        /// Кнопка добавления прямоугольника
        /// </summary>
        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Model.Rectangle rectangle = RectangleFactory.Randomize();
            _rectangles2.Add(rectangle);
            AddPanel(rectangle);
            ClearRectangleInfo();
            FindCollisions();
        }

        /// <summary>
        /// Кнопка удаление прямоугольника
        /// </summary>
        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            try
            {
                _rectangles2.RemoveAt(RectanglesRectanglesListBox.SelectedIndex);
                RectanglesCanvasPanel.Controls.RemoveAt(RectanglesRectanglesListBox.SelectedIndex);
                _rectanglePanels.RemoveAt(RectanglesRectanglesListBox.SelectedIndex);
                ClearRectangleInfo();
                FindCollisions();
            }
            catch { }
        }

        /// <summary>
        /// Изменение высоты прямоугольника
        /// </summary>
        private void RectanglesRectanglesHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle2.Lenght = Convert.ToInt32(RectanglesRectanglesHeightTextBox.Text);
                RectanglesRectanglesHeightTextBox.BackColor = AppColors.textBoxColor;
                RefreshRectanglesListBoxItem();
            }
            catch
            {
                RectanglesRectanglesHeightTextBox.BackColor = AppColors.textBoxColorWrong;
            }
        }

        private void RectanglesRectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle2.Width = Convert.ToInt32(RectanglesRectanglesWidthTextBox.Text);
                RectanglesRectanglesWidthTextBox.BackColor = AppColors.textBoxColor;
                RefreshRectanglesListBoxItem();
            }
            catch
            {
                RectanglesRectanglesWidthTextBox.BackColor = AppColors.textBoxColorWrong;
            }
        }

        private void RectanglesRectanglesCenterYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle2.Center.Y = Convert.ToInt32(RectanglesRectanglesCenterYTextBox.Text);
                RectanglesRectanglesCenterYTextBox.BackColor = AppColors.textBoxColor;
                RefreshRectanglesListBoxItem();
            }
            catch
            {
                RectanglesRectanglesCenterYTextBox.BackColor = AppColors.textBoxColorWrong;
            }
        }

        private void RectanglesRectanglesCenterXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle2.Center.X = Convert.ToInt32(RectanglesRectanglesCenterXTextBox.Text);
                RectanglesRectanglesCenterXTextBox.BackColor = AppColors.textBoxColor;
                RefreshRectanglesListBoxItem();
            }
            catch
            {
                RectanglesRectanglesCenterXTextBox.BackColor = AppColors.textBoxColorWrong;
            }
        }

        /// <summary>
        /// Функция нахождения пересечения прямоугольников
        /// </summary>
        private void FindCollisions()
        {
            foreach (Panel panel in _rectanglePanels)
            {
                panel.BackColor = AppColors.greenPanel;
            }
            for (int i = 0; i < _rectangles2.Count; i++)
            {
                for (int j = i + 1; j < _rectangles2.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles2[i], _rectangles2[j]))
                    {
                        _rectanglePanels[i].BackColor = AppColors.redPanel;
                        _rectanglePanels[j].BackColor = AppColors.redPanel;
                    }
                }
            }
        }
    }
}
