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
            int dailyWage = 20;
            int emp_Hrs = 0;
            Random random = new Random();
             int fullTime = 1;
            int partTime = 2;
            int EmployeeInput=random.Next(0,3);
            switch(EmployeeInput)
            {
                case 1: Console.WriteLine("Employee is present");
                        emp_Hrs=8;
                        break;
                case 2:
                       Console.WriteLine("Employee is present");
                       emp_Hrs = 4;
                       break;
                case 0:
                        Console.WriteLine("Employee is absent");
                        emp_Hrs = 0;
                        break;
            }    
            int empWage = dailyWage * emp_Hrs;
            Console.WriteLine("Employee Wage:" + empWage);
            Console.ReadLine();

        }
    }
}
