using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static IList<string> FizzBuzz(int n)
        {
            List<string> s = new List<string>();
            
            for (int i = 1; i <= n; i++)
            {
                bool divisibleBy3 = (i % 3 == 0);
                bool divisibleBy5 = (i % 5 == 0);

                if (divisibleBy3 && divisibleBy5)
                {
                    s.Add("FizzBuzz");
                }
                else if (divisibleBy3)
                {
                    s.Add("Fizz");
                }
                else if (divisibleBy5)
                {
                    s.Add("Buzz");
                }
                else
                {
                    s.Add(Convert.ToString(i));
                }
            }

            return s;
        }
    }
}
