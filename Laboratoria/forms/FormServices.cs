using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratoria.forms
{
    public partial class FormServices : Form
    {
        private Form backForm;
        
        private void ShowServices()
        {
            listViewServices.Items.Clear();
            foreach (service _service in Program.LaboratoriaDB.service)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    _service.Code.ToString(),
                    _service.Service,
                    _service.Price.ToString(),
                    _service.Deadline.ToString(),
                });
                item.Tag = _service;
                if (_service.Price < 200)
                    item.BackColor = Color.Gray;
                listViewServices.Items.Add(item);
            }
            listViewServices.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public FormServices(Form backForm)
        {
            InitializeComponent();
            ShowServices();
            this.backForm = backForm;
        }

        private void FormServices_FormClosed(object sender, FormClosedEventArgs e)
        {
            backForm.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Utilities.CheckNonEmptyFields(groupBoxFields))
            {
                service _service = new service();
                _service.Code = Convert.ToInt32(textBoxCode.Text);
                _service.Service = textBoxName.Text;
                _service.Price = Convert.ToDouble(textBoxPrice.Text);
                _service.Deadline = Convert.ToInt32(textBoxDeadline.Text);
                Program.LaboratoriaDB.service.Add(_service);
                Program.LaboratoriaDB.SaveChanges();
                ShowServices();
            }
            else {
                MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewServices.SelectedItems.Count == 1)
            {
                if (Utilities.CheckNonEmptyFields(groupBoxFields))
                {
                    service _service = listViewServices.SelectedItems[0].Tag as service;
                    _service.Code = Convert.ToInt32(textBoxCode.Text);
                    _service.Service = textBoxName.Text;
                    _service.Price = Convert.ToDouble(textBoxPrice.Text);
                    _service.Deadline = Convert.ToInt32(textBoxDeadline.Text);
                    Program.LaboratoriaDB.SaveChanges();
                    ShowServices();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewServices.SelectedItems.Count == 1)
            {
                try
                {
                    service _service = listViewServices.SelectedItems[0].Tag as service;
                    Program.LaboratoriaDB.service.Remove(_service);
                    Program.LaboratoriaDB.SaveChanges();
                    ShowServices();
                }
                catch {
                    MessageBox.Show("Невозможно удалить, так как запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listViewServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewServices.SelectedItems.Count == 1)
            {
                service _service = listViewServices.SelectedItems[0].Tag as service;
                textBoxCode.Text = _service.Code.ToString();
                textBoxName.Text = _service.Service;
                textBoxPrice.Text = _service.Price.ToString();
                textBoxDeadline.Text = _service.Deadline.ToString();
            }
            else Utilities.ClearFields(groupBoxFields);
        }
    }
}
