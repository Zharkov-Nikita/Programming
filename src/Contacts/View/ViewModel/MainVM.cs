using System.Collections.ObjectModel;
using System.ComponentModel;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует модель представления.
    /// </summary>
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
        /// Команда добавления контакта.
        /// </summary>
        private AddCommand _addCommand;

        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        private EditCommand _editCommand;

        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        private RemoveCommand _removeCommand;

        /// <summary>
        /// Команда применения изменений.
        /// </summary>
        private ApplyCommand _applyCommand;

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
                EditContact = null;
                OnPropertyChanged(nameof(Visibility));
                OnPropertyChanged(nameof(IsReadOnly));
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
        /// Команда добавления контакта.
        /// </summary>
        public AddCommand AddCommand
        {
            get
            {
                return _addCommand ?? (_addCommand = new AddCommand(this));
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

        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        public RemoveCommand RemoveCommand
        {
            get
            {
                return _removeCommand ?? (_removeCommand = new RemoveCommand(this));
            }
        }

        /// <summary>
        /// Команда применения изменений.
        /// </summary>
        public ApplyCommand ApplyCommand
        {
            get
            {
                return _applyCommand ?? (_applyCommand = new ApplyCommand(this));
            }
        }

        /// <summary>
        /// Возвращает, только ли на чтение.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return EditContact == null;
            }
        }

        /// <summary>
        /// Возвращает, доступно ли.
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                return CurrentContact != null;
            }
        }

        /// <summary>
        /// Возвращает видимость.
        /// </summary>
        public bool Visibility
        {
            get
            {
                return EditContact != null;
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

        /// <summary>
        /// Обновляет редактируемый контакт
        /// </summary>
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
