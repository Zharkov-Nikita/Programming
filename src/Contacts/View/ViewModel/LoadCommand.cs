﻿using System;
using System.Windows.Input;
using View.Model.Services;
using View.Model;
using System.Windows;
using System.Collections.ObjectModel;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует загрузку контакта.
    /// </summary>
    public class LoadCommand : ICommand
    {
        /// <summary>
        /// Возвращает и задаёт список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Возвращает и задаёт сериализатор контакта.
        /// </summary>
        public ContactSerializer ContactSerializer { get; set; }

        /// <summary>
        /// Происходит, когда диспетчер команд обнаруживает изменение источника команды.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Создаёт экземпляр класса  <see cref="LoadCommand"/>.
        /// </summary>
        /// <param name="contacts">Экземпляр ObservableCollection<Contact>.</param>
        public LoadCommand(ObservableCollection<Contact> contacts)
        {
            ContactSerializer = new ContactSerializer();
            Contacts = contacts;
        }

        /// <summary>
        /// Определяет, может ли команда выполняться в текущем состоянии.
        /// </summary>
        /// <param name="parameter">Данные, используемые данной командой.</param>
        /// <returns>true</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Определяет метод, вызываемый при вызове данной команды.
        /// </summary>
        /// <param name="parameter">Данные, используемые данной командой.</param>
        public void Execute(object parameter)
        {
            try
            {
                var loadedContacts = ContactSerializer.LoadContact();
                if (loadedContacts != null)
                {
                    Contacts.Clear();
                    foreach (var contact in loadedContacts)
                    {
                        Contacts.Add(contact);
                    }
                }
            }
            catch { }
        }
    }
}
