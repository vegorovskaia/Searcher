namespace ParamFileSearcher
{
    partial class ucParamsSettings
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lPath = new System.Windows.Forms.Label();
            this.chbSubDir = new System.Windows.Forms.CheckBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.bChooseDir = new System.Windows.Forms.Button();
            this.folderBrowserDialogChoose = new System.Windows.Forms.FolderBrowserDialog();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(44, 18);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(420, 20);
            this.tbPath.TabIndex = 0;
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            // 
            // lPath
            // 
            this.lPath.AutoSize = true;
            this.lPath.Location = new System.Drawing.Point(6, 26);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(32, 13);
            this.lPath.TabIndex = 1;
            this.lPath.Text = "Path:";
            // 
            // chbSubDir
            // 
            this.chbSubDir.AutoSize = true;
            this.chbSubDir.Location = new System.Drawing.Point(9, 45);
            this.chbSubDir.Name = "chbSubDir";
            this.chbSubDir.Size = new System.Drawing.Size(112, 17);
            this.chbSubDir.TabIndex = 2;
            this.chbSubDir.Text = "Include subfolders";
            this.chbSubDir.UseVisualStyleBackColor = true;
            this.chbSubDir.CheckedChanged += new System.EventHandler(this.chbSubDir_CheckedChanged);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.bChooseDir);
            this.gb.Controls.Add(this.lPath);
            this.gb.Controls.Add(this.chbSubDir);
            this.gb.Controls.Add(this.tbPath);
            this.gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb.Location = new System.Drawing.Point(0, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(545, 72);
            this.gb.TabIndex = 3;
            this.gb.TabStop = false;
            this.gb.Text = "Where to search:";
            // 
            // bChooseDir
            // 
            this.bChooseDir.Location = new System.Drawing.Point(470, 16);
            this.bChooseDir.Name = "bChooseDir";
            this.bChooseDir.Size = new System.Drawing.Size(56, 23);
            this.bChooseDir.TabIndex = 3;
            this.bChooseDir.Text = "Choose";
            this.bChooseDir.UseVisualStyleBackColor = true;
            this.bChooseDir.Click += new System.EventHandler(this.bChooseDir_Click);
            // 
            // ucParamsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb);
            this.Name = "ucParamsSettings";
            this.Size = new System.Drawing.Size(545, 72);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label lPath;
        private System.Windows.Forms.CheckBox chbSubDir;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Button bChooseDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogChoose;
    }
}
