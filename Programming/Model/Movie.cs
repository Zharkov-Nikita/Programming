using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Movie
    {
        private string _name;
        private int _duration;
        private int _yearOfRelease;
        private string _genre;
        private double _rating;

        public string Name { get; set; }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        public int YearOfRelease
        {
            get
            {
                return _yearOfRelease;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, 2025, nameof(YearOfRelease));
                _yearOfRelease = value;
            }
        }

        public string Genre { get; set; }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">Название. Нет ограничений.</param>
        /// <param name="duration">Продолжительность в минутах. Не может быть отрицательным.</param>
        /// <param name="yearOfRelease">Год выпуска. Больше 1900 и меньше 2025</param>
        /// <param name="genre">Жанр. Нет ограничений.</param>
        /// <param name="rating">Рейтинг. Не может быть отрицательным и больше 10</param>
        public Movie(string name, int duration, int yearOfRelease, string genre, double rating)
        {
            Name = name;
            Duration = duration;
            YearOfRelease = yearOfRelease;
            Genre = genre;
            Rating = rating;
        }

        public Movie() { }
    }
}
