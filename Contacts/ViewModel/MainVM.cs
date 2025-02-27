﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Команда сохранения контакта.
        /// </summary>
        private SaveCommand saveCommand;

        /// <summary>
        /// Команда загрузки контакта.
        /// </summary>
        private LoadCommand loadCommand;

        /// <summary>
        /// Возвращает и задаёт контакт.
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Команда сохранения контакта.
        /// </summary>
        public SaveCommand SaveCommand
        {
            get
            {
                return saveCommand ??
                  (saveCommand = new SaveCommand(Contact));
            }
        }

        /// <summary>
        /// Команда загрузки контакта.
        /// </summary>
        public LoadCommand LoadCommand
        {
            get
            {
                return loadCommand ??
                  (loadCommand = new LoadCommand(this));
            }
        }

        /// <summary>
        /// Возвращает и задаёт ФИО контакта. Не может быть длиннее 100 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return Contact.Name;
            }
            set
            {
                Contact.Name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта. Не может быть длиннее 100 символов.
        /// </summary>
        public string Phone
        {
            get
            {
                return Contact.Phone;
            }
            set
            {
                Contact.Phone = value;
                OnPropertyChanged("Phone");
            }
        }

        /// <summary>
        /// Возвращает и задаёт почту контакта. Не может быть длиннее 100 символов.
        /// </summary>
        public string Email
        {
            get
            {
                return Contact.Email;
            }
            set
            {
                Contact.Email = value;
                OnPropertyChanged("Email");
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contact = new Contact();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
