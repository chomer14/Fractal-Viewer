namespace Fractal_Viewer
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
            this.label3 = new System.Windows.Forms.Label();
            this.renderTimeLbl = new System.Windows.Forms.Label();
            this.resetScaleLbl = new System.Windows.Forms.Button();
            this.maxIterSldr = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.maxItersLbl = new System.Windows.Forms.Label();
            this.magThresholdLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.magThresholdSldr = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.fractalPbx)).BeginInit();
            this.commandPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterSldr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magThresholdSldr)).BeginInit();
            this.SuspendLayout();
            // 
            // fractalPbx
            // 
            this.fractalPbx.Location = new System.Drawing.Point(170, 20);
            this.fractalPbx.Name = "fractalPbx";
            this.fractalPbx.Size = new System.Drawing.Size(500, 500);
            this.fractalPbx.TabIndex = 0;
            this.fractalPbx.TabStop = false;
            // 
            // resetToOriginBtn
            // 
            this.resetToOriginBtn.Location = new System.Drawing.Point(3, 33);
            this.resetToOriginBtn.Name = "resetToOriginBtn";
            this.resetToOriginBtn.Size = new System.Drawing.Size(120, 23);
            this.resetToOriginBtn.TabIndex = 1;
            this.resetToOriginBtn.Text = "Reset to (0,0)";
            this.resetToOriginBtn.UseVisualStyleBackColor = true;
            this.resetToOriginBtn.Click += new System.EventHandler(this.resetToOriginBtn_Click);
            // 
            // centralFocusLbl
            // 
            this.centralFocusLbl.AutoSize = true;
            this.centralFocusLbl.Location = new System.Drawing.Point(3, 17);
            this.centralFocusLbl.Name = "centralFocusLbl";
            this.centralFocusLbl.Size = new System.Drawing.Size(33, 13);
            this.centralFocusLbl.TabIndex = 2;
            this.centralFocusLbl.Text = "(a+bi)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Central Focus Point:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Scale:";
            // 
            // scaleLbl
            // 
            this.scaleLbl.AutoSize = true;
            this.scaleLbl.Location = new System.Drawing.Point(3, 85);
            this.scaleLbl.Name = "scaleLbl";
            this.scaleLbl.Size = new System.Drawing.Size(30, 13);
            this.scaleLbl.TabIndex = 4;
            this.scaleLbl.Text = "100x";
            // 
            // commandPnl
            // 
            this.commandPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commandPnl.Controls.Add(this.magThresholdLbl);
            this.commandPnl.Controls.Add(this.label6);
            this.commandPnl.Controls.Add(this.magThresholdSldr);
            this.commandPnl.Controls.Add(this.maxItersLbl);
            this.commandPnl.Controls.Add(this.label4);
            this.commandPnl.Controls.Add(this.maxIterSldr);
            this.commandPnl.Controls.Add(this.resetScaleLbl);
            this.commandPnl.Controls.Add(this.renderTimeLbl);
            this.commandPnl.Controls.Add(this.label3);
            this.commandPnl.Controls.Add(this.resetToOriginBtn);
            this.commandPnl.Controls.Add(this.label1);
            this.commandPnl.Controls.Add(this.centralFocusLbl);
            this.commandPnl.Controls.Add(this.scaleLbl);
            this.commandPnl.Controls.Add(this.label2);
            this.commandPnl.Location = new System.Drawing.Point(20, 20);
            this.commandPnl.Name = "commandPnl";
            this.commandPnl.Size = new System.Drawing.Size(130, 500);
            this.commandPnl.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Render time:";
            // 
            // renderTimeLbl
            // 
            this.renderTimeLbl.AutoSize = true;
            this.renderTimeLbl.Location = new System.Drawing.Point(3, 323);
            this.renderTimeLbl.Name = "renderTimeLbl";
            this.renderTimeLbl.Size = new System.Drawing.Size(38, 13);
            this.renderTimeLbl.TabIndex = 7;
            this.renderTimeLbl.Text = "372ms";
            // 
            // resetScaleLbl
            // 
            this.resetScaleLbl.Location = new System.Drawing.Point(3, 101);
            this.resetScaleLbl.Name = "resetScaleLbl";
            this.resetScaleLbl.Size = new System.Drawing.Size(120, 23);
            this.resetScaleLbl.TabIndex = 8;
            this.resetScaleLbl.Text = "Reset Scale";
            this.resetScaleLbl.UseVisualStyleBackColor = true;
            this.resetScaleLbl.Click += new System.EventHandler(this.resetScaleLbl_Click);
            // 
            // maxIterSldr
            // 
            this.maxIterSldr.Location = new System.Drawing.Point(3, 146);
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
            this.label4.Location = new System.Drawing.Point(3, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Maximum Iterations:";
            // 
            // maxItersLbl
            // 
            this.maxItersLbl.AutoSize = true;
            this.maxItersLbl.Location = new System.Drawing.Point(3, 194);
            this.maxItersLbl.Name = "maxItersLbl";
            this.maxItersLbl.Size = new System.Drawing.Size(25, 13);
            this.maxItersLbl.TabIndex = 12;
            this.maxItersLbl.Text = "200";
            // 
            // magThresholdLbl
            // 
            this.magThresholdLbl.AutoSize = true;
            this.magThresholdLbl.Location = new System.Drawing.Point(3, 275);
            this.magThresholdLbl.Name = "magThresholdLbl";
            this.magThresholdLbl.Size = new System.Drawing.Size(13, 13);
            this.magThresholdLbl.TabIndex = 15;
            this.magThresholdLbl.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Magnitude Threshold:";
            // 
            // magThresholdSldr
            // 
            this.magThresholdSldr.LargeChange = 2;
            this.magThresholdSldr.Location = new System.Drawing.Point(3, 227);
            this.magThresholdSldr.Name = "magThresholdSldr";
            this.magThresholdSldr.Size = new System.Drawing.Size(104, 45);
            this.magThresholdSldr.TabIndex = 13;
            this.magThresholdSldr.Value = 2;
            this.magThresholdSldr.ValueChanged += new System.EventHandler(this.magThresholdSldr_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 541);
            this.Controls.Add(this.commandPnl);
            this.Controls.Add(this.fractalPbx);
            this.Name = "Form1";
            this.Text = "Fractal Viewer";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.fractalPbx)).EndInit();
            this.commandPnl.ResumeLayout(false);
            this.commandPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterSldr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magThresholdSldr)).EndInit();
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
    }
}

