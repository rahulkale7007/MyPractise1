/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.CollectionStudy
{
    // how to take input from user in list demo
    class ListUser
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Enter the value");
                string s = Console.ReadLine();
                li.Add(s);
            }

            //  li.ForEach(c => Console.WriteLine(c));

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
*/