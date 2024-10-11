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
        private Address _address;

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Заказы покупателя.
        /// </summary>
        private List<Order> _orders;

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
        /// Возвращает и задаёт адрес покупателя.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Возвращает и задаёт корзину покупателя.
        /// </summary>
        public Cart Cart { get; set; }

        /// <summary>
        /// Возвращает и задаёт заказы покупателя.
        /// </summary>
        public List<Order> Orders { get; set; }

        /// <summary>
        /// Возвращает и задаёт приоритетность покупателя.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Название. Не может быть длиннее 200 символов.</param>
        /// <param name="address">Адрес.</param>
        public Customer(string fullname, Address address)
        {
            Fullname = fullname;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
            IsPriority = false;
            Id = _allCustomersCount;
            _allCustomersCount++;
        }
    }
}
