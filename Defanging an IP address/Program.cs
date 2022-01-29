using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defanging_an_IP_address
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = DefangIPaddr("1.1.1.1");
            Console.WriteLine(s);
            Console.ReadLine();
        }
        static string DefangIPaddr (string address)
        {
            string defangIP = "";

            for(int i = 0; i < address.Length; i++)
            {
                char c = address[i];

                if(c == '.')
                {
                    defangIP += "[.]";
                }
                else
                {
                    defangIP += c;
                }
                
            }
            return defangIP;
        }
    }
}
