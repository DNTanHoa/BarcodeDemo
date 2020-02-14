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
using ZXing.QrCode;

namespace Barcode.Generator
{
    public partial class QRCodeForm : Form
    {
        public QRCodeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generate Code From Text Input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateCodeClick(object sender, EventArgs e)
        {
            if(contentInput.Text != "")
            {
                string content = contentInput.Text;
                var QRCodeWriter = new ZXing.BarcodeWriter();
                var QROptions = new ZXing.Common.EncodingOptions
                {
                    Margin = 5,
                    Width = 200,
                    Height = 200,
                };
                QRCodeWriter.Options = QROptions;
                QRCodeWriter.Format = ZXing.BarcodeFormat.QR_CODE;
                var result = QRCodeWriter.Write(content);
                codeDisplay.Image = result;
            }
            else
            {
                MessageBox.Show("Please Input Content You Want To Generate Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contentInput.Focus();
            }
        }

        /// <summary>
        /// Save Code As Image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCodeClick(object sender, EventArgs e)
        {
            if(codeDisplay.Image != null)
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
        /// Call Barcode Form Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowBarCodeFormClick(object sender, EventArgs e)
        {
            this.Visible = false;
            var barCodeForm = new BarCodeForm();
            barCodeForm.ShowDialog();
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
