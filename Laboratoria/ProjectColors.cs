using System.Drawing;
using System.Windows.Forms;

namespace Laboratoria
{
    internal class ProjectColors
    {
        public static Color backgroundColor = Color.FromArgb(255, 255, 255);
        public static Color secondColor = Color.FromArgb(118, 227, 131);
        public static Color focusColor = Color.FromArgb(73, 140, 81);

        public static void button_MouseMove(object sender)
        {
            (sender as Button).BackColor = secondColor;
        }

        public static void button_MouseLeave(object sender)
        {
            (sender as Button).BackColor = focusColor;
        }
    }
}
