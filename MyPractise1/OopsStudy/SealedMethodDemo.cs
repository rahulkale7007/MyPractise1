/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.OopsStudy
{
    class A
    {
        public  virtual void Show()
        {
            Console.WriteLine("base class method");
        }
    }
    class b : A
    {
        public sealed override void Show()
        {
            Console.WriteLine("derived class method");
        }
    }
   *//* class c : b
    {
        public override void Show()
        {
            Console.WriteLine("c class method");
        }
    }*//*
    class SealedMethodDemo
    {
        static void Main(string[] args)
        {
            c obj = new c();
            obj.Show();
            Console.ReadLine();
        }
    }
}
*/