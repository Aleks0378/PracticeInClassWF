using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01._11
{
    public class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNum { get; set; }
        public string Adress { get; set; }

        public Contact() { }
        public Contact(string name, string surname, string phoneNum, string adress)
        {
            Name = name;
            Surname = surname;
            PhoneNum = phoneNum;
            Adress = adress;
        }
        public void Add()
        {

        }
        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Phone number: {PhoneNum}, Adress: {Adress}";
        }
    }
}
