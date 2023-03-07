using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using InterfaceClassLibrary;
using System.Diagnostics;

namespace FileSearcher
{
    // search engine wrapper to use FileSystemWatcher, do composition, fill mask list
    class Runner 
    {
        public eRunnerState state = eRunnerState.Free;
        static public string pluginPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "Plugins");

        private bool bCompositionRequest = false;
        private DirectoryCatalog catalog;
        FileSystemWatcher watcher;

        [Import(typeof(ISearch))]
        private ISearch searcher;

        [Import(typeof(ISearchParams))]
        private ISearchParams searcherParams;

        public UserControl searcherParamsUI
        {
            get { return searcherParams.UI; }
        }
        
        [ImportMany (AllowRecomposition=true)]
        private IEnumerable<Lazy<IMatch, IMask>> criterias;

        public UserControl commonCriteriaUI
        {
            get { return criterias.First<Lazy<IMatch, IMask>>(cr => cr.Metadata.Mask.Equals("*.*")).Value.UI; }
        }
        public UserControl customCriteriaUI(string sMask)
        {
            return criterias.First<Lazy<IMatch, IMask>>(cr => cr.Metadata.Mask.Equals(sMask)).Value.UI;
        }

        private List<string> lMasks = new List<string>();
        public List<string> listMasks       //list of avaiable file types (i.e. masks like *.* , *.txt etc)
        {
            get 
            { 
                  lMasks.Clear();  
                  lMasks = criterias.Select(cr => cr.Metadata.Mask).ToList(); 
                  return lMasks;
            }
        }
        
        public event ComposedEventHandler Composed;     //composition was completed

        public event RunWorkerCompletedEventHandler Completed;      //search was completed
        public event ProgressChangedEventHandler Found;       // file was founded

        public void Search(string sSelectedMask)    //start search with the mask
        {
            searcher.parameters = searcherParams;
            var mask =          criterias.First<Lazy<IMatch, IMask>>(cr => cr.Metadata.Mask.Equals(sSelectedMask)).Metadata;
            searcher.mask = mask;
            searcher.criteria = criterias.First<Lazy<IMatch, IMask>>(cr => cr.Metadata.Mask.Equals(sSelectedMask)).Value;
            state = eRunnerState.Searching;
            searcher.Search();
            Debug.WriteLine("Search");
        }
        public void Cancel()
        {
            Debug.WriteLine("searcher.Cancel");
            searcher.Cancel();
        }

        private void SearchCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Debug.WriteLine("SearchCompleted");
            state = eRunnerState.Free;
            
            if (bCompositionRequest)    //if during the search changes happend in the catalog 
                Composition();
            Completed(this, e);
        }

        private void FileFound(object sender, ProgressChangedEventArgs e)
        {
            Debug.WriteLine("FileFound");
            Found(this, e);
        }
        public Runner(Form HostForm)
        {
            catalog = new DirectoryCatalog(pluginPath);

            watcher = new FileSystemWatcher();
            watcher.SynchronizingObject = HostForm; //events handler 
            watcher.Path = pluginPath;
            //watcher.NotifyFilter = NotifyFilters .LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.dll";
            watcher.Created += new FileSystemEventHandler(OnFileWatcherFire);
            watcher.Deleted += new FileSystemEventHandler(OnFileWatcherFire);
            watcher.EnableRaisingEvents = true; //start file watching 

            catalog.Changed += new EventHandler<ComposablePartCatalogChangeEventArgs>(catalog_Changed);
        }


        void catalog_Changed(object sender, ComposablePartCatalogChangeEventArgs e)
        {
            if (state == eRunnerState.Free)
                Composition();
            bCompositionRequest = true;     //if we are searching now, set flag "we need recomposition" and wait for search completed
                                            
            
        }

        private void OnFileWatcherFire(object source, FileSystemEventArgs e)
        {
            catalog.Refresh();  //file was added or deleted 
        }

        public void Composition()
        {
            try
            {
                bCompositionRequest = false;
                state = eRunnerState.Free;
                CompositionContainer container = new CompositionContainer(catalog);
                container.ComposeParts(this);
                
                //throw new Exception();

                if (Composed != null)
                    Composed(this, new CompositionEventArgs(true, ""));
                searcher.Completed += new RunWorkerCompletedEventHandler(SearchCompleted);
                searcher.Founded += new ProgressChangedEventHandler(FileFound);
            }
            catch (Exception ex)
            {
                state = eRunnerState.Invalid;
                Composed(this, new CompositionEventArgs(true , ex.Message));
                
            }

        }

    }
    public delegate void ComposedEventHandler(object sender, CompositionEventArgs arg);
    public class CompositionEventArgs : EventArgs
    {
        public bool bSuccess;
        public string Message;
        public CompositionEventArgs(bool bSuccess, string Message)
        {
            this.bSuccess = bSuccess;
        }
    }
    enum eRunnerState { Searching, Free, Invalid};   //searching now, not searching now, search is impossible
}
