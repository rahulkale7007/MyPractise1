/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.InterFaceDemos
{
    class Car
    {
        public int model;
        public string cname;
        public int price;

        public Car(int model, string cname, int price)
        {
            this.model = model;
            this.cname = cname;
            this.price = price;
        }
    }

    class SortbyModel : IComparer<Car>
    {
        int IComparer<Car>.Compare(Car x, Car y)
        {
            return x.model - y.model;
        }
    }
    class SortbyName : IComparer<Car>
    {
        int IComparer<Car>.Compare(Car x, Car y)
        {
            //return x.cname.CompareTo(y.cname);
            return y.cname.CompareTo(x.cname);

        }
    }
    class SortbyPrice : IComparer<Car>
    {
        // if price is same then this step is used

        int IComparer<Car>.Compare(Car x, Car y)
        {
            if (x.price == y.price)
            {
                return y.model - x.model;
            }
            return x.price - y.price;
        }
    }
    class SortbyPrize : IComparer<Car>
    {
        int IComparer<Car>.Compare(Car x, Car y)
        {

            return x.price - y.price;
        }
    }
    class IComparerInterfaceDemo
    {
        static void Main(string[] args)
        {
            List<Car> li = new List<Car>();
            li.Add(new Car(10, "Audii", 8000000));
            li.Add(new Car(123,"BMW",8000000));
            li.Add(new Car(1020,"Santro",560000));
            li.Add(new Car(1432,"Slavia",660000));

            foreach (Car c in li)
            {
                Console.WriteLine(c.model+" "+c.cname+" "+c.price);
            }

            Console.WriteLine("......................................");

            li.Sort(new SortbyPrice());
            //li.Sort(new SortbyPrice());
            //  li.Sort(new SortbyName());   // asceding order
            //li.Sort(new SortbyName());
            //li.Sort(new SortbyModel());
            foreach (Car c in li)
            {
                Console.WriteLine(c.model+" "+c.cname+" "+c.price);
            }
            Console.ReadLine();
        }
    }
}
*/