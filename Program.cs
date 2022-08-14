using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String firstName,lastName;
            Console.WriteLine("Welcome to the Regex Implementation");

            Regex regex = new Regex("^([A-Z]{1}[a-z]{1}[a-z]{1}([a-z]+))$");

            Console.WriteLine("Enter First Name");
            firstName = Console.ReadLine();

            Match matchfname=regex.Match(firstName);
            if (matchfname.Success)
                Console.WriteLine("match.value = " + matchfname.Value);
            else
                Console.WriteLine("Not Correct");

            Console.WriteLine("Enter Last Name");
            lastName = Console.ReadLine();

            Match matchlname = regex.Match(lastName);
            if (matchlname.Success)
                Console.WriteLine("match.value = " + matchlname.Value);
            else
                Console.WriteLine("Not Correct");


        }
    }
}