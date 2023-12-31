using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal_Viewer
{
    public partial class Form1 : Form
    {
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
    }
}
