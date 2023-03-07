using System.ComponentModel;
using System.ComponentModel.Composition;
using System.IO;
using InterfaceClassLibrary;

namespace MoqSearchEngine
{
    [Export(typeof(ISearch))]
    public class SearchEngine : BackgroundWorker, ISearch
    {
        public event RunWorkerCompletedEventHandler Completed;
        public event ProgressChangedEventHandler Founded;

        public SearchEngine()
        {
            WorkerReportsProgress = true; // report about intermediate result  
            WorkerSupportsCancellation = true; //can cancel 

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
            ReportProgress(0, new FileInfo("1"));       //to report. may be use "_" instead of "0" 
        }

        public void Cancel()
        {
            CancelAsync();
        }

    }
}
