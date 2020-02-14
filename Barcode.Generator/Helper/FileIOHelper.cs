using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode.Generator.Helper
{
    public class FileIOHelper
    {
        #region support function
        /// <summary>
        /// Show dialog to config save file
        /// </summary>
        /// <returns></returns>
        public static string GetSaveImageFilePath()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Save Code To Image";
            dialog.DefaultExt = "png";

            string path = "";
            if (dialog.ShowDialog() == DialogResult.OK)
                path = dialog.FileName;
            return path;
        }
        #endregion
    }
}
