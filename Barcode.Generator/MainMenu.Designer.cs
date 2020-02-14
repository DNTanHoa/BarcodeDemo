namespace Barcode.Generator
{
    partial class MainMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.headPanel.SuspendLayout();
            this.footPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.headPanel.Controls.Add(this.appTitle);
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(276, 62);
            this.headPanel.TabIndex = 1;
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("MS Mincho", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.appTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.appTitle.Location = new System.Drawing.Point(51, 20);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(178, 21);
            this.appTitle.TabIndex = 0;
            this.appTitle.Text = "Code Generator";
            // 
            // footPanel
            // 
            this.footPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.footPanel.Controls.Add(this.label1);
            this.footPanel.Location = new System.Drawing.Point(0, 213);
            this.footPanel.Name = "footPanel";
            this.footPanel.Size = new System.Drawing.Size(276, 49);
            this.footPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Mincho", 10.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © Code Generator";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(12, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "QR Code Generate (F1)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowQRCodeFormClick);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(12, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Bar Code Generate (F2)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowBarCodeFormClick);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS Gothic", 12F);
            this.button3.Location = new System.Drawing.Point(12, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exit Program (F12)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ExitProgramClick);
            this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 263);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.footPanel);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.footPanel.ResumeLayout(false);
            this.footPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Panel footPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}