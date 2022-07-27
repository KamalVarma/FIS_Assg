using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg3._1
{
    class Employee
    {
        public int empid { get; set; }
        public string name { get; set; }        
        public int salary { get; set; }

        public virtual void getsalary()
        {
            Console.WriteLine("\nSalary of the employee:" + this.salary);
        }
    }

    class P_Employee : Employee
    {
        private int pf { get; set; }

        public P_Employee(int e_id, string name, int salary, int pf)
        {
            this.empid = e_id;
            this.name = name;            ;
            this.salary = salary;
            this.pf = pf;
        }
        public override void getsalary()
        {
            Console.WriteLine("\nSalary of the permanent employee is:" + (salary - pf));
        }
    }

    class C_Employee : Employee
    {
        private int perk { get; set; }


        public C_Employee(int e_id, string name, int salary, int perk)
        {
            this.empid = e_id;
            this.name = name;         
            this.salary = salary;
            this.perk = perk;
        }
        public override void getsalary()
        {
            Console.WriteLine("\nSalary of the contract employee is:" + (salary + perk));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("\nSelect option\n1 Add employee\n2 Exit");
                num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("\nEnter Details:");

                        Console.WriteLine("\nEnter eID:");
                        int e_id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nEnter name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("\nEnter salary:");
                        int salary = Convert.ToInt32(Console.ReadLine());

                        start:
                        Console.WriteLine("\nSelect the type of Emplpoyee\n1 Contract Employee\n2 Permanent Employee");

                        int a = Convert.ToInt32(Console.ReadLine()); ;

                        if (a == 1)
                        {
                            Console.WriteLine("\nEnter the amount of perks:");
                            int perk = Convert.ToInt32(Console.ReadLine());
                            C_Employee obj = new C_Employee(e_id, name, salary, perk);
                            obj.getsalary();
                        }
                        else if (a == 2)
                        {
                            Console.WriteLine("\nEnter the amount of provident fund:");
                            int pf = Convert.ToInt32(Console.ReadLine());
                            P_Employee obj = new P_Employee(e_id, name, salary, pf);
                            obj.getsalary();
                        }
                        else
                        {
                            Console.WriteLine("\nEnter valid number");
                            goto start;
                        }
                        break;
                }
            } while (num != 2);                        
        }
    }
}
