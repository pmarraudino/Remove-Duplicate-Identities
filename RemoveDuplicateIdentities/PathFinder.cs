using System;

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
