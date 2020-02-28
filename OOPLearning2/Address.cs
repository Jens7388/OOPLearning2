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
                (bool isValid, string errorMessage) validationResult = ValidateStreetName(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(streetName), validationResult.errorMessage);
                }
                if(value != streetName)
                {
                    streetName = value;
                }
            }
        }

        public string StreetNumber
        {
            get { return streetNumber; }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateStreetNumber(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(streetNumber), validationResult.errorMessage);
                }
                if(value != streetNumber)
                {
                    streetNumber = value;
                }
            }
        }

        public string Zip
        {
            get { return zip; }
            set 
            {
                (bool isValid, string errorMessage) validationResult = ValidateZip(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(zip), validationResult.errorMessage);
                }
                if(value != zip)
                {
                    zip = value;
                }
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateCity(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(city), validationResult.errorMessage);
                }
                if(value != city)
                {
                    city = value;
                }
            }
        }

        public string Country
        {
            get { return country; }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateCountry(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(country), validationResult.errorMessage);
                }
                if(value != country)
                {
                    country = value;
                }
            }
        }

        public List<Person> Persons
        {
            get { return persons; }
            set
            {
                if(persons != value)
                {
                    value = persons;
                }
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
        public static (bool, string) ValidateZip(string zip)
        {
            if(zip is null)
            {
                return (false, "Zip er null!");
            }
            if(zip.Length < 2)
            {
                return (false, "Zip skal være på mindst 2 cifre!");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        public static (bool, string) ValidateCity(string city)
        {
            if(city is null)
            {
                return (false, "City er null!");
            }
            if(city.Any(c => char.IsDigit(c)))
            {
                return (false, "City må ikke indeholde andet end bogstaver og mellemrum!");
            }
            if(!city.Any(c => char.IsLetter(c)))
            {
                return (false, "City skal indeholde mindst et bogstav!");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        public static (bool, string) ValidateCountry(string country)
        {
            if(country is null)
            {
                return (false, "Country er null!");
            }
            if(country.Any(c => char.IsDigit(c)))
            {
                return (false, "Country må ikke indeholde andet end bogstaver og mellemrum!");
            }
            if(!country.Any(c => char.IsLetter(c)))
            {
                return (false, "Country skal indeholde mindst et bogstav!");
            }
            else
            {
                return (true, String.Empty);
            }
        }
    }
}