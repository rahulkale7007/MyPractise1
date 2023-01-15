/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.InterFaceDemos
{
    class Employee //: IComparable<Employee>
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

        *//*public int CompareTo(Employee other)
        {
            // return this.name.CompareTo(other.name);
            return other.name.CompareTo(this.name);
        }
*/
/*        int IComparable<Employee>.CompareTo(Employee other)
        {
            // 2ND METHOD OF OR SHORT CUT METHOD TO DISPLAY ASCENDING AND DESCENDING ORDER BY USING SUBSTRACTION;

            //return this.id - other.id;
            return other.id - this.id;
        }

        int IComparable<Employee>.CompareTo(Employee other)
        {
            // SORTING ON THE BASIS OF ID IN DESCENDING ORDER

            if (other.id > this.id)
            {
                return 1;
            }
            else if (other.id < this.id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        int IComparable<Employee>.CompareTo(Employee other)
        {
            // SORTING ON THE BASIS OF ID IN ASCENDING ORDER

            if (this.id > other.id)
            {
                return 1;
            }
            else if (this.id < other.id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }*//*
    }
    class CustomListInterfaceDemo1
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee(100, "Rahul", 50000));
            li.Add(new Employee(105, "Jitesh", 60000));
            li.Add(new Employee(102, "Ganesh", 70000));
            li.Add(new Employee(106, "Mahesh", 650000));
            li.Add(new Employee(101, "Rajesh", 55000));


            foreach (Employee e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }

            Console.WriteLine(".................................");

            li.Sort();
            foreach (Employee e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }
            Console.ReadLine();
        }
    }
}
*/