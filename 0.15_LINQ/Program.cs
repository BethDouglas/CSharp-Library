using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create array of instructors
            string[] instructors = { "Jay", "Paul", "Kenn", "Christoph", "Auri" };

            //Set up the query
            IEnumerable<string> query = from i in instructors
                                        where i.Length == 4
                                        select i;
            //Loop through
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }

            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee {ID=1,Name="Johnboy",HireDate=new DateTime(2016,3,5),isDude=true},
                new Employee {ID=2,Name="Jane",HireDate=new DateTime(2010,8,11),isDude=false},
                new Employee {ID=3,Name="Dude",HireDate=new DateTime(2016,6,2),isDude=true},
                new Employee {ID=4,Name="Nancy St. Stacy",HireDate=new DateTime(2016,1,1),isDude=false},
            };

            IEnumerable<Employee> queryTwo = from e in employees
                                             where e.HireDate.Year == 2016
                                             orderby e.Name ascending 
                                             select e;                                             
            //Loop through
            foreach (Employee employee in queryTwo)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
