using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_7
{
    class Employee
    {
        public int Id;
        public string Name;
        public string City;
        public int Salary;
    }

    internal class Ques_3
    {
        static void Main()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee{Id=1, Name="Ravi", City="Bangalore", Salary=50000},
                new Employee{Id=2, Name="Anu", City="Chennai", Salary=40000},
                new Employee{Id=3, Name="Kiran", City="Bangalore", Salary=60000}
            };

            // a. All employees
            foreach (var e in list)
                Console.WriteLine(e.Name + " " + e.City + " " + e.Salary);

            // b. Salary > 45000
            foreach (var e in list.Where(x => x.Salary > 45000))
                Console.WriteLine(e.Name);

            // c. Bangalore employees
            foreach (var e in list.Where(x => x.City == "Bangalore"))
                Console.WriteLine(e.Name);

            // d. Sort by name
            foreach (var e in list.OrderBy(x => x.Name))
                Console.WriteLine(e.Name);
        }
    }
}