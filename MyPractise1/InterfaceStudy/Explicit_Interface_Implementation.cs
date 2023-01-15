/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.InterfaceStudy
{
    interface i1
    {
        void Show();
    }
    interface i2
    {
        void Show();
    }
    class MyClass : i1, i2
    {
        void i1.Show()
        {
            Console.WriteLine("this is a method of i1 interface");
        }

        void i2.Show()
        {
            Console.WriteLine("this is a method of i2 interface");

        }
    }
    class Explicit_Interface_Implementation
    {
        static void Main(string[] args)
        {
            *//* MyClass obj = new MyClass();
             ((i1)obj).Show();
             ((i2)obj).Show();*//*

            i1 obj1 = new MyClass();
            obj1.Show();

            i2 obj2 = new MyClass();
            obj2.Show();

            Console.ReadLine();
        }
    }
}
*/