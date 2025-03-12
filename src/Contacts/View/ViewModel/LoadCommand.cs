using System;
using System.Windows.Input;
using View.Model.Services;
using View.Model;
using System.Windows;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует загрузку контакта.
    /// </summary>
    public class LoadCommand : ICommand
    {
        /// <summary>
        /// Возвращает и задаёт MainVM.
        /// </summary>
        MainVM MainVM { get; set; }

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
        /// <param name="mainVM">Экземпляр MainVM.</param>
        public LoadCommand(MainVM mainVM)
        {
            ContactSerializer = new ContactSerializer();
            MainVM = mainVM;
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
                    MainVM.Contacts.Clear();
                    foreach (var contact in loadedContacts)
                    {
                        MainVM.Contacts.Add(contact);
                    }
                }
            }
            catch { }
        }
    }
}
