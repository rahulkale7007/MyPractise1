/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.OopsStudy
{
    public class PermenentEmployee : Employees
    {
        public int phours;
        public int psalary;
    }
    public class VisitingEmployee : Employees
    {
        public int vsalary;
        public int vhours;
    }
    public class Employees
    {
        public int eid;
        public string ename;
        public int esalary;

    }
    class SingleMultipleInheritance
    {
        static void Main(string[] args)
        {
            PermenentEmployee p = new PermenentEmployee();
            p.ename = "Rahul";
            p.eid = 10;
            p.esalary = 230000;
            Console.WriteLine(p.ename+""+ p.eid+" "+p.esalary);

            Console.WriteLine("::::::::::::::::::::::::::::::::::");

            VisitingEmployee v = new VisitingEmployee();
            v.eid = 11;
            v.ename = "Jitesh";
            v.esalary = 450000;
            Console.WriteLine(v.ename + "" + v.eid + " " + v.esalary);
            Console.ReadLine();


        }
    }
}
*/