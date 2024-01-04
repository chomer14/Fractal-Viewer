﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Versioning;
using System.Runtime.CompilerServices;

namespace Fractal_Viewer
{
    public partial class Form1 : Form
    {

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            OpenHelpFile(this.ActiveControl.Name, this);
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            OpenHelpFile("", this);
        }

        static void OpenHelpFile(string anchor, Form myForm)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames()
                .Single(str => str.EndsWith("help.html"));
            string result;

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }

            File.WriteAllText("help.html", result);
            string myDir = System.IO.Directory.GetCurrentDirectory().Replace("\\", "/");

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            Form form = new Form();
            form.Width = myForm.Width;
            form.Height = myForm.Height;
            WebBrowser webBrowser = new WebBrowser();

            form.Controls.Add(webBrowser);

            webBrowser.Dock = DockStyle.Fill;

            webBrowser.Navigate($"file://{myDir}/help.html");
            
            webBrowser.DocumentCompleted += (sender, e) =>
            {
                webBrowser.Document.GetElementById(anchor)?.ScrollIntoView(true);
            };

            form.ShowDialog();
        }

        private void Form1_Scroll(object sender, MouseEventArgs e)
        {
            // make sure mouse is within bounds of picturebox
            if (e.X < fractalPbx.Location.X || e.X > fractalPbx.Location.X + fractalPbx.Width)
                return;
            if (e.Y < fractalPbx.Location.Y || e.Y > fractalPbx.Location.Y + fractalPbx.Height)
                return;

            // calculate the complex number represented by the pixel the mouse is over, and centre the zoom there
            (float a, float b) newCentre = pixelToComplex(e.X - fractalPbx.Location.X, e.Y - fractalPbx.Location.Y);
            centreX = newCentre.a;
            centreY = newCentre.b;

            // make scale ratio either 0.5 or 2, doubling zoom or halfing it
            float ratio = e.Delta / Math.Abs(e.Delta);
            ratio += 1;
            ratio /= 2;
            ratio *= 1.5f;
            ratio += 0.5f;
            scale *= ratio;

            loadFractal();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            // scale picturebox to almost fill form
            fractalPbx.Size = new Size(this.Width - 400, this.Height - 80);
            loadFractal();
        }

        private void resetToOriginBtn_Click(object sender, EventArgs e)
        {
            centreX = 0;
            centreY = 0;
            loadFractal();
        }

        private void resetScaleLbl_Click(object sender, EventArgs e)
        {
            scale = 175;
            loadFractal();
        }

        private void maxIterSldr_ValueChanged(object sender, EventArgs e)
        {
            iterationMaximum = maxIterSldr.Value;
            loadFractal();
        }

        private void magThresholdSldr_ValueChanged(object sender, EventArgs e)
        {
            magnitudeThresholdSquared = magThresholdSldr.Value * magThresholdSldr.Value;
            loadFractal();
        }

        private void colourShiftSldr_ValueChanged(object sender, EventArgs e)
        {
            // scale from [0, 12] to [0, 360]
            colourShift = colourShiftSldr.Value * 30;
            loadFractal();
        }

        public (float, float) pixelToComplex(float x, float y)
        {
            // move origin to centre
            float relativeX = x - fractalPbx.Width / 2;
            float relativeY = y - fractalPbx.Height / 2;

            // scale
            relativeX /= scale;
            relativeY /= scale;

            // account for focus
            relativeX += centreX;
            relativeY += centreY;

            return (relativeX, relativeY);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int size;
            float relativeSize;
            bool changed = true;

            // dependant on key, move the centre. If centre moved, reload fractal
            switch (keyData)
            {
                case Keys.W:
                    size = fractalPbx.Height;
                    relativeSize = (float)size / scale;
                    centreY -= relativeSize / 4;
                    break;
                case Keys.A:
                    size = fractalPbx.Width;
                    relativeSize = (float)size / scale;
                    centreX -= relativeSize / 4;
                    break;
                case Keys.S:
                    size = fractalPbx.Height;
                    relativeSize = (float)size / scale;
                    centreY += relativeSize / 4;
                    break;
                case Keys.D:
                    size = fractalPbx.Width;
                    relativeSize = (float)size / scale;
                    centreX += relativeSize / 4;
                    break;

                default:
                    changed = false;
                    break;
            }

            if (changed)
            {
                loadFractal();
            }

            // base behavior
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void reloadFractalBtn_Click(object sender, EventArgs e)
        {
            loadFractal();
        }

        private void mandelbrotResetBtn_Click(object sender, EventArgs e)
        {
            imEqTbx.Text = "2 * zRe * zIm + cIm";
            reEqTbx.Text = "zRe * zRe - zIm * zIm + cRe";
            imConsTbx.Text = "0";
            reConsTbx.Text = "0";
            loadFractal();
        }

        private void saveFractalBtn_Click(object sender, EventArgs e)
        {
            List<string> equations = new List<string> { imEqTbx.Text, reEqTbx.Text, imConsTbx.Text, reConsTbx.Text };
            saveFileDialog1.Title = "Select Where To Save Fractal File";
            saveFileDialog1.DefaultExt = "fra";
            saveFileDialog1.Filter = "fra files (*.fra)|*.fra|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();

            File.WriteAllLines(saveFileDialog1.FileName, equations);
        }

        private void loadFractalBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Where Fractal File To Load";
            openFileDialog1.DefaultExt = "fra";
            openFileDialog1.Filter = "fra files (*.fra)|*.fra|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            List<string> equations = File.ReadAllLines(openFileDialog1.FileName).ToList();
            imEqTbx.Text = equations[0];
            reEqTbx.Text = equations[1];
            imConsTbx.Text = equations[2];
            reConsTbx.Text = equations[3];

            loadFractal();
        }
    }
}
