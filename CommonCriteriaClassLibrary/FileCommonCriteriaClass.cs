using System.Windows.Forms;
using System.IO;
using System.ComponentModel.Composition;
using InterfaceClassLibrary;

namespace CommonCriteriaClassLibrary
{
    public  class SearchCommonCriteria :  IMatch
    {
        //use the only CommonCriteriaValues instance to store common search criteria
        static private CommonCriteriaValues CriteriaValues = new CommonCriteriaValues();
        
        uiCommonCriteria gui;

        public SearchCommonCriteria()
        {
            //create UserControl and allow it to fill search criteria
            gui = new uiCommonCriteria(CriteriaValues);
        }
     
        virtual public UserControl UI
        {
            get { return gui; }
        }
        public bool MatchCommon(FileInfo fInfo)
        {
            if (CriteriaValues.ReadOnly.HasValue)         // if we need to search by ReadOnly если надо искать по ReadOnly
                if (fInfo.IsReadOnly != CriteriaValues.ReadOnly)
                    return false;

            if (CriteriaValues.Hidden.HasValue)
                if ((fInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden) //file has "hidden" attribute 
                {
                    if (CriteriaValues.Hidden == false)  //find files with hidden = false 
                        return false;
                }
                else
                {
                    if (CriteriaValues.Hidden == true)  //find files with hidden = true 
                        return false;
                }
            
            if (CriteriaValues.MinSize.HasValue)
                if (fInfo.Length < CriteriaValues.MinSize * 1024)   //Length -> bites, gui.CriteriaValues.MinSize -> kilobites 
                    return false;
            if (CriteriaValues.MaxSize.HasValue)
                if (fInfo.Length > CriteriaValues.MaxSize * 1024)   
                    return false;
            if (CriteriaValues.LowCreationDateTime.HasValue)
                if (fInfo.CreationTime < CriteriaValues.LowCreationDateTime)
                    return false;
            if (CriteriaValues.HighCreationDateTime.HasValue)
                if (fInfo.CreationTime >= CriteriaValues.HighCreationDateTime)
                    return false;

            return true;    //the file matches all the checks
        }

        public virtual bool MatchCustom(FileInfo fInfo)
        {
           // Thread.Sleep(30000);
            return true;
        }
    }
    
    [Export(typeof(IMatch))]
    [ExportMetadata("Mask", "*.*")]
    public class FileSearchCommonCriteria : SearchCommonCriteria
    {
        //this class was created to be exported. If I export base class SearchCommonCriteria, it will be in composition several times
    }

    

    
}
