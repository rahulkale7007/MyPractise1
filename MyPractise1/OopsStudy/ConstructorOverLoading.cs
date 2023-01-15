/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.OopsStudy
{
    public class Program
    {
        static Program()
        {
            Console.WriteLine("this is static const");
        }
        public Program()
        {
            Console.WriteLine("this is first constructor ");
        }
        public Program(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("this is second constructor" + c);
        }

        public Program(float a, float b)
        {
            float c = a + b;
            Console.WriteLine("this is third constructor" + c);
        }

    }
    class ConstructorOverLoading
    {
        static void Main(string[] args)
        {
            Program p = new Program(22.50f, 23.50f);
            Console.ReadLine();

        }
    }
}
*/