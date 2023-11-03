//Создайте Windows Forms приложение для ведения списка контактов,
//где каждый контакт будет представлен в виде панели с использованием TableLayoutPanel.
//Это приложение позволит пользователям добавлять, редактировать и удалять контакты, а также отображать информацию о контактах.

//Реализовать пункты:

//1) Реализуйте функциональность для редактирования и добавления контактов.
//При выборе контакта на панели, пользователь сможет редактировать его информацию и сохранить изменения.

//2) Добавьте кнопку "Удалить", чтобы пользователь мог удалять контакты из списка.

//3) Используйте TableLayoutPanel для отображения информации о каждом контакте.
//Каждая панель будет содержать информацию об одном контакте, и они будут располагаться в виде сетки.

//4) Используйте Panel, для отображения формы редактирования и добавления контакта.

namespace Lesson_01._11
{
    public partial class Form1 : Form
    {
        public List<Contact> contacts = new List<Contact>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int contacts_count = contacts.Count;
            TableLayoutPanel[] tableLayoutPanel = new TableLayoutPanel[contacts_count];
            Button[] buttonDelete = new Button[contacts_count];
            Button[] buttonEdit = new Button[contacts_count];

            for (int i = 0; i < contacts.Count; i++)
            {
                buttonDelete[i] = new Button()
                {
                    Name = "Delete",
                    BackColor = Color.Red,
                };
                buttonEdit[i] = new Button()
                {
                    Name = "Delete",
                    BackColor = Color.Red,
                };
                tableLayoutPanel[i] = new TableLayoutPanel()
                {
                    BackColor = Color.Blue,
                    ColumnCount = 2,
                    RowCount = 2,
                };
                tableLayoutPanel[i].Controls.Add(new TextBox() { Text = $" Name: {contacts[i].Name} \n Surname: {contacts[i].Surname}, \n Adress: {contacts[i].Adress}" }, 0, 0);
                tableLayoutPanel[i].Controls.Add(new TextBox() { Text = $" Phone number: {contacts[i].PhoneNum}" }, 1, 0);
                tableLayoutPanel[i].Controls.Add(buttonDelete[i], 0, 1);
                tableLayoutPanel[i].Controls.Add(buttonEdit[i], 1, 1);
                tableLayoutPanel1.Controls.Add(tableLayoutPanel[i]);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}