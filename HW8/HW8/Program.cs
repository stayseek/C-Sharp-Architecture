using System;
using System.Windows.Forms;
using HW8.Models;
using HW8.Controllers;

namespace HW8
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MVCForm form = new MVCForm();
            IModel model = new ListModel();
            IController controller = new FormController(model, form);

            Application.Run(form);
        }
    }
}
