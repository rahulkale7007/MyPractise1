/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.OopsStudy
{
    class BaseClass
    {
        public void Show()
        {
            Console.WriteLine("Base class method invokes");
        }
    }
    class DerivedClass : BaseClass
    {
        public new void Show()
        {
            base.Show();
            //Console.WriteLine("derived class method invokes");
        }
    }
    class MethodHiding
    {
        static void Main(string[] args)
        {
            BaseClass bc = new DerivedClass();
            bc.Show();
            //((BaseClass)bc).Show();
            Console.ReadLine();
        }
    }
}
*/