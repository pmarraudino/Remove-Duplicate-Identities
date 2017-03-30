using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateIdentities
{
    class PathFinder
    {
        static public String FilePath(string fileName)
        {
            var path = Environment.CurrentDirectory + @"..\..\..\csvFiles\" + fileName;
            return path;
        }
    }
}
