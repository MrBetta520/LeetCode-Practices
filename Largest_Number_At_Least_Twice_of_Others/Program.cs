using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Number_At_Least_Twice_of_Others
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 6, 1, 0 };
            Console.WriteLine(DominantIndex(a));

            Console.ReadLine();
        }

        public static int DominantIndex(int[] nums)
        {
            if(nums.Length == 1)
            {
                return 0;
            }

            int max = nums.Max();
            int index = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == max)
                {
                    index = i;
                }
                else if(nums[i] != max && (nums[i] * 2 < max))
                {
                    index = -1;
                }
            }

            return index;
        }
    }
}
