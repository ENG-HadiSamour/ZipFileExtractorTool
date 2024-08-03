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
            this.btnClearS = new System.Windows.Forms.Button();
            this.btnClearD = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSourceZipFile
            // 
            this.btnSourceZipFile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSourceZipFile.FlatAppearance.BorderSize = 0;
            this.btnSourceZipFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSourceZipFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSourceZipFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSourceZipFile.Location = new System.Drawing.Point(12, 98);
            this.btnSourceZipFile.Name = "btnSourceZipFile";
            this.btnSourceZipFile.Size = new System.Drawing.Size(199, 23);
            this.btnSourceZipFile.TabIndex = 0;
            this.btnSourceZipFile.Text = "Select Zip File";
            this.btnSourceZipFile.UseVisualStyleBackColor = false;
            this.btnSourceZipFile.Click += new System.EventHandler(this.btnSourceZipFile_Click);
            // 
            // btnDestinationPath
            // 
            this.btnDestinationPath.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDestinationPath.FlatAppearance.BorderSize = 0;
            this.btnDestinationPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDestinationPath.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDestinationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestinationPath.Location = new System.Drawing.Point(12, 168);
            this.btnDestinationPath.Name = "btnDestinationPath";
            this.btnDestinationPath.Size = new System.Drawing.Size(199, 23);
            this.btnDestinationPath.TabIndex = 1;
            this.btnDestinationPath.Text = "Select Destination Path";
            this.btnDestinationPath.UseVisualStyleBackColor = false;
            this.btnDestinationPath.Click += new System.EventHandler(this.btnDestinationPath_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.FlatAppearance.BorderSize = 0;
            this.btnExtract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExtract.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtract.Location = new System.Drawing.Point(198, 290);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(237, 53);
            this.btnExtract.TabIndex = 2;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // txtZipFilePath
            // 
            this.txtZipFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZipFilePath.Location = new System.Drawing.Point(280, 98);
            this.txtZipFilePath.Name = "txtZipFilePath";
            this.txtZipFilePath.ReadOnly = true;
            this.txtZipFilePath.Size = new System.Drawing.Size(591, 20);
            this.txtZipFilePath.TabIndex = 3;
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationPath.Location = new System.Drawing.Point(280, 168);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.ReadOnly = true;
            this.txtDestinationPath.Size = new System.Drawing.Size(591, 20);
            this.txtDestinationPath.TabIndex = 4;
            // 
            // btnClearS
            // 
            this.btnClearS.FlatAppearance.BorderSize = 0;
            this.btnClearS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClearS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClearS.Location = new System.Drawing.Point(218, 98);
            this.btnClearS.Name = "btnClearS";
            this.btnClearS.Size = new System.Drawing.Size(56, 23);
            this.btnClearS.TabIndex = 5;
            this.btnClearS.Text = "Clear";
            this.btnClearS.UseVisualStyleBackColor = true;
            this.btnClearS.Click += new System.EventHandler(this.btnClearS_Click);
            // 
            // btnClearD
            // 
            this.btnClearD.FlatAppearance.BorderSize = 0;
            this.btnClearD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClearD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClearD.Location = new System.Drawing.Point(218, 168);
            this.btnClearD.Name = "btnClearD";
            this.btnClearD.Size = new System.Drawing.Size(56, 23);
            this.btnClearD.TabIndex = 6;
            this.btnClearD.Text = "Clear";
            this.btnClearD.UseVisualStyleBackColor = true;
            this.btnClearD.Click += new System.EventHandler(this.btnClearD_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(396, 38);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Zip File Extractor Tool";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar.Location = new System.Drawing.Point(12, 261);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(859, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(450, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 233);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 16);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Ready";
            // 
            // ZipFileExtractorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(889, 355);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClearD);
            this.Controls.Add(this.btnClearS);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.txtZipFilePath);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnDestinationPath);
            this.Controls.Add(this.btnSourceZipFile);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(905, 394);
            this.MinimumSize = new System.Drawing.Size(905, 394);
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
        private System.Windows.Forms.Button btnClearS;
        private System.Windows.Forms.Button btnClearD;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStatus;
    }
}

