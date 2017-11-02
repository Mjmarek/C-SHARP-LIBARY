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
            //Create new array of instructors
            string[] instructors = { "Jay", "Paul", "Kenn", "Dave", "Auri" };

            //Set up the query
            IEnumerable<string> query = from i in instructors//Convention: i comes from first letter of instructors 
                                        where i.Length == 4
                                        select i;

            //Loop through the array using the query
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }

            //EXAMPLE #2 - List of objects
            
            IEnumerable < Employee > employees = new List<Employee>()
            {
                new Employee {ID=1,Name="Johnboy",HireDate=new DateTime(2015,3,5)},
                new Employee {ID=2,Name="Janegirl",HireDate=new DateTime(2016,9,23)},
                new Employee {ID=3,Name="Atticus Finch",HireDate=new DateTime(2016,12,1)},
                new Employee {ID=4,Name="Boo Radley",HireDate=new DateTime(2017,8,21)},
                new Employee {ID=5,Name="Tom Sawyer",HireDate=new DateTime(2015,4,14)}
            };

            IEnumerable<Employee> queryTwo = from e in employees
                                             where e.HireDate.Year == 2016
                                             orderby e.Name ascending//Alphabetical order
                                             select e;

            foreach (Employee employee in queryTwo)
            {
                Console.WriteLine(employee.Name);
            }

            Console.ReadLine();
        }
    }
}
