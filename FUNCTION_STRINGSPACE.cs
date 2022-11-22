//Program to create a function to input a string and count the number of spaces in the string.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class FUNCTION_STRINGSPACE
    {
        public static void Main()

        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    count++;
            }


            Console.Write("Number of Spaces of the string = " +count);

        }
    }
}
