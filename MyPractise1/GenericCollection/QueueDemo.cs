/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.GenericCollection
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);

           
            // q.Dequeue();
            //Console.WriteLine(q.Count);
            foreach (int i in q)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("...........................");
            
            q.Peek();
            foreach (int i in q)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
*/