using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLearning2
{
    public class ContactInformation
    {
        private string mail;
        private string phone;

        public ContactInformation(string mail, string phone)
        {
            Mail = mail;
            Phone = phone;
        }
        public string Mail { get { return mail; } set {} }
        public string Phone { get { return phone; } set {  } }
    }
}
