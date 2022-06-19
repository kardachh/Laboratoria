using System;
using System.Windows.Forms;

namespace Laboratoria.forms
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            chart.Series[0].Points.Clear();
            foreach (service _service in Program.LaboratoriaDB.service)
            {
                chart.Series[0].Points.AddXY(_service.Service,_service.Price);
            }
        }
    }
}
