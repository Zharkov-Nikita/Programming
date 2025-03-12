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
        /// Возвращает и задаёт список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Возвращает и задаёт текущий контакт.
        /// </summary>
        public Contact CurrentContact { get; set; }

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
                return _loadCommand ?? (_loadCommand = new LoadCommand(this));
            }
        }

        /// <summary>
        /// Возвращает и задаёт ФИО контакта. Не может быть длиннее 100 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return CurrentContact.Name;
            }
            set
            {
                CurrentContact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта. Не может быть длиннее 100 символов.
        /// </summary>
        public string Phone
        {
            get
            {
                return CurrentContact.Phone;
            }
            set
            {
                CurrentContact.Phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        /// <summary>
        /// Возвращает и задаёт почту контакта. Не может быть длиннее 100 символов.
        /// </summary>
        public string Email
        {
            get
            {
                return CurrentContact.Email;
            }
            set
            {
                CurrentContact.Email = value;
                OnPropertyChanged(nameof(Email));
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
            CurrentContact = new Contact();
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
