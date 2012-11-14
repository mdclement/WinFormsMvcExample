using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvcPattern
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var model = new TodoListModel();
            var controller = new ListController(model);
            var listDisplay = new ListDisplayForm();
            model.ModelChanged += listDisplay.ModelChanged;
            listDisplay.Show();
            var listDisplay2 = new ListDisplayForm();
            model.ModelChanged += listDisplay2.ModelChanged;
            listDisplay2.Show();
            Application.Run(new AddToListForm(controller));
        }
    }
}
