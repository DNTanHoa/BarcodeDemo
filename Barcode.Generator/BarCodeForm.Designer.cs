namespace Barcode.Generator
{
    partial class BarCodeForm
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
            this.headPanel = new System.Windows.Forms.Panel();
            this.appTitle = new System.Windows.Forms.Label();
            this.footPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.functionPanel = new System.Windows.Forms.Panel();
            this.saveCode = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.barcodeFormButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.codeDisplay = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contentInput = new System.Windows.Forms.RichTextBox();
            this.headPanel.SuspendLayout();
            this.footPanel.SuspendLayout();
            this.functionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.headPanel.Controls.Add(this.appTitle);
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(539, 65);
            this.headPanel.TabIndex = 1;
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("MS Mincho", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.appTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.appTitle.Location = new System.Drawing.Point(165, 23);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(214, 21);
            this.appTitle.TabIndex = 0;
            this.appTitle.Text = "BarCode Generator";
            // 
            // footPanel
            // 
            this.footPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.footPanel.Controls.Add(this.label1);
            this.footPanel.Location = new System.Drawing.Point(0, 385);
            this.footPanel.Name = "footPanel";
            this.footPanel.Size = new System.Drawing.Size(539, 65);
            this.footPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Mincho", 10.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(138, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © Code Generator";
            // 
            // functionPanel
            // 
            this.functionPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.functionPanel.Controls.Add(this.saveCode);
            this.functionPanel.Controls.Add(this.cancelButton);
            this.functionPanel.Controls.Add(this.barcodeFormButton);
            this.functionPanel.Controls.Add(this.generateButton);
            this.functionPanel.Location = new System.Drawing.Point(0, 290);
            this.functionPanel.Name = "functionPanel";
            this.functionPanel.Size = new System.Drawing.Size(539, 95);
            this.functionPanel.TabIndex = 4;
            // 
            // saveCode
            // 
            this.saveCode.Font = new System.Drawing.Font("MS Gothic", 11F);
            this.saveCode.Location = new System.Drawing.Point(153, 28);
            this.saveCode.Name = "saveCode";
            this.saveCode.Size = new System.Drawing.Size(94, 38);
            this.saveCode.TabIndex = 7;
            this.saveCode.Text = "Save Code";
            this.saveCode.UseVisualStyleBackColor = true;
            this.saveCode.Click += new System.EventHandler(this.SaveCodeClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("MS Gothic", 11F);
            this.cancelButton.Location = new System.Drawing.Point(414, 28);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 38);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelClick);
            // 
            // barcodeFormButton
            // 
            this.barcodeFormButton.Font = new System.Drawing.Font("MS Gothic", 11F);
            this.barcodeFormButton.Location = new System.Drawing.Point(285, 28);
            this.barcodeFormButton.Name = "barcodeFormButton";
            this.barcodeFormButton.Size = new System.Drawing.Size(94, 38);
            this.barcodeFormButton.TabIndex = 5;
            this.barcodeFormButton.Text = "QR Code";
            this.barcodeFormButton.UseVisualStyleBackColor = true;
            this.barcodeFormButton.Click += new System.EventHandler(this.ShowQRCodeFormClick);
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("MS Gothic", 11F);
            this.generateButton.Location = new System.Drawing.Point(12, 28);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(94, 38);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateCodeClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "BarCode Result";
            // 
            // codeDisplay
            // 
            this.codeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeDisplay.Location = new System.Drawing.Point(12, 90);
            this.codeDisplay.Name = "codeDisplay";
            this.codeDisplay.Padding = new System.Windows.Forms.Padding(20);
            this.codeDisplay.Size = new System.Drawing.Size(515, 101);
            this.codeDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.codeDisplay.TabIndex = 6;
            this.codeDisplay.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Code Content Input";
            // 
            // contentInput
            // 
            this.contentInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentInput.Font = new System.Drawing.Font("MS Gothic", 12F);
            this.contentInput.Location = new System.Drawing.Point(12, 213);
            this.contentInput.Name = "contentInput";
            this.contentInput.Size = new System.Drawing.Size(515, 71);
            this.contentInput.TabIndex = 9;
            this.contentInput.Text = "";
            // 
            // BarCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.contentInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeDisplay);
            this.Controls.Add(this.functionPanel);
            this.Controls.Add(this.footPanel);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarCodeForm";
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.footPanel.ResumeLayout(false);
            this.footPanel.PerformLayout();
            this.functionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codeDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Panel footPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel functionPanel;
        private System.Windows.Forms.Button saveCode;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button barcodeFormButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox codeDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox contentInput;
    }
}