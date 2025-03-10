using System;

namespace View.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// ФИО контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Почта контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Возвращает и задаёт ФИО контакта. Не может быть длиннее 100 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException();
                }
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта. Не может быть длиннее 100 символов.
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException();
                }
                _phone = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт почту контакта. Не может быть длиннее 100 символов.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException();
                }
                _email = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">ФИО контакта. Не может быть длиннее 100 символов.</param>
        /// <param name="phone">Номер телефона контакта. Не может быть длиннее 100 символов.</param>
        /// <param name="email">Email контакта. Не может быть длиннее 100 символов.</param>
        public Contact(string name = "Смирнов Юрий", string phone = "+7-913-111-22-33", string email = "yuri.smirnov@no.mail")
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
