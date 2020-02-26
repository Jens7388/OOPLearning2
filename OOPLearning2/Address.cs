using System;
using System.Collections.Generic;
using System.Linq;
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

        public Address(string streetName, string streetNumber, string zip, string city, string country, List<Person> persons)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            Zip = zip;
            City = city;
            Country = country;
            Persons = persons;
        }

        public string StreetName { 
            get { return streetName; }
            set 
            { 

            }
        }
        public string StreetNumber
        {
            get { return streetNumber; }
            set
            {

            }
        }
        public string Zip
        {
            get { return zip; }
            set 
            {

            }
        }
        public string City
        {
            get { return city; }
            set
            {

            }
        }
        public string Country
        {
            get { return country; }
            set
            {

            }
        }
        public List<Person> Persons
        {
            get { return persons; }
            set
            {

            }
        }

        public static (bool, string) ValidateStreetName(string streetName)
        {
            if(streetName is null)
            {
                return (false, "StreetName er null!");
            }
            if(!streetName.Any(c => char.IsLetter(c)))
            {
                return (false, "StreetName skal indeholde bogstaver!");
            }
            else
            {
                return (true, String.Empty);
            }
        }
        public static (bool, string) ValidateStreetNumber(string streetNumber)
        {
            if(streetNumber is null)
            {
                return (false, "StreetNumber er null!");
            }
            if(!streetNumber.Any(c => char.IsNumber(c)))
            {
                return (false, "StreetNumber skal indeholde mindst et tal!");
            }
            if(streetNumber.Contains("-"))
            {
                return (false, "StreetNumber må ikke være negativt!");
            }
            else
            {
                return (true, String.Empty);
            }
        }
    }
}
