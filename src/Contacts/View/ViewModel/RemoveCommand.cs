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
    /// Реализует команду удаления контакта.
    /// </summary>
    public class RemoveCommand : ICommand
    {
        /// <summary>
        /// Возвращает и задаёт MainVM.
        /// </summary>
        MainVM MainVM { get; set; }

        /// <summary>
        /// Происходит, когда диспетчер команд обнаруживает изменение источника команды.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Создаёт экземпляр класса  <see cref="LoadCommand"/>.
        /// </summary>
        /// <param name="mainVM">Экземпляр MainVM.</param>
        public RemoveCommand(MainVM mainVM)
        {
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
            int index = MainVM.Contacts.IndexOf(MainVM.CurrentContact);
            MainVM.Contacts.Remove(MainVM.CurrentContact);
            MainVM.SaveCommand.Execute(MainVM.Contacts);
            try
            {
                MainVM.CurrentContact = MainVM.Contacts[index];
            }
            catch
            {
                try
                {
                    MainVM.CurrentContact = MainVM.Contacts[index - 1];
                }
                catch
                {
                    MainVM.CurrentContact = null;
                }
            }
        }
    }
}
