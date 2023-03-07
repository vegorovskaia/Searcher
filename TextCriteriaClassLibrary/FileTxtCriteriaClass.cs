using System;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using InterfaceClassLibrary;

namespace TextCriteriaClassLibrary
{

    [Export(typeof(IMatch))]
    [ExportMetadata("Mask", "*.txt")]
    
    class SearchFileCriteria_Txt : CommonCriteriaClassLibrary.SearchCommonCriteria 
    {
        private TxtCriteriaValues txtCriteriaValues;

        uiTxtCriteria gui;
        public SearchFileCriteria_Txt()   
        {
            txtCriteriaValues = new TxtCriteriaValues();
            //create UserControl and let it to fill criterias
            gui = new uiTxtCriteria(txtCriteriaValues);
        }

        public SearchFileCriteria_Txt(TxtCriteriaValues txtCriteriaValues )  // constructor for unit-testing. Not good?..
        {
            this.txtCriteriaValues = txtCriteriaValues ?? new TxtCriteriaValues() ;
            gui = new uiTxtCriteria(txtCriteriaValues);
        }

        override public UserControl UI
        {
            get { return gui; }
        }


        override public  bool MatchCustom(FileInfo fInfo)
        {

            //Thread.Sleep(10000); //for testing
            {
                String txt_line;
                using (StreamReader sr = new StreamReader(fInfo.FullName))
                {
                    txt_line = sr.ReadLine();
                    while (txt_line != null)
                    {
                        if (txt_line.Contains(txtCriteriaValues.Substring))
                            return true;
                         txt_line = sr.ReadLine();
                    }
                }
            }
            return false;
        }
    }
    public class TxtCriteriaValues     // substring to search
    {
        public string Substring = "";
    }
}
