using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует команду применения изменений.
    /// </summary>
    public class ApplyCommand : ICommand
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
        public ApplyCommand(MainVM mainVM)
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
            if (MainVM.IsEnabled)
            {
                MainVM.CurrentContact.Name = MainVM.EditContact.Name;
                MainVM.CurrentContact.Phone = MainVM.EditContact.Phone;
                MainVM.CurrentContact.Email = MainVM.EditContact.Email;
                MainVM.CurrentContact = MainVM.CurrentContact;
            }
            else
            {
                MainVM.Contacts.Add(MainVM.EditContact);
                MainVM.CurrentContact = MainVM.Contacts.Last();
            }
            MainVM.SaveCommand.Execute(MainVM.Contacts);
        }
    }
}
