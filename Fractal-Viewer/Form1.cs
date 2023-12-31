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
    }
}
