using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratoria.forms
{
    public partial class FormPane : Form
    {
        public FormPane()
        {
            InitializeComponent();
        }

        private void userControl1_Load(object sender, EventArgs e)
        {

        }

        private void FormPane_Load(object sender, EventArgs e)
        {
            //foreach (user _user in Program.LaboratoriaDB.user)
            //{
            //    flowLayoutPanel1.Controls.Add(new UserControl(_user));
            //}

            for (int i = 0; i < 10; i++)
            {
                flowLayoutPanel1.Controls.Add(new UserControl());
            }
        }
    }
}
