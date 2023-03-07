using System.Windows.Forms;
using System.IO;
using System.ComponentModel.Composition;
using InterfaceClassLibrary;

namespace ParamFileSearcher
{
    [Export(typeof(ISearchParams))]
    public class SearchParams :  ISearchParams 
    {
        public SearchParamsValues ParamsValues;

        ucParamsSettings gui;


        SearchParams()
        {
            ParamsValues = new SearchParamsValues();
            gui = new ucParamsSettings(ParamsValues);
        }

        public string Path  
        {
            get { return ParamsValues.Path; }
        }
        

        public  SearchOption searchOption
        {
            get {  return ParamsValues.subDir; }
        }

        public UserControl UI
        {
            get { return gui; }
        }
          
        
    }
}
