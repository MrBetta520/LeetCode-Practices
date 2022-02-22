using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_To_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = IntToBinary(511);
            int i = CountOne(s);
            Console.WriteLine(i);
            Console.ReadLine();
        }

        static string IntToBinary(int i)
        {
            StringBuilder sb = new StringBuilder();
            //Stack<string> stack = new Stack<string>();
            while (i > 0)
            {
                if (i % 2 == 0)
                {
                    sb.Append(0);
                }
                else if(i % 2 == 1)
                {
                    sb.Append(1);
                }
                i = i / 2;
            }

            string s = sb.ToString();
            string b = null;
            for (int j = s.Length - 1; j >= 0; j--)
            {
                b += s[j];
            }
            return b;
            
        }
        static int CountOne(string s)
        {
            int count = 0;
            int max = 0;
            foreach(var a in s)
            {
                if (a == '1')
                {
                    count += 1;
                    if (max < count)
                    {
                        max = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            return max;
        }
    }
}
