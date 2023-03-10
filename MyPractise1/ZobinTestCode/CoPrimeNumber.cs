/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.ZobinTestCode
{
    class CoPrimeNumber
    {
        class GFG
        {

            // Recursive function to
            // return gcd of a and b
            static int __gcd(int a, int b)
            {
                // Everything divides 0
                if (a == 0 || b == 0)
                    return 0;

                // base case
                if (a == b)
                    return a;

                // a is greater
                if (a > b)
                    return __gcd(a - b, b);

                return __gcd(a, b - a);
            }

            // function to check and print if
            // two numbers are co-prime or not
            static void coprime(int a, int b)
            {

                if (__gcd(a, b) == 1)
                    Console.WriteLine("Co-Prime");
                else
                    Console.WriteLine("Not Co-Prime");
            }

            // Driver code
            public static void Main()
            {
                int a = 5, b = 6;
                coprime(a, b);
                a = 8;
                b = 16;
                coprime(a, b);
                Console.ReadLine();
            }
           
        }
       
    }
}
*/