using System.Globalization;
using System.Numerics;
using System.Xml.Serialization;
namespace VisualBrot
{
    public partial class VisualBrot : Form
    {
        private readonly int Width;
        private readonly int Height;
        private readonly Pen Pencil = new Pen(Color.Red);
        private Graphics View;
        private Bitmap Bmp;

        private readonly Color[] Colors = { Color.DarkBlue, Color.Black, Color.Gold, Color.BlueViolet };

        public VisualBrot()
        {
            InitializeComponent();
            View = panel1.CreateGraphics();
            Width = panel1.Width;
            Height = panel1.Height;

            Bmp = new Bitmap(Width, Height);




            panel1.Paint += panel1_Paint;

        }

        private void MBrot(int max, double xmin, double xmax, double ymin, double ymax)
        {
            double realComponent;
            double imaginaryComponent;

            int iterationCount;

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {

                    // Convert the imaginary plane mappings to form coords.
                    realComponent = xmin + (x / (double)Width) * (xmax - xmin);
                    imaginaryComponent = ymax - (y / (double)Height) * (ymax - ymin);

                    var c = new Complex(realComponent, imaginaryComponent);
                    var z = c;

                    iterationCount = 0;

                    while (Complex.Abs(z) <= 2 && iterationCount < max)
                    {
                        int p = 2;
                        z = Complex.Pow(z,p) + c;

                        realComponent = z.Real;
                        imaginaryComponent = z.Imaginary;

                        iterationCount++;
                    }

                    int choice = 0;
                    if (iterationCount == max)
                    {
                        choice = 3;
                    }
                    else
                    {
                        choice = (iterationCount * Colors.Length) / max;
                    }

                    Bmp.SetPixel(x, y, Colors[choice]);

                }

                panel1.Invalidate(); // redraw
            }

            //Save image to disk.
            Bmp.Save("VisualBrot result.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Bmp, 0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            panel1.Scale(new SizeF(1.1f, 1.1f));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int level = trackBar1.Value;
            
            MBrot(level * 10, -1.5, 1, -1.5, 1);
            panel1.CreateGraphics().DrawImage(Bmp, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
           
        }
    }
}
