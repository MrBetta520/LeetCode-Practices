using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Words_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = ReverseWords(" a good  example");

            Console.WriteLine(s);
            Console.ReadLine();
        }

        static string ReverseWords(string s)
        {
            string[] sa = s.Trim().Split(' ');

            StringBuilder sb = new StringBuilder();

            for (int i = sa.Length - 1; i >= 0; i--)
            {
                if (sa[i] != "")
                {
                    sb.Append(sa[i]).Append(" ");
                }
            }

            return sb.ToString().Trim();
        }
    }
}
