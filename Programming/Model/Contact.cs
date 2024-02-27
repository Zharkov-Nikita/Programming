using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Contact
    {
        private string _name;
        private long _number;

        public string Name { get; set; }

        public long Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value <= 0 || value > 99999999999)
                {
                    throw new ArgumentException();
                }
                _number = value;
            }
        }

        public Contact(string name, long number)
        {
            Name = name;
            Number = number;
        }

        public Contact() { }
    }
}
