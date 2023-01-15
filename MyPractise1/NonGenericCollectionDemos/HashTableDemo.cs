/*using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.NonGenericCollectionDemos
{
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            *//* Hashtable ht = new Hashtable()
             {
                 {"Id",10 },
                 {"Name","Rahul" },
                 {"Designation","Manager" },
                 {"Age",24 },
                 {"IsMarried","False" }

             };*//*
            Hashtable ht = new Hashtable();
            ht.Add("Id", 10);
            ht.Add("Name", "Rahul");
            ht.Add("Salary", 35000.00);
            ht.Add("Designation", "Manager");
            ht.Add("IsMarried", false);

            Console.WriteLine(ht.Count);
            Console.WriteLine("Rahul".GetHashCode());
            Console.WriteLine(ht.Contains("age"));
            Console.WriteLine(ht.ContainsValue("Rahul"));
           // Console.WriteLine(ht.ContainsKey("age"));
           *//* foreach (object key in ht.Keys)
            {
                Console.WriteLine(key+" : "+ht[key]);
            }
            Console.WriteLine("......................");
*/
          /* // ht.Clear();
            //ht.Remove("Salary");
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }
*//*
           
            Console.ReadLine();
         
        }
    }
}
*/