using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о заказе.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Общее количество заказов.
        /// </summary>
        private static int _allOrdersCount = 0;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly DateTime _createDate;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Товары заказа.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Возвращает общее количество заказов.
        /// </summary>
        public static int AllOrdersCount { get; }

        /// <summary>
        /// Возвращает и задаёт уникальный идентификатор заказа. Не может быть отрицательным.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Возвращает и задаёт статус заказа. Нет ограничений.
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Возвращает и задаёт дату создания заказа.
        /// </summary>
        public DateTime CreateDate { get; private set; }

        /// <summary>
        /// Возвращает и задаёт адрес доставки.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Возвращает и задаёт товары.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает общую стоимость всех товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                double amount = 0.0;
                foreach (Item item in _items)
                {
                    amount += item.Cost;
                }
                return amount;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        public Order(Address address, List<Item> items)
        {
            Address = address;
            Items = items;
            CreateDate = DateTime.Now;
            Status = OrderStatus.New;
            Id = _allOrdersCount;
            _allOrdersCount++;
        }
    }
}
