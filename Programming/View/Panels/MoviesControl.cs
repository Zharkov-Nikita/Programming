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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming.View.Panels
{
    public partial class MoviesControl : UserControl
    {
        public MoviesControl()
        {
            InitializeComponent();

            //Заполнения массива с фильмами
            for (int i = 0; i < 5; i++)
            {
                Movie movie = new Movie("Фильм " + (i + 1), rand.Next(30, 121), rand.Next(1900, 2025), _genre[rand.Next(0, 6)].ToString(), rand.Next(10, 101) * 0.1);
                _movies[i] = movie;
            }
        }

        Random rand = new Random(); //Функция для рандомного числа

        private Movie[] _movies = new Movie[5]; //Массив с фильмами
        private Movie _currentMovie;

        public Genre[] _genre = Enum.GetValues(typeof(Genre)).Cast<Genre>().ToArray(); //Перечисление жанров

        /// <summary>
        /// Заполняет поля данными из выбранного фильма
        /// </summary>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie = _movies[MoviesListBox.SelectedIndex];
                MoviesNameTextBox.Text = _currentMovie.Name.ToString();
                MoviesDurationTextBox.Text = _currentMovie.Duration.ToString();
                MoviesYearOfReleaseTextBox.Text = _currentMovie.YearOfRelease.ToString();
                MoviesGenreTextBox.Text = _currentMovie.Genre.ToString();
                MoviesRatingTextBox.Text = _currentMovie.Rating.ToString();
                if (!MoviesNameTextBox.Enabled)
                {
                    MoviesNameTextBox.Enabled = true;
                    MoviesDurationTextBox.Enabled = true;
                    MoviesYearOfReleaseTextBox.Enabled = true;
                    MoviesGenreTextBox.Enabled = true;
                    MoviesRatingTextBox.Enabled = true;
                }
            }
            catch { }
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
                MoviesDurationTextBox.BackColor = AppColors.textBoxColor;
            }
            catch
            {
                MoviesDurationTextBox.BackColor = AppColors.textBoxColorWrong;
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
                MoviesYearOfReleaseTextBox.BackColor = AppColors.textBoxColor;
            }
            catch
            {
                MoviesYearOfReleaseTextBox.BackColor = AppColors.textBoxColorWrong;
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
                MoviesRatingTextBox.BackColor = AppColors.textBoxColor;
            }
            catch
            {
                MoviesRatingTextBox.BackColor = AppColors.textBoxColorWrong;
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
    }
}
