using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class._Inheritance__Constructor
{
    public class Manager : Employee
    {
        public int TeamSize;
        public double YearsOfExperience;
        public double Budget;
        public string OfficeLocation = "No OfficeLocation";

        public Manager(int id, string name) : base(id, name)
        {

        }
        public Manager(int id, string name, string position,double salary, int hiredate, string department,int teamsize, double yearsofexperience,
            double budget, string officelocation) : base(id, name)
        {
            Position = position;
            Salary = salary;
            HireDate = hiredate;
            Department = department;
            TeamSize = teamsize;
            YearsOfExperience = yearsofexperience;
            Budget = budget;
            OfficeLocation = officelocation;
            

        }



    }
}
