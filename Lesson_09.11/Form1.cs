namespace Lesson_09._11
{
    public partial class Form1 : Form
    {
        private Cinema cinema;
        private int sum = 0, count = 0;
        public Form1()
        {
            InitializeComponent();
            cinema = new Cinema();
            this.Width = cinema.FormWidth;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = pictureBox1.CreateGraphics();
                var result = cinema.Draw(g, e.X, e.Y);
                if (result > 0)
                {

                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            cinema.Draw(e.Graphics);
        }
    }
}