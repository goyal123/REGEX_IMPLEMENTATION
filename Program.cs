using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String firstName,lastName,email,phoneNumber;
            
            Console.WriteLine("Welcome to the Regex Implementation");

            Regex nameregex = new Regex("^([A-Z]{1}[a-z]{1}[a-z]{1}([a-z]+)?)$");
            Regex emailregex = new Regex("^([^.][a-zA-Z0-9\\-]+)(.[a-z0-9]+)?@([a-zA-Z0-9\\-]+)\\.([a-z]{2,4})((.[a-z]{2,4})?)$");
            Regex mobileregex = new Regex("^([1-9]{2})(\\s)([0-9]{10})$");



            Console.WriteLine("Enter First Name");
            firstName = Console.ReadLine();

            Match matchfname=nameregex.Match(firstName);
            if (matchfname.Success)
                Console.WriteLine("match.value = " + matchfname.Value);
            else
                Console.WriteLine("Not Correct");

            Console.WriteLine("Enter Last Name");
            lastName = Console.ReadLine();

            Match matchlname = nameregex.Match(lastName);
            if (matchlname.Success)
                Console.WriteLine("match.value = " + matchlname.Value);
            else
                Console.WriteLine("Not Correct");


            Console.WriteLine("Enter Email");
            email = Console.ReadLine();

            Match matchemail = emailregex.Match(email);
            if (matchemail.Success)
                Console.WriteLine("match.value = " + matchemail.Value);
            else
                Console.WriteLine("Not Correct");

            Console.WriteLine("Enter Mobile Number");
            phoneNumber =Console.ReadLine();

            Match matchmobile = mobileregex.Match(phoneNumber);
            if (matchmobile.Success)
                Console.WriteLine("match.value = " + matchmobile.Value);
            else
                Console.WriteLine("Not Correct");

        }
    }
}