using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg2._2
{
    class student
    {
        int rollno, clas, sem;
        string name, branch;
        int[] marks;

        public void getmarks()
        {
            marks = new int[5];
            Console.WriteLine("Enter marks of 5 subjects:");
            for(int i = 0; i < 5; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
        }
        
        public void displayresult()
        {
            int total = 0;
            for(int i = 0; i < 5; i++)
            {
                if (marks[i]<35)
                {
                    Console.WriteLine($"{name} of class {clas} roll no. {rollno} branch {branch} sem {sem} has failed because of marks being less than 35");
                    return;
                }
                total += marks[i];
            }
            if ((total / 5) < 50)
                Console.WriteLine($"{name} of class {clas} roll no. {rollno} branch {branch} sem {sem} has failed because of average being less than 50");
            else
                Console.WriteLine($"{name} of class {clas} roll no. {rollno} branch {branch} sem {sem} has passed");
        }

        public student() { }
        public student(string name, string branch, int roll, int sem, int clas)
        {
            this.branch = branch;
            this.name = name;
            this.rollno = roll;
            this.sem = sem;
            this.clas = clas;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            student stu = new student("Kamal", "IT", 29, 2, 9);
            stu.getmarks();
            stu.displayresult();
            Console.Read();
        }
    }
}
