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

            Bitmap b = new Bitmap(fractalPbx.Width, fractalPbx.Height);

            Color c = Color.FromArgb(0, 255, 0);

            for (int y = 0; y < fractalPbx.Height; y++)
            {
                for (int x = 0; x < fractalPbx.Width; x++)
                {
                    b.SetPixel(x, y, c);
                }
            }

            fractalPbx.Image = b;
        }
    }
}
