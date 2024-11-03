using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class._Inheritance__Constructor
{
    public class Project
    {
        public int Id;
        public string Name;
        public int StartDate;
        public int EndDate;
        public double Budget;
        public string Status = "No status";


        public Project(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Project(int id, string name, int startdate, int enddate, double budget, string status) : this(id, name)
        {

            StartDate = startdate;
            EndDate = enddate;
            Budget = budget;
            Status = status;

        }

        public void GetDetailedInfo()
        {
            Console.WriteLine($"Id: {Id} \nName: {Name} \nStartDate: {StartDate} \nEndDate: {EndDate} \nBudget: {Budget} \nStatus: {Status}");
        }

    }
}
