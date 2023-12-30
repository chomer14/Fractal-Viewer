using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Fractal_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            float centreX = -0.75f, centreY = 0;
            float scale = 175;

            int iterationMaximum = 50;
            int magnitudeThresholdSquared = 2*2;

            Bitmap b = new Bitmap(1,1);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 100; i++)
            {
                b = generateFractal(centreX, centreY, scale, iterationMaximum, magnitudeThresholdSquared);
            }

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            MessageBox.Show($"{Math.Round((double)elapsedTime.TotalSeconds, 3)} Seconds");

            fractalPbx.Image = b;
        }

        public Bitmap generateFractal(float centreX, float centreY, float scale,float iterationMaximum, float magnitudeThresholdSquared)
        {
            List<List<Color>> colourRows = new List<List<Color>>();

            for (int y = 0; y < fractalPbx.Height; y++)
            {
                colourRows.Add(generateFractalRow(centreX, centreY, scale, iterationMaximum, magnitudeThresholdSquared, y));
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

        public List<Color> generateFractalRow(float centreX, float centreY, float scale, float iterationMaximum, float magnitudeThresholdSquared, int y)
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
    }
}
