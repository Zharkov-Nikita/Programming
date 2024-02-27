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

            Random rand = new Random(); //Функция для рандомного числа
            //Заполнения массива с прямоугольниками
            for (int i = 0; i < 5; i++)
            {
                Model.Rectangle rectangle = new Model.Rectangle(rand.Next(1, 31), rand.Next(1, 31), _color[rand.Next(0, 9)].ToString());
                _rectangles[i] = rectangle;
            }

            //Заполнения массива с фильмами
            for (int i = 0; i < 5; i++)
            {
                Movie movie = new Movie("Фильм " + (i + 1), rand.Next(30, 121), rand.Next(1900, 2025), _genre[rand.Next(0, 6)].ToString(), rand.Next(10, 101) * 0.1);
                _movies[i] = movie;
            }
        }

        private Model.Rectangle[] _rectangles = new Model.Rectangle[5]; //Массив с прямоугольниками
        private Model.Rectangle _currentRectangle;

        public Model.Color[] _color = Enum.GetValues(typeof(Model.Color)).Cast<Model.Color>().ToArray(); //Перечисление цветов

        private Movie[] _movies = new Movie[5]; //Массив с фильмами
        private Movie _currentMovie;

        public Genre[] _genre = Enum.GetValues(typeof(Genre)).Cast<Genre>().ToArray(); //Перечисление жанров

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

        /// <summary>
        /// Заполняет поля данными из выбранного прямоугольника
        /// </summary>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            RectanglesLenghtTextBox.Text = _currentRectangle.Lenght.ToString();
            RectanglesWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectanglesColorTextBox.Text = _currentRectangle.Color.ToString();
        }

        /// <summary>
        /// Меняет длину прямоугольника на введённую
        /// </summary>
        private void RectanglesLenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Lenght = Convert.ToInt32(RectanglesLenghtTextBox.Text);
                RectanglesLenghtTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                RectanglesLenghtTextBox.BackColor = System.Drawing.Color.LightPink;
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
                RectanglesWidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                RectanglesWidthTextBox.BackColor = System.Drawing.Color.LightPink;
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
        /// <param name="rectangles"></param>
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

        /// <summary>
        /// Заполняет поля данными из выбранного фильма
        /// </summary>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[MoviesListBox.SelectedIndex];
            MoviesNameTextBox.Text = _currentMovie.Name.ToString();
            MoviesDurationTextBox.Text = _currentMovie.Duration.ToString();
            MoviesYearOfReleaseTextBox.Text = _currentMovie.YearOfRelease.ToString();
            MoviesGenreTextBox.Text = _currentMovie.Genre.ToString();
            MoviesRatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        /// <summary>
        /// Меняет название фильма на введённый
        /// </summary>
        private void MoviesNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = MoviesNameTextBox.Text;
        }

        /// <summary>
        /// Меняет продолжительность фильма на введённую
        /// </summary>
        private void MoviesDurationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Меняет год выпуска фильма на введённый
        /// </summary>
        private void MoviesYearOfReleaseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Меняет жанр фильма на введённый
        /// </summary>
        private void MoviesGenreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Меняет рейтинг фильма на введённый
        /// </summary>
        private void MoviesRatingTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
