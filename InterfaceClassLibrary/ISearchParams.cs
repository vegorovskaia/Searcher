using System.IO;
using System.Windows.Forms;

namespace InterfaceClassLibrary
{
    public interface ISearchParams
    {
        string Path { get; }
        SearchOption searchOption { get; }  //  to search in subdirectories
        UserControl UI { get; }    // userControl to config parameters
    }
}
