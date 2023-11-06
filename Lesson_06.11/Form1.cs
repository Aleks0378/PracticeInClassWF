
//—оздать меню на 5 пунктов, 2 из которых сделать дочерними.
//—оздание и добавление меню, реализовать через код формы.
//ƒобавить обработчики по нажатию на пункты меню, при нажати€ выводить сообщение о том, какой пункт был выбран.

namespace Lesson_06._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolStripMenuItem fileItem = new ToolStripMenuItem("File");
            ToolStripMenuItem editItem = new ToolStripMenuItem("Edit");
            ToolStripMenuItem openItem = new ToolStripMenuItem("Open");
            ToolStripMenuItem saveasItem = new ToolStripMenuItem("SaveAs");
            ToolStripMenuItem printItem = new ToolStripMenuItem("Print");

            menuStrip1.Items.Add(fileItem);
            fileItem.Click += FileItem_Click;
            menuStrip1.Items.Add(editItem);
            editItem.Click += EditItem_Click;
            menuStrip1.Items.Add(openItem);
            openItem.Click += OpenItem_Click;
            fileItem.DropDownItems.Add(saveasItem);
            saveasItem.Click += SaveasItem_Click;
            fileItem.DropDownItems.Add(printItem);
            printItem.Click += PrintItem_Click;
        }

        private void PrintItem_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Print clicked!");
        }

        private void SaveasItem_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("SaveAs clicked!");
        }

        private void OpenItem_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Open clicked!");
        }

        private void EditItem_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Edit clicked!");
        }

        private void FileItem_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("File clicked!");
        }
    }
}