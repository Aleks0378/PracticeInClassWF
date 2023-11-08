



namespace Lesson_08._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Task_1: Нарисовать круг, прямоугольник и треугольник, используя карандаш:

            //Pen pen = new Pen(Brushes.Aquamarine, 5);
            //pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            //g.DrawEllipse(pen, 50, 100, 170, 170);
            //g.DrawRectangle(new Pen(Brushes.Black, 3), 100, 50, 100, 100);
            //g.DrawPolygon(new Pen(Brushes.Red, 5), new Point[] { new Point(150, 200), new Point(250, 200), new Point(200, 300) });
            //g.Dispose();

            //Task_2: Нарисовать круг, квадрат и треугольник, используя полную заливку цветом:

            Brush brush = new SolidBrush(Color.DarkBlue);
            Point[] points =
            {
                new Point(150,50),
                new Point(250,175),
                new Point(150,300)
            };
            g.FillRectangle(brush, 500,100,100,100);
            g.FillEllipse(new SolidBrush(Color.DarkCyan), 300, 70, 170, 170);
            g.FillPolygon(new SolidBrush(Color.Red), points);
            g.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //Graphics g = Graphics.FromImage(pictureBox1.Image);
            //Brush brush = new SolidBrush(Color.DarkBlue);
            //g.FillRectangle(brush, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
        }
    }
}