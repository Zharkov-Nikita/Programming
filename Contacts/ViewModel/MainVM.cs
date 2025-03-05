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
        /// Возвращает и задаёт контакт.
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Команда сохранения контакта.
        /// </summary>
        public SaveCommand SaveCommand
        {
            get
            {
                return _saveCommand ?? (_saveCommand = new SaveCommand(Contact));
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
                return Contact.Name;
            }
            set
            {
                Contact.Name = value;
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
                return Contact.Phone;
            }
            set
            {
                Contact.Phone = value;
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
                return Contact.Email;
            }
            set
            {
                Contact.Email = value;
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
            Contact = new Contact();
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
