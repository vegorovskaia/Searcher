namespace WordClassLibrary
{
    partial class uiDocxCriteria
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.lProp = new System.Windows.Forms.Label();
            this.lSubstring = new System.Windows.Forms.Label();
            this.tbSubstring = new System.Windows.Forms.TextBox();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.lProp);
            this.gb.Controls.Add(this.lSubstring);
            this.gb.Controls.Add(this.tbSubstring);
            this.gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb.Location = new System.Drawing.Point(0, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(545, 90);
            this.gb.TabIndex = 3;
            this.gb.TabStop = false;
            this.gb.Text = "Criterias for *.docx-files :";
            // 
            // lProp
            // 
            this.lProp.AutoSize = true;
            this.lProp.Location = new System.Drawing.Point(6, 66);
            this.lProp.Name = "lProp";
            this.lProp.Size = new System.Drawing.Size(371, 13);
            this.lProp.TabIndex = 2;
            this.lProp.Text = "Properties to search:  Creator, Category, Description, Keywords, Subject, Title";
            // 
            // lSubstring
            // 
            this.lSubstring.AutoSize = true;
            this.lSubstring.Location = new System.Drawing.Point(6, 33);
            this.lSubstring.Name = "lSubstring";
            this.lSubstring.Size = new System.Drawing.Size(211, 13);
            this.lSubstring.TabIndex = 0;
            this.lSubstring.Text = "Substring to search in document properties:";
            // 
            // tbSubstring
            // 
            this.tbSubstring.Location = new System.Drawing.Point(245, 30);
            this.tbSubstring.Name = "tbSubstring";
            this.tbSubstring.Size = new System.Drawing.Size(294, 20);
            this.tbSubstring.TabIndex = 1;
            this.tbSubstring.TextChanged += new System.EventHandler(this.tbSubstring_TextChanged);
            // 
            // uiDocxCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb);
            this.Name = "uiDocxCriteria";
            this.Size = new System.Drawing.Size(545, 90);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label lSubstring;
        private System.Windows.Forms.TextBox tbSubstring;
        private System.Windows.Forms.Label lProp;
    }
}
