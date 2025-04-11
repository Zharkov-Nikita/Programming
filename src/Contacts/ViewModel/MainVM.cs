using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Model;
using Model.Services;

namespace ViewModel
{
    /// <summary>
    /// Реализует модель представления.
    /// </summary>
    public partial class MainVM : ObservableObject, INotifyPropertyChanged
    {
        /// <summary>
        /// Текущий контакт.
        /// </summary>
        [ObservableProperty]
        private Contact _currentContact;

        /// <summary>
        /// Редактируемый контакт.
        /// </summary>
        [ObservableProperty]
        private Contact _editContact;

        /// <summary>
        /// Возвращает и задаёт список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Возвращает и задаёт сериализатор контакта.
        /// </summary>
        public ContactSerializer ContactSerializer { get; set; }

        /// <summary>
        /// Команда сохранения контакта.
        /// </summary>
        public RelayCommand SaveCommand { get; }

        /// <summary>
        /// Команда загрузки контакта.
        /// </summary>
        public RelayCommand LoadCommand { get; }        

        /// <summary>
        /// Команда добавления контакта.
        /// </summary>
        public RelayCommand AddCommand { get; }        

        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        public RelayCommand EditCommand { get; }        

        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        public RelayCommand RemoveCommand { get; }        

        /// <summary>
        /// Команда применения изменений.
        /// </summary>
        public RelayCommand ApplyCommand { get; }        

        /// <summary>
        /// Команда Отмены изменений.
        /// </summary>
        public RelayCommand CancelCommand { get; }        

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
        /// Возвращает, доступно ли применение.
        /// </summary>
        public bool ApplyIsEnabled
        {
            get
            {
                return EditContact != null && string.IsNullOrWhiteSpace(EditContact.Error);
            }
        }

        /// <summary>
        /// Возвращает видимость.
        /// </summary>
        public bool ApplyIsVisible
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
            ContactSerializer = new ContactSerializer();
            SaveCommand = new RelayCommand(Save);
            LoadCommand = new RelayCommand(Load);
            AddCommand = new RelayCommand(Add);
            EditCommand = new RelayCommand(Edit);
            RemoveCommand = new RelayCommand(Remove);
            ApplyCommand = new RelayCommand(Apply);
            CancelCommand = new RelayCommand(Cancel);
            LoadCommand.Execute(Contacts);
            OnPropertyChanged(nameof(IsReadOnly));
        }

        /// <summary>
        /// Обновляет редактируемый контакт.
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
        /// Метод сохранения.
        /// </summary>
        private void Save()
        {
            ContactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Метод загрузки.
        /// </summary>
        private void Load()
        {
            try
            {
                var loadedContacts = ContactSerializer.LoadContact();
                if (loadedContacts != null)
                {
                    Contacts.Clear();
                    foreach (var contact in loadedContacts)
                    {
                        Contacts.Add(contact);
                    }
                }
            }
            catch
            {
                Contacts.Clear();
            }
        }

        /// <summary>
        /// Метод добавления.
        /// </summary>
        private void Add()
        {
            LoadCommand.Execute(Contacts);
            EditContact = new Contact("", "", "");
            OnPropertyChanged(nameof(IsReadOnly));
            OnPropertyChanged(nameof(ApplyIsVisible));
        }

        /// <summary>
        /// Метод редактирования.
        /// </summary>
        private void Edit()
        {
            OnPropertyChanged(nameof(IsReadOnly));
            OnPropertyChanged(nameof(ApplyIsVisible));
        }

        /// <summary>
        /// Метод удаления.
        /// </summary>
        private void Remove()
        {
            int index = Contacts.IndexOf(CurrentContact);
            Contacts.Remove(CurrentContact);
            SaveCommand.Execute(Contacts);
            if (index < Contacts.Count)
            {
                CurrentContact = Contacts[index];
            }
            else if (Contacts.Count > 0)
            {
                CurrentContact = Contacts[Contacts.Count - 1];
            }
            else
            {
                CurrentContact = null;
            }
        }

        /// <summary>
        /// Метод применения.
        /// </summary>
        private void Apply()
        {
            if (IsEnabled)
            {
                CurrentContact.Name = EditContact.Name;
                CurrentContact.Phone = EditContact.Phone;
                CurrentContact.Email = EditContact.Email;
                Contact currentContact = CurrentContact;
                CurrentContact = null;
                CurrentContact = currentContact;
            }
            else
            {
                Contacts.Add(EditContact);
                CurrentContact = Contacts.Last();
            }

            SaveCommand.Execute(Contacts);
        }

        /// <summary>
        /// Метод отмены.
        /// </summary>
        private void Cancel()
        {
            CurrentContact = null;
        }

        partial void OnCurrentContactChanged(Contact value)
        {
            OnPropertyChanged(nameof(CurrentContact));
            OnPropertyChanged(nameof(IsEnabled));
            EditContact = null;
            OnPropertyChanged(nameof(ApplyIsVisible));
            OnPropertyChanged(nameof(IsReadOnly));
            UpdateEditContact();
        }

        partial void OnEditContactChanged(Contact value)
        {
            OnPropertyChanged(nameof(EditContact));
            OnPropertyChanged(nameof(ApplyIsEnabled));
            if (_editContact != null)
            {
                _editContact.PropertyChanged += EditContact_PropertyChanged;
            }
        }

        /// <summary>
        /// Вызов проверки, должна ли быть доступна кнопка Apply.
        /// </summary>
        private void EditContact_PropertyChanged(object sender, EventArgs e)
        {
            OnPropertyChanged(nameof(ApplyIsEnabled));
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
