using System;

namespace OOPLearning2
{
    class Program
    {
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
            
            Console.ReadLine();
        }
        private static void createPerson(string firstName, string lastName, DateTime birthDate, ContactInformation contactInformation) 
        {
                TimeSpan timeSpanAge = DateTime.Now.Subtract(birthDate);
                int age = timeSpanAge.Days / 365;
                Person person = new Person(firstName, lastName, birthDate, age, contactInformation);
                Console.WriteLine($"Fornavn: {firstName}");
                Console.WriteLine($"Efternavn: {lastName}");
                Console.WriteLine($"Fødselsdato: {birthDate.ToString("dd-MM-yyyy")}");
                Console.WriteLine($"Alder: {age}");
                Console.WriteLine($"Mail: {contactInformation.Mail}");
                Console.WriteLine($"Telefonnummer: {contactInformation.Phone}");
            
        }
    }
}
