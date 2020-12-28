using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validatores;

namespace TehnologyProgramingForms
{
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //docIDValidator validator = new docIDValidator();
            //var res = validator.Validate("12345hhgfh6");
            //if (res.Valid)
            //{
            //    MessageBox.Show("ok");
            //}
            //else
            //{
            //    MessageBox.Show(res.Errors.First());
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RoleChoise());
        }
    }
}
