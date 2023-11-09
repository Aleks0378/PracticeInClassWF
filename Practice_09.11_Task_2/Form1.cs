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

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(new Pen(Brushes.Black, 6), 250, 100, 200, 200);
            //Секундная стрелка:
            g.DrawLine(new Pen(Brushes.Black, 2), 350, 200, (float)(350 + 100 * Math.Cos((Math.PI*(DateTime.Now.Second * 6-90))/180)), (float)(200 + 100 * Math.Sin((Math.PI*(DateTime.Now.Second * 6 - 90))/180)));
            ////Минутная стрелка:
            g.DrawLine(new Pen(Brushes.Black, 4), 350, 200, (float)(350 + 100 * Math.Cos((Math.PI*(DateTime.Now.Minute * 6-90))/180)), (float)(200 + 100 * Math.Sin((Math.PI*(DateTime.Now.Minute * 6 - 90))/180)));
            ////Часовая стрелка:
            g.DrawLine(new Pen(Brushes.Black, 6), 350, 200, (float)(350 + 100 * Math.Cos((Math.PI * (DateTime.Now.Hour * 30-90)) / 180)), (float)(200 + 100 * Math.Sin((Math.PI * (DateTime.Now.Hour * 30 - 90)) / 180)));
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            this.Refresh();
        }

    }
}