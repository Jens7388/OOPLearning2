using System;
using System.Collections.Generic;


namespace OOPLearning2
{
    class Program
    {
        static Person richard;

        static void Main()
        {           
            try
            {               
                createPerson("Richard", "Head", new DateTime(1969, 9, 6), new ContactInformation("Headboss@mail.co.ck", "42069666"));          
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            createAddress("420th street", "69", "1234", "Intercourse", "USA", new List<Person>() { richard });
            Console.ReadLine();
        }

        private static void createPerson(string firstName, string lastName, DateTime birthDate, ContactInformation contactInformation) 
        {
                TimeSpan timeSpanAge = DateTime.Now.Subtract(birthDate);
                int age = timeSpanAge.Days / 365;
                richard = new Person(firstName, lastName, birthDate, age, contactInformation);
                Console.WriteLine("Personer: ");
                Console.WriteLine($"Fornavn: {firstName}");
                Console.WriteLine($"Efternavn: {lastName}");
                Console.WriteLine($"Fødselsdato: {birthDate.ToString("dd-MM-yyyy")}");
                Console.WriteLine($"Alder: {age}");
                Console.WriteLine($"Mail: {contactInformation.Mail}");
                Console.WriteLine($"Telefonnummer: {contactInformation.Phone}\n");           
        }

        private static void createAddress(string streetName, string streetNumber, string zip, string city, string country, List<Person> persons) 
        {
            Address address = new Address(streetName, streetNumber, zip, city, country, persons);
            Console.WriteLine("Adresser: ");
            Console.WriteLine($"Gadenavn: {streetName}");
            Console.WriteLine($"Husnummer: {streetNumber}");
            Console.WriteLine($"Postnummer: {zip}");
            Console.WriteLine($"By: {city}");
            Console.WriteLine($"Land: {country}");
            Console.WriteLine($"Beboere: ");
            foreach(Person person in persons)
            {
                Console.Write($"{person.FirstName} {person.LastName} ");
            }
        }
    }
}