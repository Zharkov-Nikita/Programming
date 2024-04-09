using Programming.Model;
using Programming.Model.Geometry;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
            
            //Заполнения массива с прямоугольниками
            for (int i = 0; i < 5; i++)
            {
                Model.Rectangle rectangle = RectangleFactory.Randomize();
                _rectangles[i] = rectangle;
                _rectangles2.Add(rectangle);

                string _item = ($"{rectangle.Id}: (X = {rectangle.Center.X}; Y = {rectangle.Center.Y}; W = {rectangle.Width}; H = {rectangle.Lenght})").ToString();
                RectanglesRectanglesListBox.Items.Add(_item);
                AddPanel(rectangle);
            }

            //Заполнения массива с фильмами
            for (int i = 0; i < 5; i++)
            {
                Movie movie = new Movie("Фильм " + (i + 1), rand.Next(30, 121), rand.Next(1900, 2025), _genre[rand.Next(0, 6)].ToString(), rand.Next(10, 101) * 0.1);
                _movies[i] = movie;
            }
            FindCollisions();
        }

        Random rand = new Random(); //Функция для рандомного числа

        private Model.Rectangle[] _rectangles = new Model.Rectangle[5]; //Массив с прямоугольниками
        private Model.Rectangle _currentRectangle;

        private List<Model.Rectangle> _rectangles2 = new List<Model.Rectangle>(); //Список с прямоугольниками
        private List<Panel> _rectanglePanels = new List<Panel>(); //Список с панелями
        private Model.Rectangle _currentRectangle2;

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
            if (!RectanglesLenghtTextBox.Enabled)
            {
                RectanglesLenghtTextBox.Enabled = true;
                RectanglesWidthTextBox.Enabled = true;
                RectanglesColorTextBox.Enabled = true;
            }
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            RectanglesLenghtTextBox.Text = _currentRectangle.Lenght.ToString();
            RectanglesWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectanglesColorTextBox.Text = _currentRectangle.Color.ToString();
            RectanglesCenterXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectanglesCenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectanglesIdTextBox.Text = _currentRectangle.Id.ToString();
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

        /// <summary>
        /// Заполняет поля данными из выбранного фильма
        /// </summary>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!MoviesNameTextBox.Enabled)
            {
                MoviesNameTextBox.Enabled = true;
                MoviesDurationTextBox.Enabled = true;
                MoviesYearOfReleaseTextBox.Enabled = true;
                MoviesGenreTextBox.Enabled = true;
                MoviesRatingTextBox.Enabled = true;
            }
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
            try
            {
                _currentMovie.Duration = Convert.ToInt32(MoviesDurationTextBox.Text);
                MoviesDurationTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                MoviesDurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Меняет год выпуска фильма на введённый
        /// </summary>
        private void MoviesYearOfReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.YearOfRelease = Convert.ToInt32(MoviesYearOfReleaseTextBox.Text);
                MoviesYearOfReleaseTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                MoviesYearOfReleaseTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Меняет жанр фильма на введённый
        /// </summary>
        private void MoviesGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = MoviesGenreTextBox.Text;
        }

        /// <summary>
        /// Меняет рейтинг фильма на введённый
        /// </summary>
        private void MoviesRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = Convert.ToDouble(MoviesRatingTextBox.Text);
                MoviesRatingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                MoviesRatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Находит фильм с наивысшим рейтингом
        /// </summary>
        /// <param name="movies">Массив фильмов</param>
        /// <returns>Возвращает индекс найденного фильма</returns>
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            double max = 0;
            int maxIndex = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        /// <summary>
        /// Выделяет полученный фильм
        /// </summary>
        private void MoviesFindButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
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

        private void RectanglesRectanglesIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

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

            RectanglesRectanglesHeightTextBox.BackColor = System.Drawing.Color.White;
            RectanglesRectanglesWidthTextBox.BackColor = System.Drawing.Color.White;
            RectanglesRectanglesCenterXTextBox.BackColor = System.Drawing.Color.White;
            RectanglesRectanglesCenterYTextBox.BackColor = System.Drawing.Color.White;
        }

        private void RefreshRectanglesListBoxItem()
        {
            string _item = ($"{_currentRectangle2.Id}: (X = {_currentRectangle2.Center.X}; Y = {_currentRectangle2.Center.Y}; W = {_currentRectangle2.Width}; H = {_currentRectangle2.Lenght})").ToString();
            RectanglesRectanglesListBox.Items[RectanglesRectanglesListBox.SelectedIndex] = _item;

            EditingRectangle(_rectangles2[RectanglesRectanglesListBox.SelectedIndex]);
        }

        private void EditingRectangle(Model.Rectangle rectangle)
        {
            _rectanglePanels[RectanglesRectanglesListBox.SelectedIndex].Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            _rectanglePanels[RectanglesRectanglesListBox.SelectedIndex].Width = rectangle.Width;
            _rectanglePanels[RectanglesRectanglesListBox.SelectedIndex].Height = rectangle.Lenght;

            FindCollisions();
        }

        private void AddPanel(Model.Rectangle rectangle)
        {
            Panel panel = new Panel();
            panel.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            panel.Width = rectangle.Width;
            panel.Height = rectangle.Lenght;
            panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            _rectanglePanels.Add(panel);
            RectanglesCanvasPanel.Controls.Add(panel);
        }

        private void RectanglesRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!RectanglesRectanglesHeightTextBox.Enabled)
            {
                RectanglesRectanglesHeightTextBox.Enabled = true;
                RectanglesRectanglesWidthTextBox.Enabled = true;
                RectanglesRectanglesCenterXTextBox.Enabled = true;
                RectanglesRectanglesCenterYTextBox.Enabled = true;
            }

            try
            {
                UpdateRectangleInfo(_rectangles2[RectanglesRectanglesListBox.SelectedIndex]);
            }
            catch { }
        }

        private void UpdateRectangleInfo(Model.Rectangle rectangle)
        {
            _currentRectangle2 = rectangle;
            RectanglesRectanglesHeightTextBox.Text = _currentRectangle2.Lenght.ToString();
            RectanglesRectanglesWidthTextBox.Text = _currentRectangle2.Width.ToString();
            RectanglesRectanglesCenterXTextBox.Text = _currentRectangle2.Center.X.ToString();
            RectanglesRectanglesCenterYTextBox.Text = _currentRectangle2.Center.Y.ToString();
            RectanglesRectanglesIdTextBox.Text = _currentRectangle2.Id.ToString();
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Model.Rectangle rectangle = RectangleFactory.Randomize();
            _rectangles2.Add(rectangle);
            AddPanel(rectangle);
            ClearRectangleInfo();
            FindCollisions();
        }

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

        private void RectanglesRectanglesHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle2.Lenght = Convert.ToInt32(RectanglesRectanglesHeightTextBox.Text);
                RectanglesRectanglesHeightTextBox.BackColor = System.Drawing.Color.White;
                RefreshRectanglesListBoxItem();
            }
            catch
            {
                RectanglesRectanglesHeightTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectanglesRectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle2.Width = Convert.ToInt32(RectanglesRectanglesWidthTextBox.Text);
                RectanglesRectanglesWidthTextBox.BackColor = System.Drawing.Color.White;
                RefreshRectanglesListBoxItem();
            }
            catch
            {
                RectanglesRectanglesWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectanglesRectanglesCenterYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle2.Center.Y = Convert.ToInt32(RectanglesRectanglesCenterYTextBox.Text);
                RectanglesRectanglesCenterYTextBox.BackColor = System.Drawing.Color.White;
                RefreshRectanglesListBoxItem();
            }
            catch
            {
                RectanglesRectanglesCenterYTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectanglesRectanglesCenterXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle2.Center.X = Convert.ToInt32(RectanglesRectanglesCenterXTextBox.Text);
                RectanglesRectanglesCenterXTextBox.BackColor = System.Drawing.Color.White;
                RefreshRectanglesListBoxItem();
            }
            catch
            {
                RectanglesRectanglesCenterXTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FindCollisions()
        {
            foreach (Panel panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }
            for (int i = 0; i < _rectangles2.Count; i++)
            {
                for (int j = i+1; j < _rectangles2.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles2[i], _rectangles2[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
    }
}
