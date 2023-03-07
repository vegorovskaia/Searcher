using System.ComponentModel;

namespace InterfaceClassLibrary
{
    public interface ISearch        // search engine
    {
        void Search();
        ISearchParams parameters { set; }
        IMask mask { set; }
        IMatch criteria { set; }
        event RunWorkerCompletedEventHandler Completed;
        event ProgressChangedEventHandler Founded;
        void Cancel();

    }
}
