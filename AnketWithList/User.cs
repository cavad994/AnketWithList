using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketWithList
{
    internal class User
    {
        public User(string name, string surname, string mail, string phone, DateTime datetime)
        {
            Name = name;
            Surname = surname;
            Mail = mail;
            Phone = phone;
            this.datetime = datetime;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public DateTime datetime { get; set; }
    }
}
