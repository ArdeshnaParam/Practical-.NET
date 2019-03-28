using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace CopyFile2
{
    class Program
    {
        static void Main(string[] args)
        {
            String file1 = @"F:\16ce043\source.txt";
            String file2 = @"F:\16ce043\destination2.txt";
            String content = null;
            using (StreamReader reader = new StreamReader(file1))
            {
                using (StreamWriter writer = new StreamWriter(file2))
                {
                    while ((content = reader.ReadLine())!= null)
                    {
                        writer.WriteLine(content);
                    }
                }
            }
        }
    }
}
