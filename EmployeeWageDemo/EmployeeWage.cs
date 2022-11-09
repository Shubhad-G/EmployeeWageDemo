using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    internal class EmployeeWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Demo program");
            int dailyWage = 0;
            int fullTime = 8;
            Random random = new Random();
            int EmployeeInput=random.Next(0,2);
            if (EmployeeInput == 1)
            {
                Console.WriteLine("Employee is present");
                dailyWage = 20;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                dailyWage = 0;
            }    
            int empWage = dailyWage * fullTime;
            Console.WriteLine("Employee Wage:" + empWage);
            Console.ReadLine();

        }
    }
}
