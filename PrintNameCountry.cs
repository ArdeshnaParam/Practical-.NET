using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintNameCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter Country");
            String country = Console.ReadLine();
            Console.WriteLine("Hello {0} from country {1}", name, country);
            Console.ReadKey();
        }
    }
}
