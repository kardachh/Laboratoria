using Laboratoria.forms;
using System;
using System.Windows.Forms;

namespace Laboratoria
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (user _user in Program.LaboratoriaDB.user)
                {
                    if (textBoxLogin.Text == _user.login && textBoxPassword.Text == _user.password)
                    {
                        key = true;
                        CurrentUser.userData.id = _user.id;
                        CurrentUser.userData.login = _user.login;
                        CurrentUser.userData.password = _user.password;
                        CurrentUser.userData.name = _user.name;
                        CurrentUser.userData.surname = _user.surname;
                        CurrentUser.userData.id_type = _user.id_type;
                        CurrentUser.userData.image = _user.image;
                        CurrentUser.userData.typeUser = _user.typeUser;
                        CurrentUser.userData.order = _user.order;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FormMenu menu = new FormMenu(this);
                    menu.Show();
                    Hide();
                    textBoxPassword.Text = "";
                    
                }
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = ProjectColors.secondColor;
        }

        private void buttonLogin_MouseMove(object sender, MouseEventArgs e)
        {
            buttonLogin.BackColor = ProjectColors.focusColor;
        }

        private void FormAuthorization_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonLogin.PerformClick();
        }
    }
}
