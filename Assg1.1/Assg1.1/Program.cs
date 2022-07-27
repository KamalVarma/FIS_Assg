using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[5];
            Console.WriteLine("Enter 5 numbers");
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = Arr[1];
            int max = Arr[1];
            int count = 0;
            for(int i=0;i<Arr.Length;i++)
            {
                count += Arr[i];
                if (Arr[i] < min)                
                    min = Arr[i];                
                if (Arr[i] > max)                
                    max = Arr[i];                
            }
            Console.WriteLine("Average of the numbers is:" + count / 5);
            Console.WriteLine("Minimum number is:" + min);
            Console.WriteLine("Maximum number is:" + max);
            Console.Read();
        }
    }
}
