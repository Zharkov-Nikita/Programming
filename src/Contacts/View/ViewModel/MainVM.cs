using System.Collections.ObjectModel;
using System.ComponentModel;
using View.Model;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Команда сохранения контакта.
        /// </summary>
        private SaveCommand _saveCommand;

        /// <summary>
        /// Команда загрузки контакта.
        /// </summary>
        private LoadCommand _loadCommand;

        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        private EditCommand _editCommand;

        /// <summary>
        /// Текущий контакт.
        /// </summary>
        private Contact _currentContact;

        /// <summary>
        /// Редактируемый контакт.
        /// </summary>
        private Contact _editContact;

        /// <summary>
        /// Возвращает и задаёт список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Возвращает и задаёт текущий контакт.
        /// </summary>
        public Contact CurrentContact
        {
            get 
            {
                return _currentContact;
            }
            set
            {
                _currentContact = value;
                OnPropertyChanged(nameof(CurrentContact));
                OnPropertyChanged(nameof(IsEnabled));
                UpdateEditContact();
            }
        }

        /// <summary>
        /// Возвращает и задаёт редактируемый контакт.
        /// </summary>
        public Contact EditContact
        {
            get
            {
                return _editContact;
            }
            set
            {
                _editContact = value;
                OnPropertyChanged(nameof(EditContact));
            }
        }

        /// <summary>
        /// Команда сохранения контакта.
        /// </summary>
        public SaveCommand SaveCommand
        {
            get
            {
                return _saveCommand ?? (_saveCommand = new SaveCommand(Contacts));
            }
        }

        /// <summary>
        /// Команда загрузки контакта.
        /// </summary>
        public LoadCommand LoadCommand
        {
            get
            {
                return _loadCommand ?? (_loadCommand = new LoadCommand(Contacts));
            }
        }

        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        public EditCommand EditCommand
        {
            get
            {
                return _editCommand ?? (_editCommand = new EditCommand(this));
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return CurrentContact == null;
            }
        }

        public bool IsEnabled
        {
            get
            {
                return CurrentContact != null;
            }
        }

        /// <summary>
        /// Событие, срабатывающее при изменении данных.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
            LoadCommand.Execute(Contacts);
            OnPropertyChanged(nameof(IsReadOnly));
        }

        public void UpdateEditContact()
        {
            if (CurrentContact != null)
            {
                EditContact = new Contact(CurrentContact.Name, CurrentContact.Phone, CurrentContact.Email);
            }
            else
            {
                EditContact = null;
            }
        }

        /// <summary>
        /// Извещает систему об изменении свойства. 
        /// </summary>
        /// <param name="prop">Свойство</param>
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
