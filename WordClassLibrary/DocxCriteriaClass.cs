using System;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel.Composition;
using DocumentFormat.OpenXml.Packaging;
using InterfaceClassLibrary;


namespace WordClassLibrary
{
    [Export(typeof(IMatch))]
    [ExportMetadata("Mask", "*.docx")]
    class SearchFileCriteria_Docx : CommonCriteriaClassLibrary.SearchCommonCriteria
    {
        DocxCriteriaValues docxCriteriaValues;

        uiDocxCriteria gui; 

        public SearchFileCriteria_Docx()
        {
            docxCriteriaValues = new DocxCriteriaValues();
            //create UserControl and let it to fill criterias
            gui = new uiDocxCriteria(docxCriteriaValues);
        }

        override public UserControl UI
        {
            get { return gui; }
        }


        override public bool MatchCustom(FileInfo fInfo)
        {
            {
                using (WordprocessingDocument document = WordprocessingDocument.Open(fInfo.FullName, false))
                {
                    //get properties of the document
                    var props = document.PackageProperties;
                    Char dl = Convert.ToChar(7); // separator can not be used in TextBox
                    string sPropVals = props.Creator + dl + props.Subject + dl + props.Category + dl + props.Description + dl + props.Keywords + dl + props.Title;
                    if (sPropVals.Contains(docxCriteriaValues.Substring))
                        return true;
                    
                }
                return false;
            }
        }
    }
    public class DocxCriteriaValues     // from GUI
    {
        public string Substring = "";
    }
}
