using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Linq;

namespace Fractal_Viewer
{
    public partial class Form1 : Form
    {
        float centreX = 0f, centreY = 0;
        float scale = 175;

        int iterationMaximum = 100;
        int magnitudeThresholdSquared = 2 * 2;

        float colourShift = 0;


        string realEquation = "zRe * zRe - zIm * zIm + cRe";
        string imaginaryEquation = "2 * zRe * zIm + cIm";

        public Form1()
        {
            // necessary for scroll event to work regardless of focus
            InitializeComponent();

            this.MouseWheel += Form1_Scroll;
            this.fractalPbx.MouseDown += fractalPbx_MouseDown;

            loadFractal();
        }

        private void fractalPbx_MouseDown(object sender, MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;
            (float a, float b) x = pixelToComplex(e.X, e.Y);
            MessageBox.Show($"({x.a})+({x.b})i");
        }

        public void loadFractal()
        {
            realEquation = reEqTbx.Text;
            imaginaryEquation = imEqTbx.Text;

            Func<float, float, float, float, float> realFunction;
            Func<float, float, float, float, float> imaginaryFunction;

            realFunction = expressionEvaluator.GetUserDefinedFunction(realEquation);
            imaginaryFunction = expressionEvaluator.GetUserDefinedFunction(imaginaryEquation);

            // Update labels showing focus and scale
            centralFocusLbl.Text = $"({Math.Round(centreX, 3)}) + ({Math.Round(centreY, 3)})i";
            scaleLbl.Text = $"{scale.ToString("E3")}";

            float realConst = float.Parse(reConsTbx.Text.Trim() == "" ? "0" : reConsTbx.Text.Trim());
            float imagConst = float.Parse(imConsTbx.Text.Trim() == "" ? "0" : imConsTbx.Text.Trim());

            // time to generate
            Stopwatch s = new Stopwatch();
            s.Start();

            // generate fractal
            Bitmap b = fractalGenerator.generateFractal(fractalPbx, scale, centreX, centreY, iterationMaximum, magnitudeThresholdSquared, colourShift, realFunction, imaginaryFunction, realConst, imagConst);
            
            // display generation duration
            s.Stop();
            renderTimeLbl.Text = $"{s.ElapsedMilliseconds}ms";

            // update other values
            maxIterSldr.Value = iterationMaximum;
            maxItersLbl.Text = $"{iterationMaximum}";
            magThresholdLbl.Text = $"{magThresholdSldr.Value}";

            // make command panel same height as picturebox
            commandPnl.Height = b.Height;

            // update picturebox
            fractalPbx.Image = b;
        }
    }
}
