using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg3._2
{
    abstract class student
    {
        public string name;
        public string ID;
        public double grade;
        public abstract bool isPassed(double grade);
    }

    class Grad : student
    {
        public override bool isPassed(double grade)
        {
            if (grade > 80.0f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Undergrad : student
    {
        public override bool isPassed(double grade)
        {
            if (grade > 70.0f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {            
            string pass = "passed";
            string fail = "failed";
            int a;

            Grad G = new Grad();
            Undergrad U = new Undergrad();            

            do
            {
                Console.WriteLine("\nSelect student type\n1 Grad\n2 Undergrad\n3 Exit");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("\nEnter name:");
                        G.name = Console.ReadLine();
                        Console.WriteLine("\nEnter ID:");
                        G.ID = Console.ReadLine();
                        Console.WriteLine("\nEnter grade:");
                        G.grade = Convert.ToDouble(Console.ReadLine());

                        if ((G.isPassed(G.grade)) == true)
                            Console.WriteLine($"{G.name} has {pass} ");
                        else
                            Console.WriteLine($"{G.name} has {fail} ");
                        
                        break;

                    case 2:
                        Console.WriteLine("\nEnter name:");
                        U.name = Console.ReadLine();
                        Console.WriteLine("\nEnter ID");
                        U.ID = Console.ReadLine();
                        Console.WriteLine("\nEnter grade:");
                        U.grade = Convert.ToDouble(Console.ReadLine());

                        if ((U.isPassed(U.grade)) == true)
                            Console.WriteLine($"{U.name} has {pass} ");
                        else
                            Console.WriteLine($"{U.name} has {fail} ");

                        break;

                    default:
                        Console.WriteLine("\nEnter valid number");
                        break;
                }
            } while (a != 3);                                    
        }
    }
}
