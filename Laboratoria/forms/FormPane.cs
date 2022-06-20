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

        private static Timer aTimer;
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

        private void tick(Object myObject, EventArgs myEventArgs)
        {
            timer.Stop();
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            timer.Start();
            timer.Tick += new EventHandler(tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
