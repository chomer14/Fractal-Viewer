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

            for (int y = 0; y < fractalPbx.Height; y++)
            {
                for (int x = 0; x < fractalPbx.Width; x++)
                {
                    var rgbObject = HSVtoRGBConverter.HSVtoRGB(120, 0.75, 0.75);

                    Color colourFromRgb = Color.FromArgb(rgbObject.Red, rgbObject.Green, rgbObject.Blue);
                    
                    pbxBitmapBuilder.SetPixel(x, y, colourFromRgb);
                }
            }

            fractalPbx.Image = pbxBitmapBuilder;
        }
    }
}
