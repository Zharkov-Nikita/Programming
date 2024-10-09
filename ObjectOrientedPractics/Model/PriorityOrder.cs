using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о приоритетном заказе.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        private DateTime _desiredDate;

        /// <summary>
        /// Желаемое время доставки.
        /// </summary>
        private string _desiredTime;

        /// <summary>
        /// Возвращает и задаёт желаемую дату доставки.
        /// </summary>
        public DateTime DesiredDate { get; set; }

        /// <summary>
        /// Возвращает и задаёт желаемое время доставки.
        /// </summary>
        public string DesiredTime { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        public PriorityOrder(DateTime desiredDate, string desiredTime) : base()
        {
            DesiredDate = desiredDate;
            DesiredTime = desiredTime;
        }

        public PriorityOrder() { }
    }
}
