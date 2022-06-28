using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class RegexClass
    {
        public Regex FirstNameRegex = new Regex("^[A-Z]{1}[A-Za-z]{3,}$");
        public void ValidateFirstNameRegex(string FirstName)
        {
            Console.WriteLine("\nFirstName:" + FirstName);
            if (FirstNameRegex.IsMatch(FirstName))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("not valid");
            }
        }

        public Regex LastNameRegex = new Regex("^[A-Z]{1}[A-Za-z]{3,}$");
        public void ValidatelastNameRegex(string LastName)
        {
            Console.WriteLine("\nLastName:" + LastName);
            if (LastNameRegex.IsMatch(LastName))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
        }

        public Regex EmailIdRegex = new Regex("^[A-Za-z0-9]+([._+-][a-zA-Z0-9]+)+@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})$");
        public void ValidateEmailIdRegex(string EmailId)
        {
            Console.WriteLine("\nLastName:" + EmailId);
            if (LastNameRegex.IsMatch(EmailId))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
    







        



    

