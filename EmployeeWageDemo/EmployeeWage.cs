using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    public interface IComputeEmpWage
    {
        void addEmpWage(string companyName, int maxWorkHrs, int maxWorkDays);
         void CalaucaleEmployeeWage();
    }
    internal class EmployeeWage
    {

        public string companyName;
        public int maxWorkHrs;
        public int MaxWorkDays;
        public int totalEmpWage;

        public EmployeeWage(string companyName, int maxWorkHrs, int maxWorkDays)
        {
            this.companyName = companyName;
            this.maxWorkHrs = maxWorkHrs;
            MaxWorkDays = maxWorkDays;
        }

        public void setTotalEmpWage(int empWage)
        {
            totalEmpWage = empWage;
        }

    }
}
