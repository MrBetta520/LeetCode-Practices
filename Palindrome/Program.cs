using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string.");
            string s = Console.ReadLine();
            Palindrome(s);

            Console.ReadLine();
        }
        static void Palindrome (string s)
        {

            s = Regex.Replace(s, "[^a-zA-Z0-9]", String.Empty);

            char[] c = s.ToCharArray();

            Array.Reverse(c);
            string y = new string(c);

            if (s.ToLower().Equals(y.ToLower()))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
