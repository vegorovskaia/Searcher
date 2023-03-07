using System.Linq;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.IO;
using InterfaceClassLibrary;

namespace SearchEngineClassLibrary
{

    [Export(typeof(ISearch))]
    public class SearchEngine : BackgroundWorker, ISearch
    {
        public event RunWorkerCompletedEventHandler Completed;
        public event ProgressChangedEventHandler Founded;

        public SearchEngine()
        {
            WorkerReportsProgress = true; // report interim results
            WorkerSupportsCancellation = true; // can cancel

            DoWork += new DoWorkEventHandler(Search_DoWork);
            RunWorkerCompleted += new RunWorkerCompletedEventHandler(SearchCompleted);
            ProgressChanged += new ProgressChangedEventHandler(FileFound);

        }

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
            Completed(this, e);
        }

        private void FileFound(object sender, ProgressChangedEventArgs e)
        {
            Founded(this, e);
        }

        public void Search()
        {
            RunWorkerAsync();
        }

        private void Search_DoWork(object sender, DoWorkEventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(searchParams.Path);
            FileInfo[] fileInfo = dirInfo.GetFiles(searchMask.Mask, searchParams.searchOption);
            foreach (FileInfo fi in fileInfo.Where(f => searchCriteria.MatchCommon(f)))
            {
                if (CancellationPending)     //search was cancelled
                {
                    e.Cancel = true;
                    return;
                }
                if (searchCriteria.MatchCustom(fi)) //if file fits common criteria, then check specific criteria
                {
                    ReportProgress(0, fi);       //to report. May be use "_" insteed of "0" 
                }
            }
        }

        public void Cancel()
        {
            CancelAsync();
        }

    }

}

