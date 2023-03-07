namespace CommonCriteriaClassLibrary
{
    partial class uiCommonCriteria
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chbReadOnly = new System.Windows.Forms.CheckBox();
            this.gbReadOnly = new System.Windows.Forms.GroupBox();
            this.rbNotCheckedRO = new System.Windows.Forms.RadioButton();
            this.rbCheckedRO = new System.Windows.Forms.RadioButton();
            this.gbHidden = new System.Windows.Forms.GroupBox();
            this.rbNotCheckedH = new System.Windows.Forms.RadioButton();
            this.rbCheckedH = new System.Windows.Forms.RadioButton();
            this.chbHidden = new System.Windows.Forms.CheckBox();
            this.chbSizeMin = new System.Windows.Forms.CheckBox();
            this.tbSizeMin = new System.Windows.Forms.TextBox();
            this.tbSizeMax = new System.Windows.Forms.TextBox();
            this.chbSizeMax = new System.Windows.Forms.CheckBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.lSizeHint = new System.Windows.Forms.Label();
            this.gbAttributes = new System.Windows.Forms.GroupBox();
            this.gbCreationDate = new System.Windows.Forms.GroupBox();
            this.lDateHint = new System.Windows.Forms.Label();
            this.lHigh = new System.Windows.Forms.Label();
            this.lLow = new System.Windows.Forms.Label();
            this.dtpHigh = new System.Windows.Forms.DateTimePicker();
            this.dtpLow = new System.Windows.Forms.DateTimePicker();
            this.gb = new System.Windows.Forms.GroupBox();
            this.gbReadOnly.SuspendLayout();
            this.gbHidden.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.gbAttributes.SuspendLayout();
            this.gbCreationDate.SuspendLayout();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbReadOnly
            // 
            this.chbReadOnly.AutoSize = true;
            this.chbReadOnly.Location = new System.Drawing.Point(10, 0);
            this.chbReadOnly.Name = "chbReadOnly";
            this.chbReadOnly.Size = new System.Drawing.Size(73, 17);
            this.chbReadOnly.TabIndex = 0;
            this.chbReadOnly.Text = "ReadOnly";
            this.chbReadOnly.UseVisualStyleBackColor = true;
            this.chbReadOnly.CheckedChanged += new System.EventHandler(this.chbReadOnly_CheckedChanged);
            // 
            // gbReadOnly
            // 
            this.gbReadOnly.Controls.Add(this.rbNotCheckedRO);
            this.gbReadOnly.Controls.Add(this.rbCheckedRO);
            this.gbReadOnly.Controls.Add(this.chbReadOnly);
            this.gbReadOnly.Location = new System.Drawing.Point(15, 13);
            this.gbReadOnly.Name = "gbReadOnly";
            this.gbReadOnly.Size = new System.Drawing.Size(111, 87);
            this.gbReadOnly.TabIndex = 1;
            this.gbReadOnly.TabStop = false;
            // 
            // rbNotCheckedRO
            // 
            this.rbNotCheckedRO.AutoSize = true;
            this.rbNotCheckedRO.Location = new System.Drawing.Point(7, 48);
            this.rbNotCheckedRO.Name = "rbNotCheckedRO";
            this.rbNotCheckedRO.Size = new System.Drawing.Size(87, 17);
            this.rbNotCheckedRO.TabIndex = 2;
            this.rbNotCheckedRO.Text = "Not checked";
            this.rbNotCheckedRO.UseVisualStyleBackColor = true;
            this.rbNotCheckedRO.CheckedChanged += new System.EventHandler(this.rbReadOnly_CheckedChanged);
            // 
            // rbCheckedRO
            // 
            this.rbCheckedRO.AutoSize = true;
            this.rbCheckedRO.Checked = true;
            this.rbCheckedRO.Location = new System.Drawing.Point(7, 24);
            this.rbCheckedRO.Name = "rbCheckedRO";
            this.rbCheckedRO.Size = new System.Drawing.Size(68, 17);
            this.rbCheckedRO.TabIndex = 1;
            this.rbCheckedRO.TabStop = true;
            this.rbCheckedRO.Text = "Checked";
            this.rbCheckedRO.UseVisualStyleBackColor = true;
            this.rbCheckedRO.CheckedChanged += new System.EventHandler(this.rbReadOnly_CheckedChanged);
            // 
            // gbHidden
            // 
            this.gbHidden.Controls.Add(this.rbNotCheckedH);
            this.gbHidden.Controls.Add(this.rbCheckedH);
            this.gbHidden.Controls.Add(this.chbHidden);
            this.gbHidden.Location = new System.Drawing.Point(132, 14);
            this.gbHidden.Name = "gbHidden";
            this.gbHidden.Size = new System.Drawing.Size(118, 87);
            this.gbHidden.TabIndex = 3;
            this.gbHidden.TabStop = false;
            // 
            // rbNotCheckedH
            // 
            this.rbNotCheckedH.AutoSize = true;
            this.rbNotCheckedH.Location = new System.Drawing.Point(7, 48);
            this.rbNotCheckedH.Name = "rbNotCheckedH";
            this.rbNotCheckedH.Size = new System.Drawing.Size(87, 17);
            this.rbNotCheckedH.TabIndex = 2;
            this.rbNotCheckedH.Text = "Not checked";
            this.rbNotCheckedH.UseVisualStyleBackColor = true;
            this.rbNotCheckedH.CheckedChanged += new System.EventHandler(this.rbHidden_CheckedChanged);
            // 
            // rbCheckedH
            // 
            this.rbCheckedH.AutoSize = true;
            this.rbCheckedH.Checked = true;
            this.rbCheckedH.Location = new System.Drawing.Point(7, 24);
            this.rbCheckedH.Name = "rbCheckedH";
            this.rbCheckedH.Size = new System.Drawing.Size(68, 17);
            this.rbCheckedH.TabIndex = 1;
            this.rbCheckedH.TabStop = true;
            this.rbCheckedH.Text = "Checked";
            this.rbCheckedH.UseVisualStyleBackColor = true;
            this.rbCheckedH.CheckedChanged += new System.EventHandler(this.rbHidden_CheckedChanged);
            // 
            // chbHidden
            // 
            this.chbHidden.AutoSize = true;
            this.chbHidden.Location = new System.Drawing.Point(6, 0);
            this.chbHidden.Name = "chbHidden";
            this.chbHidden.Size = new System.Drawing.Size(60, 17);
            this.chbHidden.TabIndex = 0;
            this.chbHidden.Text = "Hidden";
            this.chbHidden.UseVisualStyleBackColor = true;
            this.chbHidden.CheckedChanged += new System.EventHandler(this.chbHidden_CheckedChanged);
            // 
            // chbSizeMin
            // 
            this.chbSizeMin.AutoSize = true;
            this.chbSizeMin.Location = new System.Drawing.Point(6, 15);
            this.chbSizeMin.Name = "chbSizeMin";
            this.chbSizeMin.Size = new System.Drawing.Size(89, 17);
            this.chbSizeMin.TabIndex = 5;
            this.chbSizeMin.Text = "Min size (Kb):";
            this.chbSizeMin.UseVisualStyleBackColor = true;
            this.chbSizeMin.CheckedChanged += new System.EventHandler(this.chbSizeMin_CheckedChanged);
            // 
            // tbSizeMin
            // 
            this.tbSizeMin.Enabled = false;
            this.tbSizeMin.Location = new System.Drawing.Point(183, 13);
            this.tbSizeMin.Name = "tbSizeMin";
            this.tbSizeMin.Size = new System.Drawing.Size(71, 20);
            this.tbSizeMin.TabIndex = 6;
            this.tbSizeMin.TextChanged += new System.EventHandler(this.tbSizeMin_TextChanged);
            this.tbSizeMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSize_KeyPress);
            // 
            // tbSizeMax
            // 
            this.tbSizeMax.Enabled = false;
            this.tbSizeMax.Location = new System.Drawing.Point(183, 49);
            this.tbSizeMax.Name = "tbSizeMax";
            this.tbSizeMax.Size = new System.Drawing.Size(71, 20);
            this.tbSizeMax.TabIndex = 8;
            this.tbSizeMax.TextChanged += new System.EventHandler(this.tbSizeMax_TextChanged);
            this.tbSizeMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSize_KeyPress);
            // 
            // chbSizeMax
            // 
            this.chbSizeMax.AutoSize = true;
            this.chbSizeMax.Location = new System.Drawing.Point(6, 49);
            this.chbSizeMax.Name = "chbSizeMax";
            this.chbSizeMax.Size = new System.Drawing.Size(92, 17);
            this.chbSizeMax.TabIndex = 7;
            this.chbSizeMax.Text = "Max size (Kb):";
            this.chbSizeMax.UseVisualStyleBackColor = true;
            this.chbSizeMax.CheckedChanged += new System.EventHandler(this.chbSizeMax_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.lSizeHint);
            this.gbSize.Controls.Add(this.chbSizeMax);
            this.gbSize.Controls.Add(this.chbSizeMin);
            this.gbSize.Controls.Add(this.tbSizeMax);
            this.gbSize.Controls.Add(this.tbSizeMin);
            this.gbSize.Location = new System.Drawing.Point(268, 20);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(267, 114);
            this.gbSize.TabIndex = 10;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size search:";
            // 
            // lSizeHint
            // 
            this.lSizeHint.AutoSize = true;
            this.lSizeHint.ForeColor = System.Drawing.Color.Red;
            this.lSizeHint.Location = new System.Drawing.Point(7, 85);
            this.lSizeHint.Name = "lSizeHint";
            this.lSizeHint.Size = new System.Drawing.Size(0, 13);
            this.lSizeHint.TabIndex = 9;
            // 
            // gbAttributes
            // 
            this.gbAttributes.Controls.Add(this.gbReadOnly);
            this.gbAttributes.Controls.Add(this.gbHidden);
            this.gbAttributes.Location = new System.Drawing.Point(6, 19);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Size = new System.Drawing.Size(256, 115);
            this.gbAttributes.TabIndex = 11;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Attribute search:";
            // 
            // gbCreationDate
            // 
            this.gbCreationDate.Controls.Add(this.lDateHint);
            this.gbCreationDate.Controls.Add(this.lHigh);
            this.gbCreationDate.Controls.Add(this.lLow);
            this.gbCreationDate.Controls.Add(this.dtpHigh);
            this.gbCreationDate.Controls.Add(this.dtpLow);
            this.gbCreationDate.Location = new System.Drawing.Point(6, 140);
            this.gbCreationDate.Name = "gbCreationDate";
            this.gbCreationDate.Size = new System.Drawing.Size(345, 108);
            this.gbCreationDate.TabIndex = 12;
            this.gbCreationDate.TabStop = false;
            this.gbCreationDate.Text = " Created date search:";
            // 
            // lDateHint
            // 
            this.lDateHint.AutoSize = true;
            this.lDateHint.ForeColor = System.Drawing.Color.Red;
            this.lDateHint.Location = new System.Drawing.Point(15, 82);
            this.lDateHint.Name = "lDateHint";
            this.lDateHint.Size = new System.Drawing.Size(0, 13);
            this.lDateHint.TabIndex = 10;
            // 
            // lHigh
            // 
            this.lHigh.AutoSize = true;
            this.lHigh.Location = new System.Drawing.Point(6, 60);
            this.lHigh.Name = "lHigh";
            this.lHigh.Size = new System.Drawing.Size(39, 13);
            this.lHigh.TabIndex = 5;
            this.lHigh.Text = "Latest:";
            // 
            // lLow
            // 
            this.lLow.AutoSize = true;
            this.lLow.Location = new System.Drawing.Point(6, 31);
            this.lLow.Name = "lLow";
            this.lLow.Size = new System.Drawing.Size(44, 13);
            this.lLow.TabIndex = 4;
            this.lLow.Text = "Earliest:";
            // 
            // dtpHigh
            // 
            this.dtpHigh.Checked = false;
            this.dtpHigh.Location = new System.Drawing.Point(127, 54);
            this.dtpHigh.Name = "dtpHigh";
            this.dtpHigh.ShowCheckBox = true;
            this.dtpHigh.Size = new System.Drawing.Size(200, 20);
            this.dtpHigh.TabIndex = 3;
            this.dtpHigh.ValueChanged += new System.EventHandler(this.dtpHigh_ValueChanged);
            // 
            // dtpLow
            // 
            this.dtpLow.Checked = false;
            this.dtpLow.Location = new System.Drawing.Point(127, 25);
            this.dtpLow.Name = "dtpLow";
            this.dtpLow.ShowCheckBox = true;
            this.dtpLow.Size = new System.Drawing.Size(200, 20);
            this.dtpLow.TabIndex = 2;
            this.dtpLow.ValueChanged += new System.EventHandler(this.dtpLow_ValueChanged);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.gbSize);
            this.gb.Controls.Add(this.gbCreationDate);
            this.gb.Controls.Add(this.gbAttributes);
            this.gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb.Location = new System.Drawing.Point(0, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(545, 260);
            this.gb.TabIndex = 13;
            this.gb.TabStop = false;
            this.gb.Text = "Common Search Criterias:";
            // 
            // uiCommonCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb);
            this.Name = "uiCommonCriteria";
            this.Size = new System.Drawing.Size(545, 260);
            this.Load += new System.EventHandler(this.uiCommonCriteria_Load);
            this.gbReadOnly.ResumeLayout(false);
            this.gbReadOnly.PerformLayout();
            this.gbHidden.ResumeLayout(false);
            this.gbHidden.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbAttributes.ResumeLayout(false);
            this.gbCreationDate.ResumeLayout(false);
            this.gbCreationDate.PerformLayout();
            this.gb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chbReadOnly;
        private System.Windows.Forms.GroupBox gbReadOnly;
        private System.Windows.Forms.RadioButton rbNotCheckedRO;
        private System.Windows.Forms.RadioButton rbCheckedRO;
        private System.Windows.Forms.GroupBox gbHidden;
        private System.Windows.Forms.RadioButton rbNotCheckedH;
        private System.Windows.Forms.RadioButton rbCheckedH;
        private System.Windows.Forms.CheckBox chbHidden;
        private System.Windows.Forms.CheckBox chbSizeMin;
        private System.Windows.Forms.TextBox tbSizeMin;
        private System.Windows.Forms.TextBox tbSizeMax;
        private System.Windows.Forms.CheckBox chbSizeMax;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbAttributes;
        private System.Windows.Forms.GroupBox gbCreationDate;
        private System.Windows.Forms.DateTimePicker dtpHigh;
        private System.Windows.Forms.DateTimePicker dtpLow;
        private System.Windows.Forms.Label lHigh;
        private System.Windows.Forms.Label lLow;
        private System.Windows.Forms.Label lSizeHint;
        private System.Windows.Forms.Label lDateHint;
        private System.Windows.Forms.GroupBox gb;
    }
}
