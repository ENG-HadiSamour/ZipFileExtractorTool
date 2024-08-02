namespace ZipFileExtractorGUI
{
    partial class ZipFileExtractorWindow
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
            this.btnSourceZipFile = new System.Windows.Forms.Button();
            this.btnDestinationPath = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.txtZipFilePath = new System.Windows.Forms.TextBox();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSourceZipFile
            // 
            this.btnSourceZipFile.Location = new System.Drawing.Point(12, 98);
            this.btnSourceZipFile.Name = "btnSourceZipFile";
            this.btnSourceZipFile.Size = new System.Drawing.Size(199, 23);
            this.btnSourceZipFile.TabIndex = 0;
            this.btnSourceZipFile.Text = "Select Zip File";
            this.btnSourceZipFile.UseVisualStyleBackColor = true;
            this.btnSourceZipFile.Click += new System.EventHandler(this.btnSourceZipFile_Click);
            // 
            // btnDestinationPath
            // 
            this.btnDestinationPath.Location = new System.Drawing.Point(12, 168);
            this.btnDestinationPath.Name = "btnDestinationPath";
            this.btnDestinationPath.Size = new System.Drawing.Size(199, 23);
            this.btnDestinationPath.TabIndex = 1;
            this.btnDestinationPath.Text = "Select Destination Path";
            this.btnDestinationPath.UseVisualStyleBackColor = true;
            this.btnDestinationPath.Click += new System.EventHandler(this.btnDestinationPath_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(305, 268);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(237, 53);
            this.btnExtract.TabIndex = 2;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // txtZipFilePath
            // 
            this.txtZipFilePath.Location = new System.Drawing.Point(217, 98);
            this.txtZipFilePath.Name = "txtZipFilePath";
            this.txtZipFilePath.ReadOnly = true;
            this.txtZipFilePath.Size = new System.Drawing.Size(601, 20);
            this.txtZipFilePath.TabIndex = 3;
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(217, 168);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.ReadOnly = true;
            this.txtDestinationPath.Size = new System.Drawing.Size(601, 20);
            this.txtDestinationPath.TabIndex = 4;
            // 
            // ZipFileExtractorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(836, 333);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.txtZipFilePath);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnDestinationPath);
            this.Controls.Add(this.btnSourceZipFile);
            this.Name = "ZipFileExtractorWindow";
            this.Text = "Zip File Extractor tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSourceZipFile;
        private System.Windows.Forms.Button btnDestinationPath;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.TextBox txtZipFilePath;
        private System.Windows.Forms.TextBox txtDestinationPath;
    }
}

