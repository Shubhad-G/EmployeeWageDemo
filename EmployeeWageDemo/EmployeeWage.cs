using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    internal class EmployeeWage
    {
        public string companyName;
        public int maxWorkHrs;
        public int MaxWorkDays;

        public EmployeeWage(string companyName, int maxWorkHrs, int maxWorkDays)
        {
            this.companyName = companyName;
            this.maxWorkHrs = maxWorkHrs;
            MaxWorkDays = maxWorkDays;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Demo program");
            EmployeeWage e =  new EmployeeWage("Demart",100,20);
            CalaucaleEmployeeWage(e.companyName,e.maxWorkHrs,e.MaxWorkDays);
            
            Console.ReadLine();

        }

        public static void CalaucaleEmployeeWage(string company,int maxWrkHrs,int maxWrkDays)
        {
            int dailyWage = 20;
            int emp_Hrs = 0;
            int totalHrs = 0;
            int totalWage = 0;
            Random random = new Random();
           /* int maxWrkHrs = 100;
            int maxWrkDays = 20;*/
            int days = 0;
            int empWage = 0;
            while (days <= maxWrkDays && totalHrs <= maxWrkHrs)
            {
                int EmployeeInput = random.Next(0, 3);
                switch (EmployeeInput)
                {
                    case 1:
                        Console.WriteLine("Employee is present");
                        emp_Hrs = 8;
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
                empWage = dailyWage * emp_Hrs;
                totalWage += empWage;
                days++;
                totalHrs += emp_Hrs;
            }
            Console.WriteLine("Total wage for company:" + company +" is :"+totalWage+"  Total Days:" + (days - 1) + " Total hours:" + totalHrs);
        }
    }
}
