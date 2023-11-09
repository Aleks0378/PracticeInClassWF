//Разработайте приложение Windows Forms, которое будет отображать часы на клиентской области.
//Часы должны иметь стрелки: часы, минуты, секунды.


namespace Practice_09._11_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;

            // Graphics g = this.CreateGraphics();
            //g.DrawEllipse(new Pen(Brushes.Black, 2), 250, 100, 200, 200);
            ////Секундная стрелка:
            //g.DrawLine(new Pen(Brushes.Black, 3), 350, 200, 350 + 100 * (int)Math.Cos(90 - DateTime.Now.Second * 6), 200 + 100 * (int)Math.Sin(90 - DateTime.Now.Second * 6));

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(new Pen(Brushes.Black, 6), 250, 100, 200, 200);
            //Секундная стрелка:
            g.DrawLine(new Pen(Brushes.Black, 2), 350, 200, (int)(350 + 100 * Math.Cos(90-DateTime.Now.Second * 6)), (int)(200 + 100 * Math.Sin(90-DateTime.Now.Second * 6)));
            //Минутная стрелка:
            g.DrawLine(new Pen(Brushes.Black, 3), 350, 200, (int)(350 + 100 * Math.Cos(90 - DateTime.Now.Minute * 6)), (int)(200 + 100 * Math.Sin(90 - DateTime.Now.Minute * 6)));
            //Часовая стрелка:
            g.DrawLine(new Pen(Brushes.Black, 5), 350, 200, 350 + (int)(100 * Math.Cos(90 - DateTime.Now.Hour * 30)), 200 + (int)(100 * Math.Sin(90 - DateTime.Now.Hour * 30)));
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            this.Refresh();
        }

        //private void ClearColor(object? sender, PaintEventArgs e)
        //{
        //    //Graphics g = e.Graphics;
        //    e.Graphics.Clear(BackColor);
        //}
    }
}