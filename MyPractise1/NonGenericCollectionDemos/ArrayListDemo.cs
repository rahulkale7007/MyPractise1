/*using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.NonGenericCollectionDemos
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity); // zero capacity at initial stage

            // use add to add elements in arraylist

            al.Add("Rahul");
            al.Add("Jitesh");
            al.Add(1);
            al.Add(2);
            al.Add("sharu");

            //to check elements store in arraylist..
            Console.WriteLine(al.Capacity);

            Console.WriteLine("............................................................");

            //to check total elements store in array list
            Console.WriteLine(al.Count);
            Console.WriteLine(".............................................................");

            // to add elements in arraylist we use insert
            al.Insert(1, 4);
            // al.RemoveAt(1);
            //  al.Clear();
            Console.WriteLine("............................");

            al.Contains("Jitesh");
            Console.WriteLine("...............................");

            //al.Sort();
            al.Reverse();
            //al.Remove("sharu");
            // al.RemoveAt(4);
           
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
*/