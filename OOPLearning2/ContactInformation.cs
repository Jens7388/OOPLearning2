using System;
using System.Collections.Generic;
using System.Linq;
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

        public string Mail 
        {
            get { return mail; }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateMail(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(mail), validationResult.errorMessage);
                }
                if(value != mail)
                {
                    mail = value;
                }
            }
        }
        public string Phone {
            get { return phone; } 
            set 
            {
                (bool isValid, string errorMessage) validationResult = ValidatePhone(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(phone), validationResult.errorMessage);
                }
                if(value != phone)
                {
                    phone = value;
                }
            } 
        }

        public static (bool, string) ValidateMail(string mail)
        {
            if(mail is null)
            {
                return (false, "Mail er null!");
            }
            if(mail.Any(c => char.IsWhiteSpace(c)))
            {
                return (false, "Mail må ikke indeholde whitespaces!");
            }
            if(!mail.Contains("@"))
            {
                return (false, "Mail skal indeholde et '@'!");
            }
            if(!mail.Contains("."))
            {
                return (false, "Mail skal indeholde et domæne! f.eks '.com'");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        public static (bool, string) ValidatePhone(string phone)
        {
            if(phone is null)
            {
                return (false, "Phone er null!");
            }
            if(!phone.Any(c => char.IsNumber(c)))
            {
                return (false, "Phone må kun indeholde tal!");
            }
            if(phone.Length < 4)
            {
                return (false, "Phone må ikke være mindre end 4!");
            }
            if(phone.Length > 15)
            {
                return (false, "Phone må ikke være længere end 15!");
            }
            else
            {
                return (true, String.Empty);
            }
        }
    }
}
