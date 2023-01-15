/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.CollectionStudy
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;

        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }

    class CustomListDemo2
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee(1, "rahul", 550000));
            li.Add(new Employee(2, "jitesh", 560000));
            li.Add(new Employee(3, "arun", 570000));
            li.Add(new Employee(4, "nayan", 580000));
            foreach (Employee e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }
            Console.ReadLine();
        }
    }
}
*/