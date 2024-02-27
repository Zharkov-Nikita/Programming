using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentException();
                }
                _hours = value;
            }
        }

        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentException();
                }
                _minutes = value;
            }
        }

        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentException();
                }
                _seconds = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Часы. Не может быть меньше 0 и больше 60.</param>
        /// <param name="minutes">Минуты. Не может быть меньше 0 и больше 60.</param>
        /// <param name="seconds">Секунды. Не может быть меньше 0 и больше 60.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Time() { }
    }
}
