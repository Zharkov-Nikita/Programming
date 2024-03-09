using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Contact
    {
        private string _name;
        private string _surname;
        private long _number;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!AssertStringContainsOnlyLetters(value))
                {
                    throw new ArgumentException("Name записано неверно");
                }
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (!AssertStringContainsOnlyLetters(value))
                {
                    throw new ArgumentException("Surname записано неверно");
                }
                _surname = value;
            }
        }

        public long Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value <= 0 || value > 99999999999)
                {
                    throw new ArgumentException();
                }
                _number = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя. Не имеет ограничений.</param>
        /// <param name="number">Номер телефона. Не может быть длиннее 11 знаков.</param>
        public Contact(string name, string surname, long number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        public Contact() { }

        private bool AssertStringContainsOnlyLetters(string value)
        {
            if (Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            return false;
        }
    }
}
