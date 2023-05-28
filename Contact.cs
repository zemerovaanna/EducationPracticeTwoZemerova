using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyasPhoneBook
{
    internal class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Contact(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public string ContactToString()
        {
            return $"{Name},{Phone}";
        }
    }
}