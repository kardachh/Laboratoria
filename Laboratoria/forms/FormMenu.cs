using System;
using System.Windows.Forms;

namespace Laboratoria.forms
{
    public partial class FormMenu : Form
    {
        private Form backForm;
        public FormMenu(Form backForm)
        {
            InitializeComponent();
            this.backForm = backForm;
            labelHello.Text = $"Добро пожаловать, {CurrentUser.userData.surname} {CurrentUser.userData.name}";
            labelRole.Text = CurrentUser.userData.typeUser.name;
            if (CurrentUser.userData.image != null) pictureBoxPhoto.Load($"../../assets/{CurrentUser.userData.image}");
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            backForm.Show();
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = ProjectColors.focusColor;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = ProjectColors.secondColor;
        }

        private void buttonPatients_Click(object sender, EventArgs e)
        {
            FormPatients formPatients = new FormPatients(this);
            formPatients.Show();
            Hide();
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
