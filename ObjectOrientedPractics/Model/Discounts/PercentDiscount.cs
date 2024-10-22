using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит информацию о скидке на конкретную категорию.
    /// </summary>
    public class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Процент скидки.
        /// </summary>
        private double _percent;

        /// <summary>
        /// Сумма покупок.
        /// </summary>
        private double _purchaseAmount;

        /// <summary>
        /// Возвращает и задаёт процент скидки. Не может быть меньше 0.
        /// </summary>
        public double Percent
        {
            get
            {
                return _percent;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _percent = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт сумму покупок. Не может быть меньше 0.
        /// </summary>
        public double PurchaseAmount
        {
            get
            {
                return _purchaseAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _purchaseAmount = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт категорию товара. Нет ограничений.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает размер скидки, доступной для этого списка продуктов.
        /// </summary>
        public double Calculate(List<Item> items)
        {
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    PurchaseAmount += item.Cost;
                }
            }

            double percent = Math.Round(PurchaseAmount * 0.001, 2);

            if (percent > 0.1)
            {
                percent = 0.1;
            }
            return Percent;
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            Percent = 0;
            return discount;
        }

        /// <summary>
        /// Добавляет проценты на основе полученного списка товаров.
        /// </summary>
        public void Update(List<Item> items)
        {
            Percent += Calculate(items);
            if (Percent > 0.1)
            {
                Percent = 0.1;
            }
        }

        /// <summary>
        /// Возвращает название скидки.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная {Category} - {Percent * 100}%";
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">Категория. Нет ограничений.</param>
        public PercentDiscount(Category category)
        {
            Category = category;
        }
    }
}
