using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public void phoneValid(string phoneNo)
        {
            
            string ppattern = @"^[+91]{3}[0-9]{10}$";
            Regex r=new Regex(ppattern);
            
            if (r.IsMatch(phoneNo))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
        //-- password validation
        public void passwordValid(string pwdNo)
        {
            
            string Pwdpattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            Regex rp = new Regex(Pwdpattern);
            
            if (rp.IsMatch(pwdNo))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        // License Plates

        public void licenseplate(string plateNo)
        {
            string p1 = @"^[A-Z]{3}[0-9]{3}$";
            string p2 = @"^[A-Z]{2}[0-9]{3}[A-Z]{2}$";
            string p3 = @"^[0-9]{3}[A-Z]{4}$";

            Regex r1=new Regex(p1);
            Regex r2 = new Regex(p2);
            Regex r3 = new Regex(p3);

            if((r1.IsMatch(plateNo)) || (r2.IsMatch(plateNo)) || (r3.IsMatch(plateNo)))
            {
                Console.WriteLine("Valid L-plate");
            }
            else
            {
                   Console.WriteLine("Ivalid");
            }
            
        }

        
    }
}
