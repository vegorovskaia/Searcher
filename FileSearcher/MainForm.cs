using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;



namespace FileSearcher
{
    public partial class MainForm : Form
    {
        private Runner runner;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            runner = new Runner(this);
            runner.Composed += new ComposedEventHandler(runner_Composed);
            runner.Composition();
            runner.Completed += new RunWorkerCompletedEventHandler(SearchCompleted);
            runner.Found += new ProgressChangedEventHandler(FileFound);
            this.DoubleBuffered = true; //prevent flicker
            
        }

        private void runner_Composed(object sender, CompositionEventArgs e)
        {
            try
            {
                cbExtention.Items.Clear();
                panelSearchParams.Controls.Clear();
                panelCommonCriteria.Controls.Clear();
                panelCustomCriteria.Controls.Clear();
                if (!e.bSuccess)
                {
                    lResult.Text = "Composition error. " + e.Message;
                    lResult.ForeColor = Color.Red;
                    SearcherStateHandling();
                    return;
                }
                panelSearchParams.Controls.Add(runner.searcherParamsUI);
                panelCommonCriteria.Controls.Add(runner.commonCriteriaUI);
                runner.listMasks.ForEach(mask => cbExtention.Items.Add(mask));
                cbExtention.SelectedItem = "*.*";
                SearcherStateHandling();
            }
            catch
            {
                lResult.Text = "Composition error. Search is impossible.";
                lResult.ForeColor = Color.Red;
                panelExtentionType.Enabled = false;
                SearcherStateHandling(eRunnerState.Invalid);
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if (runner == null)
                return;
            lvRes.Items.Clear();
            lResult.Text = "";
            runner.Search(cbExtention.SelectedItem.ToString());
            SearcherStateHandling();
        }

        private void cbExtention_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                panelCustomCriteria.Controls.Clear();
                string sSelectedMask = cbExtention.SelectedItem.ToString();
                if (sSelectedMask != "*.*")
                    panelCustomCriteria.Controls.Add(runner.customCriteriaUI(sSelectedMask));
            }
            catch(Exception ex)
            {
                lResult.Text = "Plugin loading error: " + ex.Message;
                lResult.ForeColor = Color.Red;
                SearcherStateHandling(eRunnerState.Invalid);
            }
        }

        private void SearchCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //  error happend during searching
            if (e.Error != null)
            {
                lResult.Text = "Error happend during searching: " + e.Error.Message;
                lResult.ForeColor = Color.Red;
            }
            else if (e.Cancelled)
            {
                lResult.Text = "Searching was canceled";
                lResult.ForeColor = Color.Black;
            }
            else
            {
                lResult.Text = "Searching completed";
                lResult.ForeColor = Color.Black;
            }
            SearcherStateHandling();
        }

        private void FileFound(object sender, ProgressChangedEventArgs e)
        {
            lvRes.Items.Add((e.UserState as FileInfo).FullName);
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (runner != null)
                runner.Cancel();
        }

        private void SearcherStateHandling( eRunnerState? state = null)
        {
            //if something is wrong with the form and search is impossible, then put runner to Invalid state 
            if (state  == eRunnerState.Invalid)
            {
                runner.state = eRunnerState.Invalid;
            }

            switch (runner.state)
            {
                case eRunnerState.Invalid:
                    
                case eRunnerState.Searching:
                    panelSearchParams.Enabled = false;
                    panelCommonCriteria.Enabled = false;
                    panelCustomCriteria.Enabled = false;
                    panelExtentionType.Enabled = false;
                    bSearch.Enabled = false;
                    bCancel.Enabled = true;
                    break;
                case eRunnerState.Free:
                    panelSearchParams.Enabled = true;
                    panelCommonCriteria.Enabled = true;
                    panelCustomCriteria.Enabled = true;
                    panelExtentionType.Enabled = true;
                    bSearch.Enabled = true;
                    bCancel.Enabled = false;
                    break;
            }
        }
    
    }
   
    public class FormStarter    //to start form in another domain
    {
        public FormStarter()
        {
            Application.Run(new MainForm());
        }

    }
}
