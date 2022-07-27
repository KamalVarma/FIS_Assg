using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];
            int total = 0;
            Console.WriteLine("Enter 10 marks");
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = marks[1];
            int max = marks[1];
            for (int i = 0; i < marks.Length; i++)
            {
                total += marks[i];
                if (marks[i] < min)
                    min = marks[i];
                if (marks[i] > max)
                    max = marks[i];
            }
            Console.WriteLine("Total is:" + total);
            Console.WriteLine("Average is:" + total/10);
            Console.WriteLine("Minimum is:" + min);
            Console.WriteLine("Maximum is:" + max);
            Array.Sort(marks);
            Console.WriteLine("Ascending is:");
            foreach (int i in marks)
                Console.WriteLine(i + " ");
            Array.Reverse(marks);
            Console.WriteLine("Descending is:");
            foreach (int i in marks)
                Console.WriteLine(i + " ");
            Console.Read();
        }
    }
}


