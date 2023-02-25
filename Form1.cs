namespace _3D__true_real_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Create image on pictureBox
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }


        // angle
        int alfa = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // To make the cube spin
            alfa++;


            // Initialize objects
            int a90 = alfa + 90;
            int a180 = alfa + 180;
            int a270 = alfa + 270;


            // It's a size of cube
            int r1 = 130;
            int r2 = 280;


            Graphics g = Graphics.FromImage(pictureBox1.Image);
            Pen p = new Pen(Color.DarkCyan, 1f);
            SolidBrush b = new SolidBrush(Color.White);
            g.FillRectangle(b, 0, 0, pictureBox1.Width, pictureBox1.Height);


            // Create cordinates
            int x0 = (int)(r1 * Math.Sin(alfa * 2 * Math.PI / 360)) + pictureBox1.Width / 2;
            int y0 = (int)(r2 * Math.Cos(alfa * 2 * Math.PI / 360)) + pictureBox1.Height / 2;
            int x1 = (int)(r1 * Math.Sin(a90 * 2 * Math.PI / 360)) + pictureBox1.Width / 2;
            int y1 = (int)(r2 * Math.Cos(a90 * 2 * Math.PI / 360)) + pictureBox1.Height / 2;
            int x2 = (int)(r1 * Math.Sin(a180 * 2 * Math.PI / 360)) + pictureBox1.Width / 2;
            int y2 = (int)(r2 * Math.Cos(a180 * 2 * Math.PI / 360)) + pictureBox1.Height / 2;
            int x3 = (int)(r1 * Math.Sin(a270 * 2 * Math.PI / 360)) + pictureBox1.Width / 2;
            int y3 = (int)(r2 * Math.Cos(a270 * 2 * Math.PI / 360)) + pictureBox1.Height / 2;

            // Draw first side
            g.DrawLine(p, x0 - 150, y0, x1 - 150, y1);
            g.DrawLine(p, x1 - 150, y1, x2 - 150, y2);
            g.DrawLine(p, x2 - 150, y2, x3 - 150, y3);
            g.DrawLine(p, x3 - 150, y3, x0 - 150, y0);


            // Draw second side
            g.DrawLine(p, x0 + 150, y0, x1 + 150, y1);
            g.DrawLine(p, x1 + 150, y1, x2 + 150, y2);
            g.DrawLine(p, x2 + 150, y2, x3 + 150, y3);
            g.DrawLine(p, x3 + 150, y3, x0 + 150, y0);


            // Draw third and fourth sides together
            g.DrawLine(p, x0 - 150, y0, x0 + 150, y0);
            g.DrawLine(p, x1 - 150, y1, x1 + 150, y1);
            g.DrawLine(p, x2 - 150, y2, x2 + 150, y2);
            g.DrawLine(p, x3 - 150, y3, x3 + 150, y3);

            // Refresh pictureBox
            pictureBox1.Invalidate();
        }
    }
}