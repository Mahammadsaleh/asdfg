﻿namespace MyExplorer
{
    partial class TextFileOpener
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
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbMain
            // 
            this.rtbMain.Location = new System.Drawing.Point(28, 61);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(747, 367);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            // 
            // TextFileOpener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbMain);
            this.Name = "TextFileOpener";
            this.Text = "TextFileOpener";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbMain;
    }
}