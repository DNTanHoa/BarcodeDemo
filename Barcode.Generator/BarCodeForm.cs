using Barcode.Generator.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode.Generator
{
    public partial class BarCodeForm : Form
    {
        public BarCodeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generate Code Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateCodeClick(object sender, EventArgs e)
        {
            if(contentInput.Text != "")
            {
                string content = contentInput.Text;
                var barCodeWriter = new ZXing.BarcodeWriter();
                var barCodeOptions = new ZXing.Common.EncodingOptions
                {
                    Margin = 5,
                    Width = 600,
                    Height = 200,
                };
                barCodeWriter.Options = barCodeOptions;
                barCodeWriter.Format = ZXing.BarcodeFormat.CODE_128;

                var result = barCodeWriter.Write(content);
                codeDisplay.Image = result;
            }
            else
            {
                MessageBox.Show("Please Input Content You Want To Generate Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contentInput.Focus();
            }
        }

        /// <summary>
        /// Save Code To Image File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCodeClick(object sender, EventArgs e)
        {
            if (codeDisplay.Image != null)
            {
                string path = FileIOHelper.GetSaveImageFilePath();
                if (path != "")
                    codeDisplay.Image.Save(path, ImageFormat.Png);
            }
            else
            {
                MessageBox.Show("There Is No Code. Please Enter Content And Press Genenerate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contentInput.Focus();
            }
        }

        /// <summary>
        /// Call QR Code Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowQRCodeFormClick(object sender, EventArgs e)
        {
            this.Visible = false;
            var QRCodeForm = new QRCodeForm();
            QRCodeForm.ShowDialog();
        }

        /// <summary>
        /// Back To Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelClick(object sender, EventArgs e)
        {
            this.Visible = false;
            var mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }
    }
}
