﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateIdentities
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines(@"C:\Users\pmarraud\Documents\EmpId.csv");
            var uniqueLines = new List<Tuple<string, string, string>>();
            foreach (string line in allLines)
            {
                var columns = line.Split(',');
                if (uniqueLines.FirstOrDefault(currentLine => currentLine.Item1 == columns[0] || currentLine.Item3 == columns[2]) == null)
                {
                    uniqueLines.Add(new Tuple<string, string, string>(columns[0], columns[1], columns[2]));
                }

            }

            using (StreamWriter writer = new StreamWriter(File.Open(@"C:\Users\pmarraud\Documents\EmpId_dupRmvd.csv", FileMode.Create)))
                foreach (var item in uniqueLines)
                {
                    writer.WriteLine($"{item.Item1}, {item.Item2}, {item.Item3}");
                    Console.WriteLine($"{item.Item1}, {item.Item2}, {item.Item3}");
                }
        }
    }
}
