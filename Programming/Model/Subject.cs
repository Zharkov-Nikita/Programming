using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Subject
    {
        private string _name;
        private string _teacher;
        private int _grade;

        public string Name { get; set; }
        public string Teacher { get; set; }

        public int Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentException();
                }
                _grade = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название. Нет ограничений.</param>
        /// <param name="teacher">Преподаватель. Нет ограничений.</param>
        /// <param name="grade">Оценка. Не может быть меньше 1 и больше 5.</param>
        public Subject(string name, string teacher, int grade)
        {
            Name = name;
            Teacher = teacher;
            Grade = grade;
        }

        public Subject() { }
    }
}
