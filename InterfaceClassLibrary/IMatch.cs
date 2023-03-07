using System.IO;
using System.Windows.Forms;

namespace InterfaceClassLibrary
{
    public interface IMatch
    {
        bool MatchCommon(FileInfo fInfo);   // if file fits common criteria 
        bool MatchCustom(FileInfo fInfo);   // if file fits the criteria configurated for specific file type
        UserControl UI { get; }
    }
}
