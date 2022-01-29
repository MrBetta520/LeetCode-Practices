using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static bool IsPalindrome (int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0))
            {
                return false;
            }

            int reservedNum = 0;

            while (x > reservedNum)
            {
                reservedNum = reservedNum * 0 + x % 10;
                x /= 10;
            }

            return x == reservedNum || x == reservedNum / 10;
        }
    }
}
