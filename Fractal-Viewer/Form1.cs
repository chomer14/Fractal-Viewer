using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fractal_Viewer
{
    public partial class Form1 : Form
    {
        float centreX = 0f, centreY = 0;
        float scale = 175;

        int iterationMaximum = 100;
        int magnitudeThresholdSquared = 2 * 2;

        float colourShift = 0;

        public Form1()
        {
            this.MouseWheel += Form1_Scroll;
            InitializeComponent();

            loadFractal();
        }

        public void loadFractal()
        {
            centralFocusLbl.Text = $"({Math.Round(centreX, 3)}) + ({Math.Round(centreY, 3)})i";
            scaleLbl.Text = $"{scale.ToString("E3")}";

            Stopwatch s = new Stopwatch();
            s.Start();
            Bitmap b = fractalGenerator.generateFractal(fractalPbx, scale, centreX, centreY, iterationMaximum, magnitudeThresholdSquared, colourShift);
            s.Stop();
            renderTimeLbl.Text = $"{s.ElapsedMilliseconds}ms";

            maxIterSldr.Value = iterationMaximum;
            maxItersLbl.Text = $"{iterationMaximum}";

            magThresholdLbl.Text = $"{magThresholdSldr.Value}";

            commandPnl.Height = b.Height;

            fractalPbx.Image = b;
        }

        private void Form1_Scroll(object sender, MouseEventArgs e)
        {
            (float a, float b) newCentre = pixelToComplex(e.X - fractalPbx.Location.X, e.Y - fractalPbx.Location.Y);
            centreX = newCentre.a;
            centreY = newCentre.b;

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
            fractalPbx.Size = new Size(this.Width - 210, this.Height - 80);
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
            colourShift = colourShiftSldr.Value * 30;
            loadFractal();
        }

        public (float, float) pixelToComplex(float x, float y)
        {
            float relativeX = x - fractalPbx.Width / 2;
            float relativeY = y - fractalPbx.Height / 2;

            relativeX /= scale;
            relativeY /= scale;

            relativeX += centreX;
            relativeY += centreY;

            return (relativeX, relativeY);
        }
    }
}
