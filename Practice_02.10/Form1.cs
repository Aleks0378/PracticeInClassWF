//����������� �������� ������� ������ �� ������ �����, �� ������ �����.
//�� ������ �����, ������� �������� ������� ������ � label.

using Practice_02._10.Models;

namespace Practice_02._10
{
    public partial class Form1 : Form
    {
        public List<Product> Products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            Form2.Owner = this;
            Form2.Label1_text = listBox1.SelectedItem as string;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Products.Add(new Product(1,"Apple","������"));
            listBox1.Items.Add(Products[0].ToString());
        }
    }
}