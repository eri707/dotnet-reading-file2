using System;
using System.Collections.Generic;
using System.IO;

namespace dotnet_reading_file2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();
            using (StreamReader reader = new StreamReader("./fruits.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    fruits.Add(line);
                }
                //create a new empty list
                List<string> removedDuplicates = new List<string>();

                foreach (var fruit in fruits) //iterate the fruits list
                {
                    if (args[0] == fruit && removedDuplicates.Contains(fruit)) continue;
                    removedDuplicates.Add(fruit);
                }
                foreach (var fruit in removedDuplicates)
                {
                    Console.WriteLine(fruit);
                }
            }
        }
    }
}