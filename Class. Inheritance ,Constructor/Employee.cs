using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Class._Inheritance__Constructor
{
    public class Employee
    {
        public int Id;
        public string Name = "No Name";
        public string Position = "No Position";
        public double Salary;
        public int HireDate;
        public string Department = "No Department";


        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Employee(int id, string name, string position, double salary, int hiredate, string department) : this(id, name)
        {
            Position = position;
            Salary = salary;
            HireDate = hiredate;
            Department = department;


        }

        public void GetDetailedInfo()
        {
            Console.WriteLine($"Id: {Id} \nName: {Name} \nPosition: {Position} \nSalary: {Salary} \nHireDate: {HireDate} \nDepartment: {Department}");
                                                                               
        }




    }
}
