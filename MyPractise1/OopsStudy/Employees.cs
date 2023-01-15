/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.OopsStudy
{
    class Employees
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;

        public Employees(int EmpId, string EmpName, int EmpAge)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;
        }

        public override string ToString()
        {
            return ($"employee id{EmpId},en{EmpName},ea{EmpAge}");
        }
        static void Main(string[] args)
        {
            Employees e1 = new Employees(11, "rahul", 22);
            Console.WriteLine(e1.ToString());

            Employees e2 = new Employees(12, "jitesh", 21);
            Console.WriteLine(e2.ToString());
            Console.ReadLine();

        }
    }
}
*/