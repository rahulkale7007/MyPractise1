/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// multiple inheritance with class does not exit in class 
// multiple inheritance with interface exist
namespace MyPractise1.OopsStudy
{
    class Person
    { 
        // for implicit conversion
        public void Show()
        {
            Console.WriteLine("this is method of parent class..");
        }
        *//* public void Show1()
         {
             Console.WriteLine("this is method of parent class..");
         }*//*
    }
    interface Employee
    {
        void Show();
    }
    interface Employee1
    {
        void Show();
    }
    class Teacher : Person, Employee,Employee1
    {
        // implicit
        void Employee.Show()
        {
            Console.WriteLine("this is a method of employee interface...");
        }

        void Employee1.Show()
        {
            Console.WriteLine("this is a method of employee 1 interface...");
        }
        *//* public void Show2()
         {
             Console.WriteLine("this is method of employee interface..");
         }*//*
    }
    class MultipleInheritanceDemo
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            t.Show();

            //for imlicit
            Employee e = new Teacher();
            e.Show();

            Employee1 e1 = new Teacher();
            e1.Show();
            Console.ReadKey();
        }
    }
}
*/