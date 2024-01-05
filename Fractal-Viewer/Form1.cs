using System;
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


        string realEquation = "zRe * zRe - zIm * zIm + cRe";
        string imaginaryEquation = "2 * zRe * zIm + cIm";

        public Form1()
        {
            InitializeComponent();

            this.MouseWheel += Form1_Scroll;
            this.fractalPbx.MouseDown += fractalPbx_MouseDown;

            loadFractal();
        }

        public void loadFractal()
        {
            // below vars have type Func<float, float, float, float, float>
            var realFunction = expressionEvaluator.GetUserDefinedFunction(reEqTbx.Text);
            var imaginaryFunction = expressionEvaluator.GetUserDefinedFunction(imEqTbx.Text);

            // Update labels showing focus and scale
            centralFocusLbl.Text = $"({Math.Round(centreX, 3)}) + ({Math.Round(centreY, 3)})i";
            scaleLbl.Text = $"{scale.ToString("E3")}";

            // if constant fields are blank, consider them 0
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
