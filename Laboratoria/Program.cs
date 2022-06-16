using System;
using System.Windows.Forms;

namespace Laboratoria
{
    internal static class Program
    {
        public static LaboratoriyaEntities LaboratoriaDB = new LaboratoriyaEntities();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAuthorization());
        }
    }
}
