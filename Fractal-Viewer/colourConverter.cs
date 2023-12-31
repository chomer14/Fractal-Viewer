using System;

namespace Fractal_Viewer
{
    public class HSVtoRGBConverter
    {
        public static (int Red, int Green, int Blue) HSVtoRGB(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            switch (hi)
            {
                case 0:
                    return (v, t, p);
                case 1:
                    return (q, v, p);
                case 2:
                    return (p, v, t);
                case 3:
                    return (p, q, v);
                case 4:
                    return (t, p, v);
                default:
                    return (v, p, q);
            }
        }
    }
}
