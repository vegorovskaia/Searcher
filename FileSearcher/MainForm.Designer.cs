namespace FileSearcher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bSearch = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.panelSearchParams = new System.Windows.Forms.Panel();
            this.panelCommonCriteria = new System.Windows.Forms.Panel();
            this.panelExtentionType = new System.Windows.Forms.Panel();
            this.gbExtention = new System.Windows.Forms.GroupBox();
            this.lChoose = new System.Windows.Forms.Label();
            this.cbExtention = new System.Windows.Forms.ComboBox();
            this.panelCustomCriteria = new System.Windows.Forms.Panel();
            this.lResult = new System.Windows.Forms.Label();
            this.lResList = new System.Windows.Forms.Label();
            this.lvRes = new System.Windows.Forms.ListView();
            this.panelExtentionType.SuspendLayout();
            this.gbExtention.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(411, 297);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(107, 28);
            this.bSearch.TabIndex = 3;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(622, 297);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(104, 28);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // panelSearchParams
            // 
            this.panelSearchParams.Location = new System.Drawing.Point(563, 12);
            this.panelSearchParams.Name = "panelSearchParams";
            this.panelSearchParams.Size = new System.Drawing.Size(545, 73);
            this.panelSearchParams.TabIndex = 9;
            // 
            // panelCommonCriteria
            // 
            this.panelCommonCriteria.Location = new System.Drawing.Point(12, 12);
            this.panelCommonCriteria.Name = "panelCommonCriteria";
            this.panelCommonCriteria.Size = new System.Drawing.Size(545, 260);
            this.panelCommonCriteria.TabIndex = 10;
            // 
            // panelExtentionType
            // 
            this.panelExtentionType.Controls.Add(this.gbExtention);
            this.panelExtentionType.Location = new System.Drawing.Point(563, 91);
            this.panelExtentionType.Name = "panelExtentionType";
            this.panelExtentionType.Size = new System.Drawing.Size(545, 47);
            this.panelExtentionType.TabIndex = 11;
            // 
            // gbExtention
            // 
            this.gbExtention.Controls.Add(this.lChoose);
            this.gbExtention.Controls.Add(this.cbExtention);
            this.gbExtention.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbExtention.Location = new System.Drawing.Point(0, 0);
            this.gbExtention.Name = "gbExtention";
            this.gbExtention.Size = new System.Drawing.Size(545, 47);
            this.gbExtention.TabIndex = 0;
            this.gbExtention.TabStop = false;
            this.gbExtention.Text = "What\'s the files to search:";
            // 
            // lChoose
            // 
            this.lChoose.AutoSize = true;
            this.lChoose.Location = new System.Drawing.Point(170, 16);
            this.lChoose.Name = "lChoose";
            this.lChoose.Size = new System.Drawing.Size(92, 13);
            this.lChoose.TabIndex = 1;
            this.lChoose.Text = "Choose file\'s type:";
            // 
            // cbExtention
            // 
            this.cbExtention.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExtention.FormattingEnabled = true;
            this.cbExtention.Location = new System.Drawing.Point(321, 13);
            this.cbExtention.Name = "cbExtention";
            this.cbExtention.Size = new System.Drawing.Size(121, 21);
            this.cbExtention.TabIndex = 0;
            this.cbExtention.SelectedIndexChanged += new System.EventHandler(this.cbExtention_SelectedIndexChanged);
            // 
            // panelCustomCriteria
            // 
            this.panelCustomCriteria.Location = new System.Drawing.Point(563, 170);
            this.panelCustomCriteria.Name = "panelCustomCriteria";
            this.panelCustomCriteria.Size = new System.Drawing.Size(545, 102);
            this.panelCustomCriteria.TabIndex = 12;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(127, 330);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(0, 13);
            this.lResult.TabIndex = 16;
            // 
            // lResList
            // 
            this.lResList.AutoSize = true;
            this.lResList.Location = new System.Drawing.Point(12, 330);
            this.lResList.Name = "lResList";
            this.lResList.Size = new System.Drawing.Size(45, 13);
            this.lResList.TabIndex = 15;
            this.lResList.Text = "Results:";
            // 
            // lvRes
            // 
            this.lvRes.HideSelection = false;
            this.lvRes.Location = new System.Drawing.Point(12, 356);
            this.lvRes.Name = "lvRes";
            this.lvRes.Size = new System.Drawing.Size(1096, 341);
            this.lvRes.TabIndex = 14;
            this.lvRes.UseCompatibleStateImageBehavior = false;
            this.lvRes.View = System.Windows.Forms.View.List;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 709);
            this.Controls.Add(this.panelExtentionType);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.lResList);
            this.Controls.Add(this.lvRes);
            this.Controls.Add(this.panelCustomCriteria);
            this.Controls.Add(this.panelCommonCriteria);
            this.Controls.Add(this.panelSearchParams);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1141, 748);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileSearch";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelExtentionType.ResumeLayout(false);
            this.gbExtention.ResumeLayout(false);
            this.gbExtention.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Panel panelSearchParams;
        private System.Windows.Forms.Panel panelCommonCriteria;
        private System.Windows.Forms.Panel panelExtentionType;
        private System.Windows.Forms.Label lChoose;
        private System.Windows.Forms.ComboBox cbExtention;
        private System.Windows.Forms.Panel panelCustomCriteria;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label lResList;
        private System.Windows.Forms.ListView lvRes;
        private System.Windows.Forms.GroupBox gbExtention;
    }
}

