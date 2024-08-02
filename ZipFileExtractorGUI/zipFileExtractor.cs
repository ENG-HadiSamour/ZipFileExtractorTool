using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace ZipFileExtractorGUI
{
    internal class zipFileExtractor
    {
        public void ExtractZipFile(string zipFilePath, String destinationDirectory)
        {
            var extractDirZipFilePath = Path.Combine(destinationDirectory, Path.GetFileNameWithoutExtension(zipFilePath));

            if (!Directory.Exists(extractDirZipFilePath))
            {
                Directory.CreateDirectory(extractDirZipFilePath);
            }

            ZipFile.ExtractToDirectory(zipFilePath, extractDirZipFilePath);

        }
    }
}
