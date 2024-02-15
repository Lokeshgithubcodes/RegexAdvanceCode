using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAdvCodeProject
{
    public class Validation
    {
        public void emailvalid()
        {
            Console.WriteLine("Enter the email");
            string email=Console.ReadLine();
            string Epattern = @"^[a-zA-Z0-9.%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex r=new Regex(Epattern);
            bool res=r.IsMatch(email);
            if (res)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("not valid");
            }
        }

        public void phoneValid()
        {
            Console.WriteLine("Enter the phone number");
            string phone=Console.ReadLine();
            string ppattern = @"^[+91]{3}[0-9]{10}$";
            Regex r=new Regex(ppattern);
            bool res=r.IsMatch(phone);
            if (res)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }

        public void passwordValid()
        {
            Console.WriteLine("Enter the password");
            string password=Console.ReadLine();
            string Pwdpattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            Regex r = new Regex(Pwdpattern);
            bool res=r.IsMatch(password);
            if (res)
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
