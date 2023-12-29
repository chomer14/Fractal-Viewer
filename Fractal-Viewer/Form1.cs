using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Bitmap pbxBitmapBuilder = new Bitmap(fractalPbx.Width, fractalPbx.Height);
            int centreX = 0, centreY = 0;
            double scale = 1;

            for (int y = 0; y < fractalPbx.Height; y++)
            {
                for (int x = 0; x < fractalPbx.Width; x++)
                {
                    // start by finding what coords we are on the complex plane.
                    double relativeX = x - fractalPbx.Width / 2;
                    double relativeY = y - fractalPbx.Height / 2;

                    relativeX *= scale;
                    relativeY *= scale;

                    relativeX -= centreX;
                    relativeY -= centreY;

                    double magnitude = Math.Sqrt(Math.Pow(relativeX, 2) + Math.Pow(relativeY, 2));
                    double theta = Math.Atan2(relativeX, relativeY);
                    theta += 2 * Math.PI;
                    theta %= 2 * Math.PI;

                    double thetaDeg = theta / Math.PI * 180;

                    var rgbObject = HSVtoRGBConverter.HSVtoRGB(thetaDeg, 0.75, 0.75);
                    Color colourFromRgb = Color.FromArgb(rgbObject.Red, rgbObject.Green, rgbObject.Blue);
                    
                    pbxBitmapBuilder.SetPixel(x, y, colourFromRgb);
                }
            }

            fractalPbx.Image = pbxBitmapBuilder;
        }
    }
}
