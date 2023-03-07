using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace FileSearcher
{
    class SearchFileCriteria_Txt : SearchFileCriteria
    {
        string sMask = "*.txt";
        override public bool MatchCustom(FileInfo fInfo)
        {
            Thread.Sleep(30000);
            return true;
             //(5000);
        }
    }
}
