using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Общее количество товаров.
        /// </summary>
        private static int _allCustomersCount = 0;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// ФИО покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает общее количество покупателей.
        /// </summary>
        public static int AllCustomersCount { get; }

        /// <summary>
        /// Возвращает и задаёт уникальный идентификатор покупателя. Не может быть отрицательным.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Возвращает и задаёт ФИО покупателя. Не может быть длиннее 200 символов.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя. Не может быть длиннее 500 символов.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Название. Не может быть длиннее 200 символов.</param>
        /// <param name="address">Описание. Не может быть длиннее 500 символов.</param>
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            Id = _allCustomersCount;
            _allCustomersCount++;
        }
    }
}
