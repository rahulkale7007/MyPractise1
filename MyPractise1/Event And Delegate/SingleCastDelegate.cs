/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.Event_And_Delegate
{

    public delegate void Calculation(int a, int b);

    class SingleCastDelegate
    {
        public static void Addition(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("Addition of result is: {0}",result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(SingleCastDelegate.Addition);
            obj.Invoke(25,25);
            Console.ReadKey();

        }
    }
}
*/