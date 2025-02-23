using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;
using View.Model;

namespace View.ViewModel
{
    public class LoadCommand : ICommand
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

        public LoadCommand(Contact contact)
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
            Contact loadedContact = ContactSerializer.LoadContact();
            if (loadedContact != null)
            {
                Contact = loadedContact;
            }
        }
    }
}
