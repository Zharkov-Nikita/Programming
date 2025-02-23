using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace View.Model.Services
{
    public class ContactSerializer
    {
        string path = @"C:\Documents\Contacts\contacts.json";

        public void SaveContact(Contact contact)
        {
            string newContact = JsonConvert.SerializeObject(contact);
            File.WriteAllText(path, newContact);
        }

        public Contact LoadContact()
        {
            string readContact = File.ReadAllText(path);
            Contact contact = JsonConvert.DeserializeObject<Contact>(readContact);
            return contact;
        }
    }
}
