using System;
using System.Collections.Generic;

namespace HashSetDemo
{
    class Program
    {
        static void Main()
        {
            HashSet<Employees> employees = new HashSet<Employees>();


            employees.Add(new Employees(1, "Nandini", "IT" ));
            employees.Add(new Employees(2, "Nandu", "ISE"));
            employees.Add(new Employees(1, "Nandita", "CSE"));
            employees.Add(new Employees(4, "Nanlini", "Mech"));

            foreach (Employees employee in employees)
            {
                Console.WriteLine($"{employee.Employeeid},{employee.Name},{employee.Department}");
            }

            
        }
    }
}


