using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuildingsApp.Model
{
    /// <summary>
    /// Хранит информацию о здании.
    /// </summary>
    public class Building
    {
        /// <summary>
        /// Название здания.
        /// </summary>
        private string _name;

        /// <summary>
        /// Адрес здания.
        /// </summary>
        private string _address;

        /// <summary>
        /// Категория здания.
        /// </summary>
        private string _category;

        /// <summary>
        /// рейтинг здания.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задаёт название здания. Не может быть длиннее 200 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 200)
                {
                    throw new ArgumentException();
                }
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес здания. Не может быть длиннее 100 символов.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException();
                }
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт категорию здания. Нет ограничений.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Возвращает и задаёт рейтинг здания. Не может быть меньше 0 и больше 5.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException();
                }
                _rating = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Building"/>.
        /// </summary>
        /// <param name="name">Название. Не может быть длиннее 200 символов.</param>
        /// <param name="address">Адрес. Не может быть длиннее 100 символов.</param>
        /// <param name="category">Категория. Нет ограничений.</param>
        /// <param name="rating">Рейтинг. Не может быть меньше 0 и больше 5.</param>
        public Building(string name, string address, string category, double rating)
        {
            Name = name;
            Address = address;
            Category = category;
            Rating = rating;
        }
    }
}
