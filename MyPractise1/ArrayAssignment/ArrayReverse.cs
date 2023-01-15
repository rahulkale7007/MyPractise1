/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.ArrayAssignment
{
    class ArrayReverse
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];

            Console.WriteLine("enter array elements");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("reverse array is");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
*/