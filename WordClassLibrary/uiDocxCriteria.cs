using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordClassLibrary
{
    public partial class uiDocxCriteria : UserControl
    {
        public DocxCriteriaValues docxCriteriaValues;
        public uiDocxCriteria(DocxCriteriaValues docxCriteriaValues)
        {
            InitializeComponent();
            this.docxCriteriaValues = docxCriteriaValues;
        }

        //как только пользователь что-то меняет в GUI сразу сохраняем в docxCriteriaValues
        private void tbSubstring_TextChanged(object sender, EventArgs e)
        {
            docxCriteriaValues.Substring = tbSubstring.Text;
        }
    }
    
}
