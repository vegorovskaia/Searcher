using System.IO;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using InterfaceClassLibrary;

namespace MoqSearchParams
{
    [Export(typeof(ISearchParams))]
    public class MoqSearchParams : ISearchParams
    {
        public string Path => System.IO.Path.GetFullPath("C:\\"); // ("D:\\Downloads"); // ("C:\\");
                                                                  //(@"..\..\..\..\..\FileSearcher\bin\Debug\Plugins");

        public SearchOption searchOption => SearchOption.AllDirectories;// .TopDirectoryOnly;

        public UserControl UI => null;
    }
}
