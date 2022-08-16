using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Person
    {
        public static void AddPerson()
        {
            String FirstName, lastName, email, phoneNumber, password;

            Regex nameregex = new Regex("^([A-Z]{1}[a-z]{1}[a-z]{1}([a-z]+)?)$");
            Regex emailregex = new Regex("^([0-9a-zA-Z])+([.+-][0-9a-zA-Z]+)?@([0-9a-zA-Z])+([.][a-zA-Z]{2,4})([.][a-zA-Z]{2})?$");
            Regex mobileregex = new Regex("^([1-9]{2})(\\s)([0-9]{10})$");
            Regex passwdregex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

            Console.WriteLine("Enter First Name");
            var name = Console.ReadLine();
            Match matchfname = nameregex.Match(name);
            if (matchfname.Success)
                FirstName = name;
            else
                Console.WriteLine("Not Correct format");

            Console.WriteLine("Enter Last Name");
            var lName = Console.ReadLine();

            Match matchlname = nameregex.Match(lName);
            if (matchlname.Success)
                lastName = lName;
                //Console.WriteLine("match.value = " + matchlname.Value);
            else
                Console.WriteLine("Not Correct");

            Console.WriteLine("Enter Email");
            var mail = Console.ReadLine();

            Match matchemail = emailregex.Match(mail);
            if (matchemail.Success)
                email = mail;
            //Console.WriteLine("match.value = " + matchemail.Value);
            else
                Console.WriteLine("Not Correct");

            Console.WriteLine("Enter Mobile Number");
            var number= Console.ReadLine();

            Match matchmobile = mobileregex.Match(number);
            if (matchmobile.Success)
                phoneNumber = number;
            //Console.WriteLine("match.value = " + matchmobile.Value);
            else
                Console.WriteLine("Not Correct");

            Console.WriteLine("Enter password");
            var pass = Console.ReadLine();

            Match matchpasswd = passwdregex.Match(pass);
            if (matchpasswd.Success)
                password = pass;
            //Console.WriteLine("match.value = " + matchpasswd.Value);
            else
                Console.WriteLine("Not Correct");

        }
    }
}
