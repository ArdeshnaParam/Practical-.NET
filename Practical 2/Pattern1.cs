﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j <i; j++)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
