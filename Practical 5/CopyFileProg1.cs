using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace CopyFile1
{
    class Program
    {
        static void Main(string[] args)
        {
            String file1 = @"F:\16ce043\source.txt";
            String file2 = @"F:\16ce043\destination1.txt";
            using (StreamReader reader = new StreamReader(file1))
            {
                using (StreamWriter writer = new StreamWriter(file2))
                {
                    writer.Write(reader.ReadToEnd());
                }
            }
        }
    }
}
