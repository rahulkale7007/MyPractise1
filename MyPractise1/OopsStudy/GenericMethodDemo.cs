/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.OopsStudy
{
    class GenericMethodDemo
    {
        class Example
        {
           *//* public static void ShowArray<T>(T[] arr)
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }*//*

            public static bool Check<t>(t a,t b)
            {
                bool c = a.Equals(b);
                return c;
            }
            
        }
        static void Main(string[] args)
        {
            *//*int[] numbers = new int[3];
            numbers[0] = 11;
            numbers[1] = 22;
            numbers[2] = 33;

            string[] names = { "rahul", "rajesh", "deepak" };
            double[] points = { 2.3, 4.5, 2.4 };


            Example.ShowArray(numbers);
            Example.ShowArray(names);
            Example.ShowArray(points);
*//*
            Console.WriteLine(Example.Check(10, 20));
            Console.WriteLine(Example.Check("RK","RK"));
            Console.WriteLine(Example.Check('a','a'));



            Console.ReadKey();
        }
    }
}
*/