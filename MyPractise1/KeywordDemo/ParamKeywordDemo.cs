/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.KeywordDemo
{
    class ParamKeywordDemo
    {
        public static int add(params int[] nums)
        {
            int sum = 0;

            foreach (int  i in nums)
            {
                sum = sum + i;
            }
            return sum;

        }
        static void Main(string[] args)
        {

            Console.WriteLine(ParamKeywordDemo.add(10,20,30,40));
            Console.ReadLine();
        }
    }
}
*/