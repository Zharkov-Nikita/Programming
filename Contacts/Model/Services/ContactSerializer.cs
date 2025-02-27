using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace View.Model.Services
{
    public class ContactSerializer
    {
        string path = @"C:\Users\5731gna\Documents\Contacts\contacts.json";

        public void SaveContact(Contact contact)
        {
            string newContact = JsonConvert.SerializeObject(contact);
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(newContact);
            sw.Close();
        }

        public Contact LoadContact()
        {
            StreamReader sr = new StreamReader(path);
            string readContact = sr.ReadLine();
            sr.Close();
            Contact contact = JsonConvert.DeserializeObject<Contact>(readContact);
            return contact;
        }
    }
}
