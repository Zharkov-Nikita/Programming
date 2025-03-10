using Newtonsoft.Json;
using System;
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
        /// Метод для сохранения контакта
        /// </summary>
        /// <param name="contact">Сохраняемый контакт</param>
        public void SaveContact(Contact contact)
        {
            string jsonContact = JsonConvert.SerializeObject(contact);
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
            StreamWriter streamWriter = new StreamWriter(_path + _file);
            streamWriter.WriteLine(jsonContact);
            streamWriter.Close();
        }

        /// <summary>
        /// Метод для загрузки контакта из файла
        /// </summary>
        /// <returns>Загруженный контакт</returns>
        public Contact LoadContact()
        {
            StreamReader streamReader = new StreamReader(_path + _file);
            string readContact = streamReader.ReadLine();
            streamReader.Close();
            Contact contact = JsonConvert.DeserializeObject<Contact>(readContact);
            return contact;
        }
    }
}
