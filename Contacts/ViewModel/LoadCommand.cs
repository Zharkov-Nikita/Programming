using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                Contact loadedContact = ContactSerializer.LoadContact();
                if (loadedContact != null)
                {
                    MainVM.Name = loadedContact.Name;
                    MainVM.Phone = loadedContact.Phone;
                    MainVM.Email = loadedContact.Email;
                }
            }
            catch
            {
                MessageBox.Show("Сохранение не найдено");
            }
        }
    }
}
