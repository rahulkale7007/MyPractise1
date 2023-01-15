/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.ArrayAssignment
{
    class CopyOneArrayToAnother
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            Console.WriteLine("input elements to be stored in array ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Print array 1st elements");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("print array 1st elements");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine("print array 2nd elements");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.ReadLine();

        }
    }
}
*/