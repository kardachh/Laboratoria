using System;
using System.Windows.Forms;

namespace Laboratoria
{
    public partial class UserControl : System.Windows.Forms.UserControl
    {
        public UserControl(user _user)
        {
            InitializeComponent();
            label1.Text = $"{_user.surname} {_user.name}";
        }
    }
}
