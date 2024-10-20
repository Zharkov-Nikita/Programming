using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о товаре.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Общее количество товаров.
        /// </summary>
        private static int _allItemsCount = 0;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает общее количество товаров.
        /// </summary>
        public static int AllItemsCount { get; }

        /// <summary>
        /// Возвращает и задаёт уникальный идентификатор товара. Не может быть отрицательным.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Возвращает и задаёт название товара. Не может быть длиннее 200 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт описание товара. Не может или длиннее 1000 символов.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость товара. Не может быть меньше 0 и больше 100 000.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentException();
                }
                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт категорию товара. Нет ограничений.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название. Не может быть длиннее 200 символов.</param>
        /// <param name="info">Описание. Не может быть длиннее 1000 символов.</param>
        /// <param name="cost">Цена. Не может быть меньше 0 и больше 100 000.</param>
        /// <param name="category">Категория. Нет ограничений.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            Id = _allItemsCount;
            _allItemsCount++;
        }
    }
}
