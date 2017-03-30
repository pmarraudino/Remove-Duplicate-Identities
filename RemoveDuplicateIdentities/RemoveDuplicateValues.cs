using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RemoveDuplicateIdentities
{
    class RemoveDuplicateValues
    {
        static public void RmvDupValues()
        {
            var allLines = File.ReadAllLines(PathFinder.FilePath("EmpId.csv"));
            var uniqueLines = new List<Tuple<string, string, string>>();
            foreach (string line in allLines)
            {
                var column = line.Split(',');
                if (uniqueLines.FirstOrDefault(currentLine => currentLine.Item1 == column[0] || currentLine.Item3 == column[2]) == null)
                {
                    uniqueLines.Add(new Tuple<string, string, string>(column[0], column[1], column[2]));
                }
            }

            using (StreamWriter writer = new StreamWriter(File.Open(PathFinder.FilePath("EmpId_dupRmv.csv"), FileMode.Create)))
                foreach (var item in uniqueLines)
                {
                    writer.WriteLine($"{item.Item1}, {item.Item2}, {item.Item3}");
                }
        }

    }
}
