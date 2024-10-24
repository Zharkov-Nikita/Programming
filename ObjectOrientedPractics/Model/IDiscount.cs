using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает название скидки.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Возвращает размер скидки, доступной для этого списка продуктов.
        /// </summary>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        double Apply(List<Item> items);

        /// <summary>
        /// Добавляет проценты/баллы на основе полученного списка товаров.
        /// </summary>
        void Update(List<Item> items);
    }
}
