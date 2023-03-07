using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Remoting.Messaging;

using System.Threading;
using System.ComponentModel;
using System.ComponentModel.Composition;

namespace FileSearcher
{

    [Export(typeof(ISearch))]
public class FileSearcher : BackgroundWorker , ISearch
    {
        public event RunWorkerCompletedEventHandler Completed;
        public event ProgressChangedEventHandler Founded;
        //SearchParams parameters;
        //public IMatch match;

        //public FileSearcher(SearchParams parameters)
        public FileSearcher()
        {
            //this.parameters = parameters;
            WorkerReportsProgress = true; // отчитываться о промежуточных результатах
            WorkerSupportsCancellation = true; //можно отменять

            DoWork += new DoWorkEventHandler(Search_DoWork);
            //searcher.Completed += new RunWorkerCompletedEventHandler(Search_RunWorkerCompleted);
            //searcher.Founded += new ProgressChangedEventHandler(Search_ProgressChanged);

            RunWorkerCompleted += new RunWorkerCompletedEventHandler(SearchCompleted);
            ProgressChanged += new ProgressChangedEventHandler(FileFound);
           
        }

        /*ISearchParams parameters;
        IMask mask;
        IMatch criteria;*/
        
        private IMatch searchCriteria;
        public IMatch criteria
        {
            set { searchCriteria = value; }
        }

        private ISearchParams searchParams;
        public ISearchParams parameters 
        {
            set { searchParams = value; }
        }

        private IMask searchMask;
        public IMask mask
        {
            set { searchMask = value; }
        } 

        private void SearchCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //lResult.Text = (e.UserState as SearchInfo).sInfo;
            //lvRes.Items.Add((e.UserState as SearchInfo).sInfo);
            Completed(this, e);
        }
        
    private void FileFound(object sender, ProgressChangedEventArgs e)
        {
            //lResult.Text = (e.UserState as SearchInfo).sInfo;
            //lvRes.Items.Add((e.UserState as SearchInfo).sInfo);
            Founded(this, e);
        }
    public void Search()
    {
        RunWorkerAsync();
    }

        private void Search_DoWork(object sender, DoWorkEventArgs e)
        {
            //try
            {
                //BackgroundWorker worker = sender as BackgroundWorker;
                DirectoryInfo dirInfo = new DirectoryInfo(searchParams.sPath);

                FileInfo[] fileInfo = dirInfo.GetFiles(searchMask.Mask, searchParams.searchOption); // SearchOption.AllDirectories);

                foreach (FileInfo fi in fileInfo.Where(f => searchCriteria.MatchCommon(f)))
                {
                    if (CancellationPending)     //поиск отменили
                    {
                        e.Cancel = true; 
                        return;
                    }
                    if (searchCriteria.MatchCustom(fi))
                    {

                        //SearchInfo searchInfo = new SearchInfo(enumSearchResult.FoundFile, fi.FullName);
                        //worker.ReportProgress(0, searchInfo);       //отчитаться
                        ReportProgress(0, /*searchInfo*/ fi);       //отчитаться
                    }
                }
            }
            /*catch(Exception ex)
            {
                e.
                return;
            }*/
        }

        public void Cancel()
        {
            CancelAsync();
        }

    }


    class SearchParams
    {
        public string sDirPath;
        public bool bIncludeSubDir;
        public SearchParams(string sDirPath, bool bIncludeSubDir)
        { 
            this.sDirPath = sDirPath;
            this.bIncludeSubDir = bIncludeSubDir;
        }
    }

    enum enumSearchResult {FoundFile, OK, Error};

    class SearchInfo
    {
        //public enumSearchResult Result;
        public string sFullName;
        
        /*public SearchInfo(enumSearchResult Result, string sInfo = null)
        {
            this.Result = Result;
            this.sInfo = sInfo;
        }*/

    }

    delegate void SearchResultDelegate(IAsyncResult ar);

    delegate void FileFoundDelegate(SearchInfo searchInfo);
    delegate bool CancelDelegate();
    //delegate SearchInfo SearchDelegate(IMatch match, FileFoundDelegate FileFoundMethod);//IMatch match, SearchResultDelegate resultMethod);

    
        

 /*   public interface IMatch
    {
        string sGetMask();
        bool MatchCommon(FileInfo fInfo);
        bool MatchCustom(FileInfo fInfo);
    }*/
 

/*    class SearchFileCriteria : IMatch
    {
        string sMask = "*.*";
        public bool bReadOnly = false;
        int iSizeMin = 0 ; //, iSizeMax;
        //void SearchFileCriteria_Common ()
        public string sGetMask()
        {
            return sMask;
        }

        public bool MatchCommon(FileInfo fInfo)
        {
            return fInfo.IsReadOnly == bReadOnly;
        }

        public virtual bool MatchCustom(FileInfo fInfo)
        {
            Thread.Sleep(10000);
            return true;
        }
    }*/


}
