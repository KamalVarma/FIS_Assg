using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg1._3
{
    
    class Program
    {
        class marks
        {
            int html;
            int sql;
            int c;

            public void getmarks(int stu)
            {
                Console.WriteLine($"Enter marks of student {stu} for html, sql and C#:");
                this.html = Convert.ToInt32(Console.ReadLine());
                this.sql = Convert.ToInt32(Console.ReadLine());
                this.c = Convert.ToInt32(Console.ReadLine());
            }

            public int average()
            {
                return (this.html + this.sql + this.c) / 3;
            }
        }
        static void Main(string[] args)
        {
            marks mark1 = new marks();
            marks mark2 = new marks();
            marks mark3 = new marks();
            marks mark4 = new marks();
            marks mark5 = new marks();
            
            mark1.getmarks(1);
            mark2.getmarks(2);
            mark3.getmarks(3);
            mark4.getmarks(4);
            mark5.getmarks(5);

            int[] avg;
            avg = new int[5];

            avg[0] = mark1.average();
            avg[1] = mark2.average();
            avg[2] = mark3.average();
            avg[3] = mark4.average();
            avg[4] = mark5.average();

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Result of student {i + 1} is:");
                if (avg[i] < 50)                
                    Console.WriteLine("Fail");             
                else
                    Console.WriteLine("Pass");
            }
            Console.Read();
        }
    }
}
