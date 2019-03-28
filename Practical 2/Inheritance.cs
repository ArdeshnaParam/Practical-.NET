using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Car
    {
       protected String name, fuel,id;
    }
    class Maruti: Car
    {
        internal Maruti(String name, String fuel, String id)
        {
            this.name = name;
            this.fuel = fuel;
            this.id = id;
            Console.WriteLine("{0} {1} {2}",this.name, this.fuel, this.id);
        }
    }
    class Mahindra : Car
    {
        internal Mahindra(String name, String fuel, String id)
        {
            this.name = name;
            this.fuel = fuel;
            this.id = id;
            Console.WriteLine("{0} {1} {2}",this.name, this.fuel, this.id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Maruti obj1= new Maruti("abc","petrol","123");
            Mahindra obj2 =new Mahindra("pqr","disel","456");
            Console.ReadKey();
        }
    }
}
