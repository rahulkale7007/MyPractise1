/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.ArrayAssignment
{
    class SumOfArrayElements
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter array size");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];

            Console.WriteLine("enter array elements");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of array Elements" + sum);
            Console.ReadLine();
        }
    }
}
*/