using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms; // .Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace FileSearcher
{
    public interface ISearchParams
    {
        string sPath { get;  }
        //bool bSubDir { get;  }
        SearchOption searchOption { get; }
        UserControl UI { get;  }
    }
    
    public interface ISearch
    {
        //void Search(ISearchParams searchParams, IMatch criteria);
        void Search();
        ISearchParams parameters {set;}
        IMask mask { set;}
        IMatch criteria { set; }
        event RunWorkerCompletedEventHandler Completed;
        event ProgressChangedEventHandler Founded;
        void Cancel();
        
    }

    public interface IMask
    {
        string Mask { get; }
    }

    public interface IMatch
    {
        //string sGetMask();
        bool MatchCommon(FileInfo fInfo);
        bool MatchCustom(FileInfo fInfo);
        UserControl UI { get; }
    }
}
