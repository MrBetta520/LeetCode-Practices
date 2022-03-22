using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Pivot_Index
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int PivotIndex(int[] nums)
        {
            int sum = 0;
            int leftSum = 0;


            foreach (int n in nums)
            {
                sum += n;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (sum - nums[i] - leftSum == leftSum)
                {
                    return i;
                }
                leftSum += nums[i];
            }

            return -1;
        }
    }
}
