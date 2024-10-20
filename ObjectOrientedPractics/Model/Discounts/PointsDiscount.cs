using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит информацию о скидке.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Количество баллов.
        /// </summary>
        private int _points;

        /// <summary>
        /// Возвращает и задаёт баллы. Не может быть меньше 0.
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _points = value;
            }
        }

        /// <summary>
        /// Возвращает размер скидки, доступной для этого списка продуктов с текущим количеством баллов.
        /// </summary>
        public double Calculate(List<Item> items)
        {
            double amount = 0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }
            double discount = amount * 0.3;

            if (Points < discount)
            {
                discount = Points;
            }
            return discount;
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            Points = Points - Convert.ToInt32(discount);
            return discount;
        }

        /// <summary>
        /// Добавляет баллы на основе полученного списка товаров.
        /// </summary>
        public void Update(List<Item> items)
        {
            double amount = 0.0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }
            _points += Convert.ToInt32(amount * 0.1);
        }

        /// <summary>
        /// Возвращает название скидки.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов";
            }
        }
    }
}
