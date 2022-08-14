using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String FirstName;
            Console.WriteLine("Welcome to the Regex Implementation");
            
            Regex regex = new Regex("^([A-Z]{1}[a-z]{1}[a-z]{1}([a-z]+))$");

            FirstName = Console.ReadLine();
            Match match=regex.Match(FirstName);
            if (match.Success)
                Console.WriteLine("match.value = " + match.Value);

            
        }
    }
}