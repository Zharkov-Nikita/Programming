using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о корзине.
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Товары корзины.
        /// </summary>
        private List<Item> _items;

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
                foreach (Item item in Items)
                {
                    amount += item.Cost;
                }
                return amount;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }

        /// <summary>
        /// Клонирует экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public object Clone()
        {
            return new Cart() { Items = this.Items};
        }
    }
}
