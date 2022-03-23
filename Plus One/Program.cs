using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[] { 9, 8, 7, 6, 5 , 4, 3, 2, 1, 0 };
            int[] newD = PlusOne(digits);

            foreach(int i in newD)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(PlusOne(digits));

            Console.ReadLine();

        }

        public static int[] PlusOne(int[] digits)
        {
            //long total = 0;


            //for(int i = 0; i < digits.Length; i++)
            //{
            //    int index = digits.Length - i - 1;
            //    total += ((long)Math.Pow(10, index)) * digits[i];
            //}
            //string newDigit = (total + 1).ToString();
            ////char[] c = newDigit.ToCharArray();
            //int[] newD = new int[newDigit.Length];

            //for(int i = 0; i < newDigit.Length; i++)
            //{
            //    newD[i] = Convert.ToInt32(newDigit[i] - 48);
            //}

            //return newD;

            int n = digits.Length;
            
            // move along the input array starting from the end
            for (int i = n - 1; i >= 0; i--)
            {
                // set all the nines at the end of array to zeros
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                // here we have the rightmost not-nine
                else
                {
                    // increase this rightmost not-nine by 1
                    digits[i]++;
                    return digits;
                }
            }
            // we are here because all the digits are nines
            digits = new int[n + 1];
            digits[0] = 1;

            return digits;
        }
    }
}
