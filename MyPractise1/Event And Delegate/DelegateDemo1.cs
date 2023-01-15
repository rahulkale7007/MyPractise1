/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.Event_And_Delegate
{
    public delegate void Calculation(int a, int b);

    class DelegateDemo1
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is:{0} ", result);
        }
        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Substraction result is:{0} ", result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication result is:{0} ", result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division result is:{0} ", result);
        }

        static void Main(string[] args)
        {
            Calculation obj = new Calculation(DelegateDemo1.Addition);

            Calculation obj1 = new Calculation(DelegateDemo1.Addition);
            //  obj1.Invoke(20, 10);
            obj(20, 10);

            Calculation obj2 = new Calculation(DelegateDemo1.Substraction);
            //  obj2.Invoke(20, 10);
            obj2(20, 10);

            Calculation obj3 = new Calculation(DelegateDemo1.Multiplication);
            // obj3.Invoke(20, 10);
            obj3(20, 10);

            Calculation obj4 = new Calculation(DelegateDemo1.Division);
            // obj4.Invoke(20, 10);
            obj4(20, 10);




            Calculation obj = new Calculation(DelegateDemo1.Addition);
            obj.Invoke(20, 10);//30
            obj = Substraction;
            obj(20, 10);
            obj = Multiplication;
            obj(2, 3);
            obj = Division;
            obj(2, 4);
            Console.ReadLine();

        }
    }
}
*/