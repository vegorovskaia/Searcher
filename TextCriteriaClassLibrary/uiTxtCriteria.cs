using System;
using System.Windows.Forms;

namespace TextCriteriaClassLibrary
{
    public partial class uiTxtCriteria : UserControl
    {
        private TxtCriteriaValues txtCriteriaValues;
        public uiTxtCriteria(TxtCriteriaValues txtCriteriaValues)
        {
            InitializeComponent();
            this.txtCriteriaValues = txtCriteriaValues;
        }

        private void tbSubstring_TextChanged(object sender, EventArgs e)
        {
            txtCriteriaValues.Substring = tbSubstring.Text;
        }
        
        
    }

   
}
