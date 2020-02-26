using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLearning2
{
    public class Address
    {
        private string streetName;
        private string streetNumber;
        private string zip;
        private string city;
        private string country;
        private List<Person> persons;

        public string StreetName { 
            get { return streetName; }
            set { }
        }
        public string StreetNumber
        {
            get { return streetNumber; }
            set { }
        }
        public string Zip
        {
            get { return zip; }
            set { }
        }
        public string City
        {
            get { return city; }
            set { }
        }
        public string Country
        {
            get { return country; }
            set { }
        }
        public List<Person> Persons
        {
            get { return persons; }
            set { }
        }
    }
}
