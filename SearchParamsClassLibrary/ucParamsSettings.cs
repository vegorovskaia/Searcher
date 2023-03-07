using System;
using System.Windows.Forms;
using System.IO;

namespace ParamFileSearcher
{
    public partial class ucParamsSettings : UserControl
    {
        public SearchParamsValues ParamsValues;
        public ucParamsSettings(SearchParamsValues ParamsValues)
        {
            InitializeComponent();
            this.ParamsValues = ParamsValues;
        }

        //как только пользователь что-то меняет в GUI сразу сохраняем в ParamsValues

        private void chbSubDir_CheckedChanged(object sender, EventArgs e)
        {
            ParamsValues.subDir = chbSubDir.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {
            ParamsValues.Path = tbPath.Text;
        }

        private void bChooseDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialogChoose.ShowDialog();
            if (result == DialogResult.OK)
                tbPath.Text = folderBrowserDialogChoose.SelectedPath;
        }
    }


    public class SearchParamsValues     // хранит параметры поиска, введенные пользователем в GUI
    {
        public SearchOption subDir = SearchOption.TopDirectoryOnly;
        public string Path = "";
    }
}
