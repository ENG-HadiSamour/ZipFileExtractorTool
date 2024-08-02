using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZipFileExtractorGUI
{
    public partial class ZipFileExtractorWindow : Form
    {
        public ZipFileExtractorWindow()
        {
            InitializeComponent();
        }

        private void btnSourceZipFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Zip files (*.zip)|*.zip|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtZipFilePath.Text = string.Join(";", openFileDialog.FileNames);
                }
            }
        }

        private void btnDestinationPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDestinationPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtZipFilePath.Text) || string.IsNullOrWhiteSpace(txtDestinationPath.Text))
            {
                MessageBox.Show("Please select both source zip files and destination path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var zipFilePaths = txtZipFilePath.Text.Split(';');
            var destinationPath = txtDestinationPath.Text;

            var zipFileExtractor = new zipFileExtractor();

            foreach (var zipFilePath in zipFilePaths)
            {
                try
                {
                    zipFileExtractor.ExtractZipFile(zipFilePath, destinationPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error extracting {zipFilePath}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Extraction completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
