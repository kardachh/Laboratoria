using System;
using System.Windows.Forms;

namespace Laboratoria
{
    public struct User
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int type { get; set; }
        public string photo { get; set; }
    }
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        public static User user = new User();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (users _user in Program.LaboratoriaDB.users)
                {
                    if (textBoxLogin.Text == _user.login && textBoxPassword.Text == _user.password)
                    {
                        key = true;
                        user.id = _user.id;
                        user.login = _user.login;
                        user.password = _user.password;
                        user.firstName = _user.firstName;
                        user.lastName = _user.lastName;
                        user.type = _user.type;
                        user.photo = _user.photo;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //FormMenu menu = new FormMenu(this);
                    //menu.Show();
                    //Hide();
                    //textBoxPassword.Text = "";
                    MessageBox.Show("данные найдены!", "Всё ок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (var prop in typeof(User).GetProperties())
                    {
                        Console.WriteLine($"{prop.Name} {prop.GetValue(user)}");
                    }
                }
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }
    }
}
