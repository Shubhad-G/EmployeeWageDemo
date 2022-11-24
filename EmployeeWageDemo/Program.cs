using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Demo program");
            EmpWageBuilder company =  new EmpWageBuilder();
            company.addEmpWage("Demart", 100, 20);
            company.addEmpWage("Reliance", 50, 20);
            company.CalaucaleEmployeeWage();
            Console.ReadLine();

        }
    }
}
