
using System.Text.RegularExpressions;

namespace PalindromeApp 
{
    class Program
    {
        static string FormatStringInput(string value)
        {
            Regex reg = new Regex("[*'\",_&#@-]");
            return reg.Replace(value, string.Empty)
                      .Replace(" ", string.Empty)
                      .ToLower();
        }

        static bool CheckIfIsPalindromeInput(string input)
            => input.Equals(string.Join(string.Empty, input.Reverse()));

        static void Main(string[] args)
        {
            string input = Console.ReadLine() ?? string.Empty;
            bool result = CheckIfIsPalindromeInput(FormatStringInput(input));

            Console.WriteLine(result ? "Is a Palindrome!" : "Isn´t a Palindrome!");
        }
    }
}