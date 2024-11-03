namespace Class._Inheritance__Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager(1,"Elvin","Manager",5000,2016,"Management",75,3.5,40000,"Code Academy");

            manager1.GetDetailedInfo();
            Console.WriteLine("=================================================================");

            Employee employee1 = new Employee(1,"Nihad","Backend",1000,2020,"Software");

            employee1.GetDetailedInfo();
            Console.WriteLine("=================================================================");

            Project project1 = new Project(1, "E-commerce",2023,2024,400,"Unfinished");

            project1.GetDetailedInfo();
            




            



        }
    }

    

}
