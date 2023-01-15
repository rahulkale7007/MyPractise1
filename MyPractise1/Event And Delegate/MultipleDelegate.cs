/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.Event_And_Delegate
{

    public delegate void Calculation(int a, int b);

    public delegate void Show_Delegate();

    public delegate void Calculation2(int num);

    class MultipleDelegate
    {
        public static void Square(int num)
        {
            int square = num * num;
            Console.WriteLine("Square of {0} is {1}",num,square);
        }

        public static void Cube(int num)
        {
            int cube = num *num * num;
            Console.WriteLine("Cube of {0} is {1}", num, cube);
        }

        public static void Show()
        {
            Console.WriteLine("This is a show method !! ");
        }
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is:{0} ", result);
        }
        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Substraction result is:{0} ", result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication result is:{0} ", result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division result is:{0} ", result);
        }
        static void Main(string[] args)
        {
            *//*Show_Delegate obj = new Show_Delegate(Show);
            obj.Invoke();*//*

            Calculation2 obj = new Calculation2(Square);
            obj.Invoke(2);
            obj = Cube;
            obj.Invoke(3);
           *//* Calculation2 obj1 = new Calculation2(Cube);
            obj1.Invoke(3);
*//*
            Console.ReadKey();
        }
    }
}
*/