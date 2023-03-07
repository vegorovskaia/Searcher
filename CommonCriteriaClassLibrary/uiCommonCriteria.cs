using System;
using System.Windows.Forms;

namespace CommonCriteriaClassLibrary
{
    public partial class uiCommonCriteria : UserControl
    {
        CommonCriteriaValues CriteriaValues;
        public uiCommonCriteria(CommonCriteriaValues CriteriaValues)
        {
            InitializeComponent();
            this.CriteriaValues = CriteriaValues ;
           
        }
       
        //a lot of code, may be better to have only one big event handler
        
        #region saveChoiseOfUser
        private void SetBoolProp(ref bool? property , CheckBox chb, RadioButton rbYes)
        {
            if (!chb.Checked)   //don't search by this attribute  
                    property = null;
                else
                    property = rbYes.Checked;
        }
        private void SetLongProp(ref long? property, CheckBox chb, TextBox tb)
        {
            long? ln;
            if (!chb.Checked)   //don't search by this attribute 
                property = null;
            else
                try
                {
                    ln = Convert.ToInt64(tb.Text);
                    property = ln;  //correct input
                }
                catch // incorrect input 
                {
                    //to do: to manage incorrect value
                }

        }
        private void chbReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            EnablingRB(chbReadOnly, rbCheckedRO, rbNotCheckedRO);
            SetBoolProp(ref CriteriaValues.ReadOnly, chbReadOnly, rbCheckedRO);
        }
        private void chbHidden_CheckedChanged(object sender, EventArgs e)
        {
            EnablingRB(chbHidden, rbCheckedH, rbNotCheckedH);
            SetBoolProp(ref CriteriaValues.Hidden, chbHidden, rbCheckedH);
        }
        private void rbReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            SetBoolProp(ref CriteriaValues.ReadOnly, chbReadOnly, rbCheckedRO);
        }
        private void rbHidden_CheckedChanged(object sender, EventArgs e)
        {
            SetBoolProp(ref CriteriaValues.Hidden, chbHidden, rbCheckedH);
        }
        
        private void chbSizeMin_CheckedChanged(object sender, EventArgs e)
        {
            EnablingTB(chbSizeMin, tbSizeMin);
            SetLongProp(ref CriteriaValues.MinSize, chbSizeMin, tbSizeMin);
        }
        private void chbSizeMax_CheckedChanged(object sender, EventArgs e)
        {
            EnablingTB(chbSizeMax, tbSizeMax);
            SetLongProp(ref CriteriaValues.MaxSize, chbSizeMax, tbSizeMax);
        }
        private void tbSizeMin_TextChanged(object sender, EventArgs e)
        {
            SetLongProp(ref CriteriaValues.MinSize, chbSizeMin, tbSizeMin);
            SizeValidate();
        }
        private void tbSizeMax_TextChanged(object sender, EventArgs e)
        {
            SetLongProp(ref CriteriaValues.MaxSize, chbSizeMax, tbSizeMax);
            SizeValidate();
            
        }
        private void SizeValidate()
        {
            if (CriteriaValues.MaxSize < CriteriaValues.MinSize)  
                lSizeHint.Text = "Min mustn't be more then max";
            else
                lSizeHint.Text = "";
        }
        private void dtpLow_ValueChanged(object sender, EventArgs e)
        {
            CriteriaValues.LowCreationDateTime = dtpLow.Checked ? (DateTime?)dtpLow.Value.Date : null;
            DateValidate();
        }

        private void dtpHigh_ValueChanged(object sender, EventArgs e)
        {
            CriteriaValues.HighCreationDateTime = dtpHigh.Checked ? (DateTime?)dtpHigh.Value.Date.AddDays(1) : null;  
            DateValidate();
        }

        private void DateValidate()
        {
            if (CriteriaValues.LowCreationDateTime > CriteriaValues.HighCreationDateTime)  
                lDateHint.Text = "Min mustn't be more then max";
            else
                lDateHint.Text = "";
        }

        #endregion

        private void EnablingRB(CheckBox chb, RadioButton rb1, RadioButton rb2)   //enable or disable radiobuttons
        {
            if (chb.Checked)
            {
                rb1.Enabled = true;
                rb2.Enabled = true;
            }
            else
            {
                rb1.Enabled = false;
                rb2.Enabled = false;
            }
        }
        private void EnablingTB(CheckBox chb, TextBox tb)  //enable or disable textbox
        {
            if (chb.Checked)
                tb.Enabled = true;
            else
            {
                tb.Enabled = false;
                tb.Text = "";
            }

        }
        private void uiCommonCriteria_Load(object sender, EventArgs e)
        {
            EnablingRB(chbReadOnly, rbCheckedRO, rbNotCheckedRO);
            EnablingRB(chbHidden, rbCheckedH, rbNotCheckedH);
            dtpLow.Value = DateTime.Now.AddDays(-1);
            dtpLow.Checked = false;
            dtpHigh.Checked = false;
            dtpLow_ValueChanged( this, new EventArgs());
            dtpHigh_ValueChanged( this, new EventArgs());
        }
        private void tbSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLengthOfSize = 20; //enought lenght for size
            if ( (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)))  
                e.Handled = true;
            if ( ((TextBox)sender).Text.Length > maxLengthOfSize && e.KeyChar != Convert.ToChar(8))  //when maxLengthOfSize is reached, only Backspace is permitted 
                e.Handled = true;
        }

        
          
    }
    

}


