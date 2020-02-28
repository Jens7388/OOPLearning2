using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLearning2
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private ContactInformation contactInformation;
        private int age;

        public Person(string firstName, string lastName, DateTime birthDate, int age, ContactInformation contactInformation)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            ContactInformation = contactInformation;
            Age = age;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateFirstName(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(firstName), validationResult.errorMessage);
                }
                if(value != firstName)
                {
                    firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set 
            {
                (bool isValid, string errorMessage) validationResult = ValidateLastName(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(lastName), validationResult.errorMessage);
                }
                if(value != lastName)
                {
                    lastName = value;
                }
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateBirthDate(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(birthDate), validationResult.errorMessage);
                }
                if(value != birthDate)
                {
                    birthDate = value;
                }
            }
        }

        public ContactInformation ContactInformation
        {
            get { return contactInformation; }
            set
            {
                (bool isValid, string errorMessage) validationResultMail = ContactInformation.ValidateMail(value.Mail);
                if(!validationResultMail.isValid)
                {
                    throw new ArgumentException(nameof(ContactInformation.Mail), validationResultMail.errorMessage);
                }               
                (bool isValid, string errorMessage) validationResultPhone = ContactInformation.ValidatePhone(value.Phone);
                if(!validationResultPhone.isValid)
                {
                    throw new ArgumentException(nameof(ContactInformation.Phone), validationResultPhone.errorMessage);
                }
                if(value != contactInformation) 
                {
                    contactInformation = value;
                }
            } 
        }

        public int Age { get; }

        public static (bool, string) ValidateFirstName(string firstName)
        {
            if(firstName is null)
            {
                return (false, "FirstName er null!");
            }
            if(firstName.Length <= 1)
            {
                return (false, "FirstName må ikke være kortere end 2 cifre!");
            }
            if(!firstName.Any(c => char.IsLetter(c)))
            {
                return (false, "FirstName må kun indeholde bogstaver!");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        public static (bool, string) ValidateLastName(string lastName)
        {
            if(lastName is null)
            {
                return (false, "LastName er null!");
            }
            if(lastName.Any(c => char.IsNumber(c)))
            {
                return (false, "LastName må ikke indeholde tal!");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        public static (bool, string) ValidateBirthDate(DateTime birthDate)
        {
            if(birthDate > DateTime.Now)
            {
                return (false, "BirthDate er i fremtiden!");
            }
            if(birthDate == new DateTime(0001, 01, 01))
            {
                return (false, "Birthdate er ugyldig!");
            }
            else
            {
                return (true, String.Empty);
            }
        }                
    }
}
