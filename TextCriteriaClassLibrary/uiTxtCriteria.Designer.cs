namespace TextCriteriaClassLibrary
{
    partial class uiTxtCriteria
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
            this.lSubstring = new System.Windows.Forms.Label();
            this.tbSubstring = new System.Windows.Forms.TextBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // lSubstring
            // 
            this.lSubstring.AutoSize = true;
            this.lSubstring.Location = new System.Drawing.Point(9, 22);
            this.lSubstring.Name = "lSubstring";
            this.lSubstring.Size = new System.Drawing.Size(54, 13);
            this.lSubstring.TabIndex = 0;
            this.lSubstring.Text = "Substring:";
            // 
            // tbSubstring
            // 
            this.tbSubstring.Location = new System.Drawing.Point(87, 19);
            this.tbSubstring.Name = "tbSubstring";
            this.tbSubstring.Size = new System.Drawing.Size(442, 20);
            this.tbSubstring.TabIndex = 1;
            this.tbSubstring.TextChanged += new System.EventHandler(this.tbSubstring_TextChanged);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.lSubstring);
            this.gb.Controls.Add(this.tbSubstring);
            this.gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb.Location = new System.Drawing.Point(0, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(545, 57);
            this.gb.TabIndex = 2;
            this.gb.TabStop = false;
            this.gb.Text = "Criterias for *.txt-files :";
            // 
            // uiTxtCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gb);
            this.Name = "uiTxtCriteria";
            this.Size = new System.Drawing.Size(545, 57);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lSubstring;
        private System.Windows.Forms.TextBox tbSubstring;
        private System.Windows.Forms.GroupBox gb;
    }
}
