using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.GlobalClasses
{
    internal class Util
    {
        public static bool CreateFolderIfDoesNotExist(string folderName)
        {
            if (!Directory.Exists(folderName))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(folderName);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;
        }

        public static string GenerateGUID()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
        public static string ReplaceFileNameWithGUID(string fileName) { 
        
            FileInfo file = new FileInfo(fileName);
            string exten = file.Extension;

            return GenerateGUID() + exten;
        }
        public static bool copyImageToProjectImagesFolder(ref string sourceImage)
        {
            string DestinationFolder = @"D:\DVLDPeopleImages\";

            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }
            string DestionationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceImage);

            try
            {
                File.Copy(sourceImage, DestionationFile, true);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceImage = DestionationFile;
            return true;
        }
    }
}
