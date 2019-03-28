using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program1
{
    class vector
    {
        public int value;
    }
    class Program1
    {
        static int i = 25;
        public enum TimeOfDay
        {
            Morning = 0,
            Afternoon = 1,
            Evening = 2
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This is first program");
            //Scope of variables
            int i=5;
            Console.WriteLine("Scope of the variable {0}",i);
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {1}",i,Program1.i);
            }
            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine("{0}",k);
            }
            //Constant
            const int valueConst=25;
            Console.WriteLine("{0}",valueConst);
            //valueConst = 15;
            const int valueConst2 = 15;
            Console.WriteLine("{0}", valueConst2);
            //valueConst = valueConst2;
            Console.WriteLine("{0}",valueConst); 
            //Value Type DataTypes
            Console.WriteLine("Value Type");
            int val1, val2;
            val1 = 50;
            Console.WriteLine("val1= {0}",val1);
            val2 = val1;
            Console.WriteLine("val1= {0} val2= {1}", val1,val2);
            //Reference Type
            Console.WriteLine("Reference Type");
            vector x, y;
            x = new vector();
            x.value = 15;
            y = x;
            Console.WriteLine("x = {0}  y = {1}", x.value,y.value);
            y.value = 151;
            Console.WriteLine("x = {0}  y = {1}", x.value, y.value);
            Console.WriteLine("\n Interger Types");
            sbyte sb = 22;
            short s = 22;
            int i1 = 22;
            long l = 22L;
            Console.WriteLine("{0} sbtye\n{1} short\n{2} int\n{3} long\n",sb,s,i1,l);
            Console.WriteLine("Unsigned Integers");
            byte b = 21;
            ushort us = 21;
            uint ui = 21;
            ulong ul = 21;
            Console.WriteLine("{0} btye\n{1} ushort\n{2} uint\n{3} ulong\n", b, us, ui, ul);
            Console.WriteLine("Floating Point");
            float f = 11.22334455F;
            double d = 11.2233445566778899;
            Console.WriteLine("{0} float\n{1} double", f, d);
            decimal dec = 111.222333444555666777888999M;
            Console.WriteLine("Decimal:\n{0}", dec);
            Console.WriteLine("\nBoolean:");
            bool valBoolean = true;
            Console.WriteLine("Status: " + valBoolean);
            Console.WriteLine("\nCharacter:\nSingle Quote \'");
            Console.WriteLine("Double Quote \"");
            Console.WriteLine("Back Slash \\");
            char charA = 'A';
            Console.WriteLine(charA);
            int integerA = 2;
            Console.WriteLine("Predefined Reference Type");
            Object o1 = "This is object 1";
            Object o2 = 34;
            String strObj = o1 as string;
            Console.WriteLine(strObj);
            Console.WriteLine(o1.GetHashCode() + " " + o1.GetType());
            Console.WriteLine(o2.GetHashCode() + " " + o2.GetType());
            Console.WriteLine(o1.Equals(o2));
            string s1, s2;
            s1 = "String 1";
            s2 = s1;
            Console.WriteLine("S1 is: {0} and s2 is {1}", s1, s2);
            s2 = "New String 1";
            Console.WriteLine("S1 is: {0} and s2 is {1}", s1, s2);
            s1 = "c:\\NewFolder\\Hello\\P1.cs";
            Console.WriteLine(s1);
            s1 = @"c:\NewFolder\Hello\P1.cs";
            Console.WriteLine(s1);
            s1 = @"We can also write 
like this";
            Console.WriteLine(s1);
            Console.WriteLine("Flow control if statement");
            bool isZero;
            Console.WriteLine("\nFlow Control: (if)\ni is " + i);
            if (i == 0)
            {
                isZero = true;
                Console.WriteLine("i is Zero");
            }
            else
            {
                isZero = false;
                Console.WriteLine("i is Non - zero");
            }
            //else if
            Console.WriteLine("\nType in a string:");
            string input;
            input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("You typed in an empty string");
            }
            else if (input.Length < 5)
            {
                Console.WriteLine("The string had less than 5 characters");
            }
            else if (input.Length < 10)
            {
                Console.WriteLine("The string had at least 5 but less than 10 characters");
            }
            Console.WriteLine("The string was " + input);
            Console.WriteLine("\nSwitch:");

            switch (integerA)
            {
                case 1:
                    Console.WriteLine("integerA = 1");
                    break;
                case 2:
                    Console.WriteLine("integerA = 2");
                    //goto case 3;
                    break;
                case 3:
                    Console.WriteLine("integerA = 3");
                    break;
                default:
                    Console.WriteLine("integerA is not 1, 2, or 3");
                    break;
            }
            
            WriteGreeting(TimeOfDay.Morning);
            Console.WriteLine("Argument is: {0}", args[1]);
            Console.ReadLine();
        }
        static void WriteGreeting(TimeOfDay timeOfDay)
        {
            switch (timeOfDay)
            {
                case TimeOfDay.Morning:
                    Console.WriteLine("Good morning!");
                    break;
                case TimeOfDay.Afternoon:
                    Console.WriteLine("Good afternoon!");
                    break;
                case TimeOfDay.Evening:
                    Console.WriteLine("Good evening!");
                    break;
                default:
                    Console.WriteLine("Hello!");
                    break;
            }
        }
    }
   
}
