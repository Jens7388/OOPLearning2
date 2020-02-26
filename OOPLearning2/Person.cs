using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLearning2
{
    public class Person
    {
        private string name;
        private DateTime birthDate;
        private ContactInformation contactInformation;

        public Person(string name, DateTime birthDate, ContactInformation contactInformation)
        {
            Name = name;
            BirthDate = birthDate;
            ContactInformation = contactInformation;
        }

        public string Name { get { return name; } set {} }
        public DateTime BirthDate { get { return BirthDate; } set {} }
        public ContactInformation ContactInformation { get { return contactInformation; } set {  } }
    }
}
