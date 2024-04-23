using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о перелётах
    /// </summary>
    public class Flight
    {
        private string _departurePoint;
        private string _destination;
        private int _flightTime;

        public string DeparturePoint { get; set; }
        public string Destination { get; set; }

        public int FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTime));
                _flightTime = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departurePoint">Пункт вылета. Не имеет ограничений.</param>
        /// <param name="destination">Пункт назначения. Не имеет ограничений.</param>
        /// <param name="flightTime">Время полёта в минутах. Не может быть отрицательным.</param>
        public Flight(string departurePoint, string destination, int flightTime)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTime = flightTime;
        }

        public Flight() { }
    }
}
