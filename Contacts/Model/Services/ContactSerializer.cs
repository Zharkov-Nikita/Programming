using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    public class ContactSerializer
    {
        string path = @"C:\Users\5731gna\Documents\Contacts\contacts.json";

        public void SaveContact(Contact contact)
        {
            string shortiee = JsonConvert.SerializeObject(contact);
        }
    }
}
