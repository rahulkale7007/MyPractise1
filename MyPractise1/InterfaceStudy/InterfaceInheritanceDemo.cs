/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.InterfaceStudy
{
    interface i1
    {
        void Print();
    }

    interface i2
    {
        void Print1();
    }

    interface i3 : i1,i2
    {
        void Print2();
    }
    class Program :i3
    {
        public void Print()
        {
            Console.WriteLine("this is a method of interface 1");
        }
        public void Print1()
        {
            Console.WriteLine("this is a method of interface 1");
        }

        public void Print2()
        {
            Console.WriteLine("this is a method of interface 1");
        }
    }
   
    class InterfaceInheritanceDemo 
    {
       
        static void Main(string[] args)
        {
            *//* Program p = new Program();
             p.Print();
             p.Print1();
             p.Print2();*//*

            i3 myinterface = new Program();
            myinterface.Print();
            myinterface.Print2();
           // myinterface.Print3();

            Console.ReadLine();
        }
    }
}
*/