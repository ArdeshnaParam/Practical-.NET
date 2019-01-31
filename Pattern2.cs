using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            int value = int.Parse(s);
            for (int i = 1; i <= value; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("{0} ",j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
