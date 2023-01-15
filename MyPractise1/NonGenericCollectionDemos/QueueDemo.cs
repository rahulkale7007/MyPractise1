/*using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.NonGenericCollectionDemos
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Raj");
            q.Enqueue(1);
            q.Enqueue(10.10);
            q.Enqueue("Arjun");

            // q.Dequeue();
            Console.WriteLine("''''''''''''''''''''''''''''''''''");
            Console.WriteLine("Peek "+ q.Peek());
            q.Clear();
            Console.WriteLine("..................................");


            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
*/