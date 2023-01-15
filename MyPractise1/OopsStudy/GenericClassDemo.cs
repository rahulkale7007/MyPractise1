/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.OopsStudy
{
    class Example<T>
    {
        T box;

        public T Box
        {
            set
            {
                this.box = value;
            }
            get
            {
                return this.box;
            }
        }
        //with using constructor
        *//* public Example(T b)
         {
             this.box = b;
         }
         public T getBox()
         {
             return this.box;
         }*//*
    }
    class GenericClassDemo
    {
        static void Main(string[] args)
        {
            // with using constructor
            *//* Example<int> e = new Example<int>(20);
             Console.WriteLine(e.getBox());

             Console.WriteLine("...................");

             Example<string> e1 = new Example<string>("Rahul");
             Console.WriteLine(e1.getBox());

             Console.WriteLine(".////////...........///////");

             Example<char> e2 = new Example<char>('a');
             Console.WriteLine(e2.getBox());*//*

            //using property

            Example<int> e = new Example<int>();
            e.Box = 20;
            Console.WriteLine(e.Box);

            Console.WriteLine("..................................");

            Example<string> e1 = new Example<string>();
            e1.Box = "rahul";
            Console.WriteLine(e1.Box);

            Console.ReadKey();
        }
    }
}
*/