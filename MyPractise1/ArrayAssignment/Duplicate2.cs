/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.ArrayAssignment
{
    class Duplicate2
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("enter array size");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];

            Console.WriteLine("enter array elements");

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Unique Elements");
            for (i = 0; i < s; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                        break;
                }
                if (i == j)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            Console.ReadKey();

        }
    }
}
*/