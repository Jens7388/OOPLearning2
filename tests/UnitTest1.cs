using OOPLearning2;
using System;
using System.Collections.Generic;
using Xunit;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Person person = new Person("Ivan", "Jerkov", new DateTime(2000, 04, 20), -1, new ContactInformation("jerkov@mail.ru", "12345678"));
            Address address = new Address("gade", "1", "72", "Vejle", "Danmark", new List<Person>() { });         
        }
    }
}
