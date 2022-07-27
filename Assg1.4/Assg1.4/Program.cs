using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string:");
            string name = Console.ReadLine();
            Console.WriteLine($"Length of the first string is:{name.Length}");
            string name1 = rev(name);
            Console.WriteLine($"Reverse of the first string is:{name1}");

            Console.WriteLine("Enter second string to compare:");
            string com = Console.ReadLine();
            int state = string.Compare(name, com);
            if (state == 0)
                Console.WriteLine("Strings are same");
            else if (state < 0)
                Console.WriteLine("First string is smaller");
            else
                Console.WriteLine("Second string is smaller");
            Console.Read();
        }
        public static string rev(string str)
        {
            if (str.Length <= 1)
                return str;
            else
                return rev(str.Substring(1)) + str[0];
        }
    }
}
