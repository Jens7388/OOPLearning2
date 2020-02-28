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
            
            Address address = new Address("gade", "1", "72", "Vejle", "Danmark", new List<Person>() { });         
        }
    }
}