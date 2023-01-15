/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.OopsStudy
{
    public class Base
    {
        public virtual void Show()
        {
            Console.WriteLine("base class method invokes");
        }
    }
    public class Derived : Base
    {
        public  override void Show()
        {
            base.Show();
            Console.WriteLine("derived class method invokes");
        }
    }
    class MethodOverridingDemo
    {
        static void Main(string[] args)
        {
            Base b = new Derived();
            b.Show();
            Console.ReadLine();

        }
    }
}
*/