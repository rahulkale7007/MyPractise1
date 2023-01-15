/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.StringStudyDemo
{
    class LowerCaseUpperCase
    {
        static void Main(string[] args)
        {
            char[] arr1;
            Console.WriteLine("input your string");
            string str = Console.ReadLine();
            char ch;
            arr1 = str.ToCharArray(0,str.Length);
            for(int i = 0; i < str.Length; i++)
            {
                ch = arr1[i];
                if (char.IsLower(ch))
                {
                    Console.Write(char.ToUpper(ch));
                }
                else
                {
                    Console.Write(char.ToLower(ch));
                }
            }
           
            Console.ReadLine();
        }
    }
}
*/