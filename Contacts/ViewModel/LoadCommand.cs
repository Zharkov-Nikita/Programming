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
    public class LoadCommand : ICommand
    {
        MainVM MainVM { get; set; }

        /// <summary>
        /// Возвращает и задаёт сериализатор контакта.
        /// </summary>
        public ContactSerializer ContactSerializer { get; set; }

        public event EventHandler CanExecuteChanged;

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
            Contact loadedContact = ContactSerializer.LoadContact();
            if (loadedContact != null)
            {
                MainVM.Name = loadedContact.Name;
                MainVM.Phone = loadedContact.Phone;
                MainVM.Email = loadedContact.Email;
            }
        }
    }
}
