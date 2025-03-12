using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace View.Model.Services
{
    /// <summary>
    /// Сериализует класс Contact.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Путь в папке с данными.
        /// </summary>
        private string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Contacts";

        /// <summary>
        /// Название файла с данными.
        /// </summary>
        private string _file = @"\contacts.json";

        /// <summary>
        /// Метод для сохранения контактов.
        /// </summary>
        /// <param name="contacts">Сохраняемые контакты</param>
        public void SaveContacts(ObservableCollection<Contact> contacts)
        {
            string jsonContacts = JsonConvert.SerializeObject(contacts);
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
            StreamWriter streamWriter = new StreamWriter(_path + _file);
            streamWriter.WriteLine(jsonContacts);
            streamWriter.Close();
        }

        /// <summary>
        /// Метод для загрузки контактов из файла.
        /// </summary>
        /// <returns>Загруженные контакты</returns>
        public ObservableCollection<Contact> LoadContact()
        {
            StreamReader streamReader = new StreamReader(_path + _file);
            string readContacts = streamReader.ReadLine();
            streamReader.Close();
            ObservableCollection<Contact> contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(readContacts);
            return contacts;
        }
    }
}
