/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.InterFaceDemos
{
    class Employee1 : IComparable
    {
        public int id;
        public string name;
        public int salary;

        public Employee1(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public int CompareTo(object obj)
        {
            // IF SALARY IS SAME THEN SORT ON BASIS OF ID AND ELSE DECENDING ORDER
            Employee1 e = (Employee1)obj;
            if (this.salary == e.salary)
            {
                return this.id - e.id;
            }
            else
            {
                return e.salary - this.salary;
            }
        }

        *//*public int CompareTo(object obj)
        {
            // ON THE BASIS OF STRING SORTING IN ASECENDING ORDER AND DESCENDING ORDER
            Employee1 e = (Employee1)obj;
            //return this.name.CompareTo(e.name);
            return e.name.CompareTo(this.name);
        }

        public int CompareTo(object obj)
        {
            // 2ND METHOD OF OR SHORT CUT METHOD TO DISPLAY ASCENDING AND DESCENDING ORDER BY USING SUBSTRACTION;

            Employee1 e = (Employee1)obj;
            //return this.id - e.id;
            return e.id - this.id;
        }


        public int CompareTo(object obj)
        {
            // SORTING ON THE BASIS OF ID IN DESCENDING ORDER

            Employee1 e = (Employee1)obj;
            if (e.id > this.id)
            {
                return 1;
            }
            else if (e.id < this.id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public int CompareTo(object obj)
        {
            // SORTING ON THE BASIS OF ID IN ASCENDING ORDER

            Employee1 e = (Employee1)obj;
            if (this.id > e.id)
            {
                return 1;
            }
            else if (this.id < e.id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }*//*
    }
    class NonGenericInterfaceDemo1
    {
        static void Main(string[] args)
        {
            List<Employee1> li = new List<Employee1>();
            li.Add(new Employee1(100, "Rahul", 50000));
            li.Add(new Employee1(105, "Jitesh", 50000));
            li.Add(new Employee1(102, "Ganesh", 70000));
            li.Add(new Employee1(106, "Mahesh", 650000));
            li.Add(new Employee1(101, "Rajesh", 55000));


            foreach (Employee1 e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }

            Console.WriteLine(".................................");

            li.Sort();
            foreach (Employee1 e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }
            Console.ReadLine();
        }
    }
}
*/