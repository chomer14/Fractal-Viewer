using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fractal_Viewer
{
    public partial class Form1 : Form
    {
        float centreX = -0.75f, centreY = 0;
        float scale = 175;

        int iterationMaximum = 200;
        int magnitudeThresholdSquared = 2 * 2;

        public Form1()
        {
            this.MouseWheel += Form1_Scroll;
            InitializeComponent();

            loadFractal();
        }

        public void loadFractal()
        {
            Bitmap b = generateFractal();
            fractalPbx.Image = b;
        }

        public Bitmap generateFractal()
        {
            List<List<Color>> colourRows = new List<List<Color>>();

            for (int y = 0; y < fractalPbx.Height; y++)
            {
                colourRows.Add(generateFractalRow(y));
            }

            Bitmap pbxBitmapBuilder = new Bitmap(fractalPbx.Width, fractalPbx.Height);

            for (int i = 0; i < colourRows.Count; i++)
            {
                for (int j = 0; j < colourRows.Count; j++)
                {
                    pbxBitmapBuilder.SetPixel(j, i, colourRows[i][j]);
                }
            }

            return pbxBitmapBuilder;
        }

        public List<Color> generateFractalRow(int y)
        {
            List<Color> colourList = new List<Color>();

            for (int x = 0; x < fractalPbx.Width; x++)
            {
                // start by finding what coords we are on the complex plane.
                float relativeX = x - fractalPbx.Width / 2;
                float relativeY = y - fractalPbx.Height / 2;

                relativeX /= scale;
                relativeY /= scale;

                relativeX += centreX;
                relativeY += centreY;
                relativeY *= -1;

                bool b = true;
                Color c = Color.White; // just a random default, has to be there or else compiler error

                float cRe = relativeX;
                float cIm = relativeY;

                // these are correct
                float zRe = cRe;
                float zIm = cIm;

                for (int iterationCount = 0; iterationCount < iterationMaximum; iterationCount++)
                {
                    // sqrt(a^2 + b^2) > r == a^2 + b^2 > r^2
                    if ((zRe * zRe + zIm * zIm) > magnitudeThresholdSquared)
                    {
                        var rgbObject = HSVtoRGBConverter.HSVtoRGB((float)iterationCount / (float)iterationMaximum * 360f, 1, 1);
                        c = Color.FromArgb(rgbObject.Red, rgbObject.Green, rgbObject.Blue);
                        b = false;
                        break;
                    }

                    // square z and add c
                    // (a+bi)^2 = a^2 + 2abi - b^2 = (a^2-b^2) + (2ab)i
                    float tZIm = zIm;
                    zIm = 2 * zRe * zIm + cIm;
                    zRe = zRe * zRe - tZIm * tZIm + cRe;
                }

                if (b)
                {
                    c = Color.Black;
                }

                colourList.Add(c);
            }
            return colourList;
        }

        private void Form1_Scroll(object sender, MouseEventArgs e)
        {
            float ratio = e.Delta / Math.Abs(e.Delta);
            ratio /= 15;
            ratio += 1;
            scale *= ratio;

            loadFractal();

            (float a, float b) newCentre = pixelToComplex(e.X, e.Y);
            centreX = newCentre.a;
            centreY = newCentre.b;
        }

        public (float, float) pixelToComplex(float x, float y)
        {
            float relativeX = x - fractalPbx.Width / 2;
            float relativeY = y - fractalPbx.Height / 2;

            relativeX /= scale;
            relativeY /= scale;

            relativeX += centreX;
            relativeY += centreY;
            relativeY *= -1;

            return (relativeX, relativeY);
        }
    }
}
