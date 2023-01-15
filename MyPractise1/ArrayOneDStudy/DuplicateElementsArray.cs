/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.ArrayOneDStudy
{
    class DuplicateElementsArray
    {
        static void Main(string[] args)
        {

            int i;
            int mm=1,ctr = 0;
            Console.Write("Input size of array: ");
            int s = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[s];
            int[] arr2 = new int[s];
            int[] arr3 = new int[s];
      
            Console.Write("Input elements in array: ");
            for (i = 0; i < s; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            //copying first array in second
            for(i = 0; i < s; i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }
            //marks the elements are duplicate
            for(i = 0; i < s; i++)
            {
                for(int j = 0; j < s; i++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = mm;
                        mm++;
                    }
                }
                mm = 1;
            }
            for (i = 0; i < s; i++)
            {
                if (arr3[i] == 2) { ctr++; }
            }
            Console.WriteLine(ctr);
            Console.ReadLine();
        }
    }
}
*/