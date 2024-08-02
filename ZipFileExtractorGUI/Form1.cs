using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
                openFileDialog.Filter = "Zip files (*.zip)|*.zip";

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

        private CancellationTokenSource cancellationTokenSource;

        private async void btnExtract_Click(object sender, EventArgs e)
        {

            lblStatus.Text = "Extraction in progress...";

            if (string.IsNullOrWhiteSpace(txtZipFilePath.Text) || string.IsNullOrWhiteSpace(txtDestinationPath.Text))
            {
                lblStatus.Text = "Error!";
                MessageBox.Show("Please select both source zip files and destination path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Ready";
                return;
            }

            var zipFilePaths = txtZipFilePath.Text.Split(';');
            var destinationPath = txtDestinationPath.Text;

            var zipFileExtractor = new zipFileExtractor();

            progressBar.Value = 0;
            progressBar.Maximum = zipFilePaths.Length;

            cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            try
            {
                foreach (var zipFilePath in zipFilePaths)
                {
                    if (token.IsCancellationRequested)
                        break;

                    await Task.Run(() => zipFileExtractor.ExtractZipFile(zipFilePath, destinationPath));
                    progressBar.Value++;
                    lblStatus.Text = $"Extracting {Path.GetFileName(zipFilePath)}...";
                }
            }

            catch (OperationCanceledException)
            {
                lblStatus.Text = "Extraction canceled.";
                //MessageBox.Show("Extraction canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
                //MessageBox.Show($"Error extracting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //string errorMessage = $"Error extracting {zipFilePath}:{ex.Message}";
                //MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //LogError(errorMessage);
            }
            finally
            {
                lblStatus.Text = "Extraction completed";
                //MessageBox.Show("Extraction completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnClearD_Click(object sender, EventArgs e)
        {
            txtDestinationPath.Text = string.Empty;
        }

        private void btnClearS_Click(object sender, EventArgs e)
        {
            txtZipFilePath.Text = string.Empty;
        }

        //private void LogError(string message)
        //{
        //    string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error log");
        //    File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
        }
    }
}
