﻿namespace Fractal_Viewer
{
    partial class Form1
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
            this.fractalPbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fractalPbx)).BeginInit();
            this.SuspendLayout();
            // 
            // fractalPbx
            // 
            this.fractalPbx.Location = new System.Drawing.Point(20, 20);
            this.fractalPbx.Name = "fractalPbx";
            this.fractalPbx.Size = new System.Drawing.Size(500, 500);
            this.fractalPbx.TabIndex = 0;
            this.fractalPbx.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 541);
            this.Controls.Add(this.fractalPbx);
            this.Name = "Form1";
            this.Text = "Fractal Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.fractalPbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fractalPbx;
    }
}

