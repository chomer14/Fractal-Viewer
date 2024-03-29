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
            this.resetToOriginBtn = new System.Windows.Forms.Button();
            this.centralFocusLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scaleLbl = new System.Windows.Forms.Label();
            this.commandPnl = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.magThresholdSldr = new System.Windows.Forms.TrackBar();
            this.magThresholdLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.colourShiftSldr = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resetScaleLbl = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.renderTimeLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.maxIterSldr = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.maxItersLbl = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.helpBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imConsTbx = new System.Windows.Forms.TextBox();
            this.reConsTbx = new System.Windows.Forms.TextBox();
            this.loadFractalBtn = new System.Windows.Forms.Button();
            this.saveFractalBtn = new System.Windows.Forms.Button();
            this.mandelbrotResetBtn = new System.Windows.Forms.Button();
            this.reloadFractalBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.imEqTbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.reEqTbx = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fractalPbx)).BeginInit();
            this.commandPnl.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magThresholdSldr)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colourShiftSldr)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterSldr)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // fractalPbx
            // 
            this.fractalPbx.Location = new System.Drawing.Point(362, 20);
            this.fractalPbx.Name = "fractalPbx";
            this.fractalPbx.Size = new System.Drawing.Size(500, 500);
            this.fractalPbx.TabIndex = 0;
            this.fractalPbx.TabStop = false;
            // 
            // resetToOriginBtn
            // 
            this.resetToOriginBtn.Location = new System.Drawing.Point(-1, 29);
            this.resetToOriginBtn.Name = "resetToOriginBtn";
            this.resetToOriginBtn.Size = new System.Drawing.Size(120, 23);
            this.resetToOriginBtn.TabIndex = 1;
            this.resetToOriginBtn.Text = "Reset to (0) + (0)i";
            this.resetToOriginBtn.UseVisualStyleBackColor = true;
            this.resetToOriginBtn.Click += new System.EventHandler(this.resetToOriginBtn_Click);
            // 
            // centralFocusLbl
            // 
            this.centralFocusLbl.AutoSize = true;
            this.centralFocusLbl.Location = new System.Drawing.Point(-1, 13);
            this.centralFocusLbl.Name = "centralFocusLbl";
            this.centralFocusLbl.Size = new System.Drawing.Size(33, 13);
            this.centralFocusLbl.TabIndex = 2;
            this.centralFocusLbl.Text = "(a+bi)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Central Focus Point:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Scale:";
            // 
            // scaleLbl
            // 
            this.scaleLbl.AutoSize = true;
            this.scaleLbl.Location = new System.Drawing.Point(0, 13);
            this.scaleLbl.Name = "scaleLbl";
            this.scaleLbl.Size = new System.Drawing.Size(30, 13);
            this.scaleLbl.TabIndex = 4;
            this.scaleLbl.Text = "100x";
            // 
            // commandPnl
            // 
            this.commandPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commandPnl.Controls.Add(this.panel5);
            this.commandPnl.Controls.Add(this.panel1);
            this.commandPnl.Controls.Add(this.panel6);
            this.commandPnl.Controls.Add(this.panel2);
            this.commandPnl.Controls.Add(this.panel3);
            this.commandPnl.Controls.Add(this.panel4);
            this.commandPnl.Location = new System.Drawing.Point(20, 20);
            this.commandPnl.Name = "commandPnl";
            this.commandPnl.Size = new System.Drawing.Size(130, 500);
            this.commandPnl.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.magThresholdSldr);
            this.panel5.Controls.Add(this.magThresholdLbl);
            this.panel5.Location = new System.Drawing.Point(4, 217);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(122, 82);
            this.panel5.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Magnitude Threshold:";
            // 
            // magThresholdSldr
            // 
            this.magThresholdSldr.LargeChange = 2;
            this.magThresholdSldr.Location = new System.Drawing.Point(3, 16);
            this.magThresholdSldr.Name = "magThresholdSldr";
            this.magThresholdSldr.Size = new System.Drawing.Size(104, 45);
            this.magThresholdSldr.TabIndex = 13;
            this.magThresholdSldr.Value = 2;
            this.magThresholdSldr.ValueChanged += new System.EventHandler(this.magThresholdSldr_ValueChanged);
            // 
            // magThresholdLbl
            // 
            this.magThresholdLbl.AutoSize = true;
            this.magThresholdLbl.Location = new System.Drawing.Point(3, 64);
            this.magThresholdLbl.Name = "magThresholdLbl";
            this.magThresholdLbl.Size = new System.Drawing.Size(13, 13);
            this.magThresholdLbl.TabIndex = 15;
            this.magThresholdLbl.Text = "2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.resetToOriginBtn);
            this.panel1.Controls.Add(this.centralFocusLbl);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 52);
            this.panel1.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.colourShiftSldr);
            this.panel6.Location = new System.Drawing.Point(3, 435);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(122, 58);
            this.panel6.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Colour Shift:";
            // 
            // colourShiftSldr
            // 
            this.colourShiftSldr.LargeChange = 3;
            this.colourShiftSldr.Location = new System.Drawing.Point(3, 16);
            this.colourShiftSldr.Maximum = 12;
            this.colourShiftSldr.Name = "colourShiftSldr";
            this.colourShiftSldr.Size = new System.Drawing.Size(104, 45);
            this.colourShiftSldr.TabIndex = 16;
            this.colourShiftSldr.ValueChanged += new System.EventHandler(this.colourShiftSldr_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resetScaleLbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.scaleLbl);
            this.panel2.Location = new System.Drawing.Point(4, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 52);
            this.panel2.TabIndex = 19;
            // 
            // resetScaleLbl
            // 
            this.resetScaleLbl.Location = new System.Drawing.Point(0, 29);
            this.resetScaleLbl.Name = "resetScaleLbl";
            this.resetScaleLbl.Size = new System.Drawing.Size(120, 23);
            this.resetScaleLbl.TabIndex = 8;
            this.resetScaleLbl.Text = "Reset Scale";
            this.resetScaleLbl.UseVisualStyleBackColor = true;
            this.resetScaleLbl.Click += new System.EventHandler(this.resetScaleLbl_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.renderTimeLbl);
            this.panel3.Location = new System.Drawing.Point(3, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 29);
            this.panel3.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Render time:";
            // 
            // renderTimeLbl
            // 
            this.renderTimeLbl.AutoSize = true;
            this.renderTimeLbl.Location = new System.Drawing.Point(3, 13);
            this.renderTimeLbl.Name = "renderTimeLbl";
            this.renderTimeLbl.Size = new System.Drawing.Size(38, 13);
            this.renderTimeLbl.TabIndex = 7;
            this.renderTimeLbl.Text = "372ms";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.maxIterSldr);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.maxItersLbl);
            this.panel4.Location = new System.Drawing.Point(3, 326);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(122, 82);
            this.panel4.TabIndex = 20;
            // 
            // maxIterSldr
            // 
            this.maxIterSldr.Location = new System.Drawing.Point(0, 16);
            this.maxIterSldr.Maximum = 500;
            this.maxIterSldr.Minimum = 1;
            this.maxIterSldr.Name = "maxIterSldr";
            this.maxIterSldr.Size = new System.Drawing.Size(104, 45);
            this.maxIterSldr.TabIndex = 9;
            this.maxIterSldr.Value = 200;
            this.maxIterSldr.ValueChanged += new System.EventHandler(this.maxIterSldr_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Maximum Iterations:";
            // 
            // maxItersLbl
            // 
            this.maxItersLbl.AutoSize = true;
            this.maxItersLbl.Location = new System.Drawing.Point(3, 64);
            this.maxItersLbl.Name = "maxItersLbl";
            this.maxItersLbl.Size = new System.Drawing.Size(25, 13);
            this.maxItersLbl.TabIndex = 12;
            this.maxItersLbl.Text = "200";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.helpBtn);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.imConsTbx);
            this.panel7.Controls.Add(this.reConsTbx);
            this.panel7.Controls.Add(this.loadFractalBtn);
            this.panel7.Controls.Add(this.saveFractalBtn);
            this.panel7.Controls.Add(this.mandelbrotResetBtn);
            this.panel7.Controls.Add(this.reloadFractalBtn);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.imEqTbx);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.reEqTbx);
            this.panel7.Location = new System.Drawing.Point(156, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 279);
            this.panel7.TabIndex = 22;
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(23, 233);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(152, 23);
            this.helpBtn.TabIndex = 35;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Imaginary Constant";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Real Constant";
            // 
            // imConsTbx
            // 
            this.imConsTbx.Location = new System.Drawing.Point(100, 126);
            this.imConsTbx.Name = "imConsTbx";
            this.imConsTbx.Size = new System.Drawing.Size(95, 20);
            this.imConsTbx.TabIndex = 32;
            this.imConsTbx.Text = "0";
            // 
            // reConsTbx
            // 
            this.reConsTbx.Location = new System.Drawing.Point(3, 126);
            this.reConsTbx.Name = "reConsTbx";
            this.reConsTbx.Size = new System.Drawing.Size(95, 20);
            this.reConsTbx.TabIndex = 23;
            this.reConsTbx.Text = "0";
            // 
            // loadFractalBtn
            // 
            this.loadFractalBtn.Location = new System.Drawing.Point(23, 207);
            this.loadFractalBtn.Name = "loadFractalBtn";
            this.loadFractalBtn.Size = new System.Drawing.Size(75, 23);
            this.loadFractalBtn.TabIndex = 31;
            this.loadFractalBtn.Text = "Load Fractal";
            this.loadFractalBtn.UseVisualStyleBackColor = true;
            this.loadFractalBtn.Click += new System.EventHandler(this.loadFractalBtn_Click);
            // 
            // saveFractalBtn
            // 
            this.saveFractalBtn.Location = new System.Drawing.Point(23, 184);
            this.saveFractalBtn.Name = "saveFractalBtn";
            this.saveFractalBtn.Size = new System.Drawing.Size(75, 23);
            this.saveFractalBtn.TabIndex = 30;
            this.saveFractalBtn.Text = "Save Fractal";
            this.saveFractalBtn.UseVisualStyleBackColor = true;
            this.saveFractalBtn.Click += new System.EventHandler(this.saveFractalBtn_Click);
            // 
            // mandelbrotResetBtn
            // 
            this.mandelbrotResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.mandelbrotResetBtn.Location = new System.Drawing.Point(23, 161);
            this.mandelbrotResetBtn.Name = "mandelbrotResetBtn";
            this.mandelbrotResetBtn.Size = new System.Drawing.Size(75, 23);
            this.mandelbrotResetBtn.TabIndex = 29;
            this.mandelbrotResetBtn.Text = "Reset Mandelbrot";
            this.mandelbrotResetBtn.UseVisualStyleBackColor = true;
            this.mandelbrotResetBtn.Click += new System.EventHandler(this.mandelbrotResetBtn_Click);
            // 
            // reloadFractalBtn
            // 
            this.reloadFractalBtn.Location = new System.Drawing.Point(100, 161);
            this.reloadFractalBtn.Name = "reloadFractalBtn";
            this.reloadFractalBtn.Size = new System.Drawing.Size(75, 69);
            this.reloadFractalBtn.TabIndex = 28;
            this.reloadFractalBtn.Text = "Reload";
            this.reloadFractalBtn.UseVisualStyleBackColor = true;
            this.reloadFractalBtn.Click += new System.EventHandler(this.reloadFractalBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Imaginary Equation:";
            // 
            // imEqTbx
            // 
            this.imEqTbx.Location = new System.Drawing.Point(3, 75);
            this.imEqTbx.Name = "imEqTbx";
            this.imEqTbx.Size = new System.Drawing.Size(192, 20);
            this.imEqTbx.TabIndex = 26;
            this.imEqTbx.Text = "2 * zRe * zIm + cIm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Real Equation:";
            // 
            // reEqTbx
            // 
            this.reEqTbx.Location = new System.Drawing.Point(3, 19);
            this.reEqTbx.Name = "reEqTbx";
            this.reEqTbx.Size = new System.Drawing.Size(192, 20);
            this.reEqTbx.TabIndex = 23;
            this.reEqTbx.Text = "zRe * zRe - zIm * zIm + cRe";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.commandPnl);
            this.Controls.Add(this.fractalPbx);
            this.Name = "Form1";
            this.Text = "Fractal Viewer";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.fractalPbx)).EndInit();
            this.commandPnl.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magThresholdSldr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colourShiftSldr)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterSldr)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fractalPbx;
        private System.Windows.Forms.Button resetToOriginBtn;
        private System.Windows.Forms.Label centralFocusLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scaleLbl;
        private System.Windows.Forms.Panel commandPnl;
        private System.Windows.Forms.Label renderTimeLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetScaleLbl;
        private System.Windows.Forms.TrackBar maxIterSldr;
        private System.Windows.Forms.Label maxItersLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label magThresholdLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar magThresholdSldr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar colourShiftSldr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox imEqTbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reEqTbx;
        private System.Windows.Forms.Button reloadFractalBtn;
        private System.Windows.Forms.Button mandelbrotResetBtn;
        private System.Windows.Forms.Button saveFractalBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button loadFractalBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox imConsTbx;
        private System.Windows.Forms.TextBox reConsTbx;
        private System.Windows.Forms.Button helpBtn;
    }
}

