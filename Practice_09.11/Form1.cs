

/*Создайте приложение Windows Forms, 
 * которое будет рисовать случайные окружности разного цвета и размера на форме при щелчке мыши. 
 * Каждый раз, когда пользователь щелкает мышью на форме, будет рисоваться новая окружность случайного цвета и размера.
 * */

using System.Windows.Forms;

namespace Practice_09._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                Random rand = new Random();
                Brush[] brush = new Brush[]
                {
                    new SolidBrush(Color.Red),
                    new SolidBrush(Color.Green),
                    new SolidBrush(Color.Blue),
                    new SolidBrush(Color.Magenta),
                    new SolidBrush(Color.Yellow),
                    new SolidBrush(Color.Blue),
                    new SolidBrush(Color.Aqua),
                    new SolidBrush(Color.Aquamarine),
                    new SolidBrush(Color.Black)
                };
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(new Pen(brush[rand.Next(0,8)]), e.X, e.Y, rand.Next(0, 500), rand.Next(0, 500));
               
            }
        }
    }
}