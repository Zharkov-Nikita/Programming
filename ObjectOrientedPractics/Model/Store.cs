using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        /// <summary>
        /// Товары магазина.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Покупатели магазина.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задаёт товары.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задаёт покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        public Store()
        { 
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}
