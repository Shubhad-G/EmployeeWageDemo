using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    
    internal class EmpWageBuilder:IComputeEmpWage
    {

        //EmployeeWage[] employeeWageArray;
        int noOfCompanies=0;

        List<EmployeeWage> employeeWageArray;
        public EmpWageBuilder()//
        {
            this.employeeWageArray = new List<EmployeeWage>();
        }

        public void addEmpWage(string companyName, int maxWorkHrs, int maxWorkDays)//meaning
        {
            EmployeeWage empWage = new EmployeeWage(companyName, maxWorkHrs, maxWorkDays);
            this.employeeWageArray.Add(empWage);
            this.CalaucaleEmployeeWage(empWage);
        }



        public void CalaucaleEmployeeWage()
        {
            for(int i=0;i<noOfCompanies;i++)
            {
                employeeWageArray[i].setTotalEmpWage(this.CalaucaleEmployeeWage(this.employeeWageArray[i]));
            }
        }
        public int CalaucaleEmployeeWage(EmployeeWage employeeWage)
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
            while (days <= employeeWage.MaxWorkDays && totalHrs <= employeeWage.maxWorkHrs)
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
            Console.WriteLine("Total wage for company:" + employeeWage.companyName + " is :" + totalWage + "  Total Days:" + (days - 1) + " Total hours:" + totalHrs);
            return totalHrs * empWage;

        }
    }
}
