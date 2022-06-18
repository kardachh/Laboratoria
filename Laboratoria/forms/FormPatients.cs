using System;
using System.Windows.Forms;

namespace Laboratoria.forms
{
    public partial class FormPatients : Form
    {
        private Form backForm;
        private void ShowPatients()
        {
            listViewPatients.Items.Clear();
            foreach (patient patient in Program.LaboratoriaDB.patient)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    patient.id.ToString(),
                    patient.name,
                    patient.surname,
                    patient.date.ToString("MM/dd/yyyy"),
                    patient.phone_number,
                    patient.email,
                });
                item.Tag = patient;
                listViewPatients.Items.Add(item);
            }
            listViewPatients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormPatients(Form backForm)
        {
            InitializeComponent();
            ShowPatients();
            this.backForm = backForm;
            if (CurrentUser.userData.typeUser.name=="Администратор")
            {
                Utilities.DisableFields(groupBoxFields);
                Utilities.DisableFields(groupBoxButtons);
            }
        }
        private void FormPatients_FormClosed(object sender, FormClosedEventArgs e)
        {
            backForm.Show();
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            if (Utilities.CheckNonEmptyFields(groupBoxFields))
            {
                patient _patient = new patient();
                _patient.name = textBoxName.Text;
                _patient.surname = textBoxSurname.Text;
                _patient.login = textBoxLogin.Text;
                _patient.password = textBoxPassword.Text;
                _patient.date = dateTimePickerBirthday.Value;
                _patient.pasport =maskedTextBoxPassport.Text;
                _patient.email = textBoxEmail.Text;
                _patient.phone_number = maskedTextBoxPhone.Text;
                _patient.insurance_policy = textBoxInsurance.Text;
                Program.LaboratoriaDB.patient.Add(_patient);
                Program.LaboratoriaDB.SaveChanges();
                ShowPatients();
            }
            else MessageBox.Show("Заполнены не все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonEdit_Click(object sender, System.EventArgs e)
        {
            if (listViewPatients.SelectedItems.Count == 1)
            {
                if (Utilities.CheckNonEmptyFields(groupBoxFields))
                {
                    patient _patient = listViewPatients.SelectedItems[0].Tag as patient;
                    _patient.name = textBoxName.Text;
                    _patient.surname = textBoxSurname.Text;
                    _patient.login = textBoxLogin.Text;
                    _patient.password = textBoxPassword.Text;
                    _patient.date = dateTimePickerBirthday.Value;
                    _patient.pasport = maskedTextBoxPassport.Text;
                    _patient.email = textBoxEmail.Text;
                    _patient.phone_number = maskedTextBoxPhone.Text;
                    _patient.insurance_policy = textBoxInsurance.Text;
                    Program.LaboratoriaDB.SaveChanges();
                    ShowPatients();
                }
                else MessageBox.Show("Заполнены не все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (listViewPatients.SelectedItems.Count == 1)
                {
                    patient _patient = listViewPatients.SelectedItems[0].Tag as patient;
                    Program.LaboratoriaDB.patient.Remove(_patient);
                    Program.LaboratoriaDB.SaveChanges();
                    ShowPatients();
                }
                Utilities.ClearFields(groupBoxFields);
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPatients.SelectedItems.Count == 1)
            {
                patient _patient = listViewPatients.SelectedItems[0].Tag as patient;
                textBoxName.Text = _patient.name;
                textBoxSurname.Text = _patient.surname;
                textBoxLogin.Text= _patient.login;
                textBoxPassword.Text = _patient.password;
                dateTimePickerBirthday.Value = _patient.date;
                maskedTextBoxPassport.Text = _patient.pasport;
                textBoxEmail.Text = _patient.email;
                maskedTextBoxPhone.Text = _patient.phone_number;
                textBoxInsurance.Text = _patient.insurance_policy;
            }
            else
            {
                Utilities.ClearFields(groupBoxFields);
            }
        }
    }
}
