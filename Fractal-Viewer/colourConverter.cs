using System;

namespace Fractal_Viewer
{
    public class HSVtoRGBConverter
    {
        public static (int Red, int Green, int Blue) HSVtoRGB(double hue, double saturation, double value)
        {
            // Calculate the hue sextant and fractional part
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            // Scale the value to the range [0, 255]
            value = value * 255;

            // Calculate intermediate values used in the RGB conversion
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            // Switch based on the hue sextant to determine the RGB values
            switch (hi)
            {
                case 0:
                    // Red is at its maximum, Green varies, Blue is at its minimum
                    return (v, t, p);
                case 1:
                    // Red varies, Green is at its maximum, Blue is at its minimum
                    return (q, v, p);
                case 2:
                    // Red is at its minimum, Green is at its maximum, Blue varies
                    return (p, v, t);
                case 3:
                    // Red is at its minimum, Green varies, Blue is at its maximum
                    return (p, q, v);
                case 4:
                    // Red varies, Green is at its minimum, Blue is at its maximum
                    return (t, p, v);
                default:
                    // Red is at its maximum, Green is at its minimum, Blue varies
                    return (v, p, q);
            }
        }
    }
}
