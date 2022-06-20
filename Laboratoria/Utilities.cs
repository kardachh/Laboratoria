using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laboratoria
{
    public class Utilities
    {
        public static void ClearFields(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Clear();
                if (control is DateTimePicker)
                    (control as DateTimePicker).Value = DateTime.Today;
            }
        }

        public static void DisableFields(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
                control.Enabled=false;
        }

        /// <summary>
        /// Проверяяет заполненность полей в groupBox
        /// </summary>
        /// <param name="groupBox">GroupBox для проверки полей</param>
        /// <returns>
        /// true - заполненные поля;
        /// false - есть пустые;
        /// </returns>
        public static bool CheckNonEmptyFields(GroupBox groupBox)
        {
            bool nonempty = true;
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    if ((control as TextBox).Text == "")
                    {
                        nonempty = false;
                        break;
                    }
                       
                }
                if (control is MaskedTextBox)
                {
                    if (!(control as MaskedTextBox).MaskCompleted)
                    {
                        nonempty = false;
                        break;
                    }
                }
            }
            return nonempty;
        }

        public static float Sum(float a,float b)
        {
            return a + b;
        }

        public static void Search(string word)
        {
            List<service> services = new List<service>();
            foreach (service _service in Program.LaboratoriaDB.service)
            {
                if (_service.Service.Contains(word))
                {
                    services.Add(_service);
                }
            }
            services.Sort();
        }
    }
}
