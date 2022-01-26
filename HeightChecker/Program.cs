using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightChecker
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int HeightChecker(int[] heights)
        {
            int[] expected = new int[heights.Length];

            for (int i = 0; i < expected.Length; i++)
            {
                expected[i] = heights[i];
            }

            Array.Sort(expected);

            int n = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if(heights[i] != expected[i])
                {
                    n++;
                }
            }

            return n;
        }
    }
}
