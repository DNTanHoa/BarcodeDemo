using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode.Generator
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
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
        /// Exit Program Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitProgramClick(object sender, EventArgs e)
        {
            var confirmDialogResult = MessageBox.Show("Are You Sure To Exit Program?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmDialogResult == DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// Execute Program Follow Function Key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyData)
            {
                case Keys.F1:
                    ShowQRCodeFormClick(null, null);
                    break;
                case Keys.F2:
                    ShowBarCodeFormClick(null, null);
                    break;
                case Keys.F12:
                    ExitProgramClick(null, null);
                    break;
            }
        }
    }
}
