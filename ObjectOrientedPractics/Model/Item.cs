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
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
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

        /// <summary>
        /// Клонирует экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// /// <returns>Склонированный экземпляр класса.</returns>
        public object Clone()
        {
            return new Item(this.Name, this.Info, this.Cost, this.Category) { Id = _allItemsCount-1 };
        }

        /// <summary>
        /// Сравнивает экземпляры класса
        /// </summary>
        /// <param name="other">Экземпляр, с которым будет происходить сравнение.</param>
        /// <returns>true, если равны и false, если не равны.</returns>
        public bool Equals(Item other)
        {
            //Обязательные проверки прежде чем мы сравним поля
            if (other == null)
                return false;
            if (!(other is Item))
                return false;
            if (object.ReferenceEquals(this, other))
                return true;
            var item2 = (Item)other;

            //Только теперь мы можем сделать собственное сравнение
            if (this.Name != item2.Name)
                return false;
            if (this.Info != item2.Info)
                return false;
            if (this.Cost != item2.Cost)
                return false;
            return (this.Category == item2.Category);
        }


        /// <summary>
        /// Сравнивает экземпляры класса
        /// </summary>
        /// <param name="other">Экземпляр, с которым будет происходить сравнение.</param>
        /// <returns>0, если равны; 1, если исходный объект больше; -1, если исходный объект меньше.</returns>
        public int CompareTo(Item other)
        {
            if (this.Cost == other.Cost)
                return 0;
            if (this.Cost > other.Cost)
                return 1;
            return -1;
        }
    }
}
