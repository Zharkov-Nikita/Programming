﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует сохранение контакта.
    /// </summary>
    public class SaveCommand : ICommand
    {
        /// <summary>
        /// Возвращает и задаёт контакт.
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Возвращает и задаёт сериализатор контакта.
        /// </summary>
        public ContactSerializer ContactSerializer { get; set; }

        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Создаёт экземпляр класса  <see cref="SaveCommand"/>.
        /// </summary>
        /// <param name="mainVM">Экземпляр Contact.</param>
        public SaveCommand(Contact contact)
        {
            Contact = contact;
            ContactSerializer = new ContactSerializer();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ContactSerializer.SaveContact(Contact);
        }
    }
}
