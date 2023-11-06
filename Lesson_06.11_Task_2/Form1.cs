//—оздать строку состо€ни€. –азместить ее в левой части формы.
//ƒобавить на строку вывод текущего времени и ProgressBar.
//ѕо нажатию на кнопку размещенной на форме, ProgressBar заполн€етс€ за 10 секунд и выводитс€ сообщение.


using System.Windows.Forms;

namespace Lesson_06._11_Task_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            Button button = new Button()
            {
                Text = "Start",
                Width = 120,
                Height = 60,
                Location = new Point(20, 10)
            };

            this.Controls.Add(button);

            button.Click += Button_Click;
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = 500;
            toolStripProgressBar1.Step = 1;
            for (int i = 0; i <= 500; i++)
            {
                toolStripProgressBar1.PerformStep();
                /*this.Update(); */
                Thread.Sleep(10);
            }
            MessageBox.Show("All has been done!");

        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            timeToolStripLabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}