/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.StringStudyDemo
{
    class FindSubstringFromString
    {
        static void Main(string[] args)
        {
            // rahul is rahul and
            string str;
            string findstr;

            Console.WriteLine("Input original string");
            str = Console.ReadLine();
            Console.WriteLine("input substring to be fo");
            findstr = Console.ReadLine();
            int index = str.IndexOf(findstr);
            if (index < 0)
            {
                Console.WriteLine("The substring is found");
            }
            else
            {
                Console.WriteLine("Found '{0}' in '{1}' at position {2}",findstr, str, index);
            }
            Console.ReadLine();
        }
    }
}
*/