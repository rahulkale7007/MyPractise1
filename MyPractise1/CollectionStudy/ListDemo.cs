/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.CollectionStudy
{
    class ListDemo
    {
        static void Main(string[] args)
        {

            List<int> li = new List<int>();
            li.Add(10);
            li.Add(20);
            li.Add(30);

            var citynames = new List<string>()
            {
                "pune",
                "mumbai",
                "goa"
            };


            citynames.Add("pune");
            citynames.Add("mumbai");
            citynames.Add("manali");


            for (int i = 0; i < citynames.Count; i++)
            {
                Console.WriteLine(citynames[i]);
            }

            Console.WriteLine(".......................");

            foreach (var item in citynames)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("........................");

            Console.WriteLine(citynames.Contains("pune"));

            citynames.Remove("goa");

            citynames.ForEach(cname => Console.WriteLine(cname));

            Console.ReadLine();

        }
    }
}
*/