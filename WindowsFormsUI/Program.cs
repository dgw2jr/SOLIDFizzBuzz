using System;
using System.Windows.Forms;
using Autofac;

namespace WindowsFormsUI
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

            using (var scope = Dependencies.CreateContainerBuilder().Build().BeginLifetimeScope())
            {
                var form = scope.Resolve<MainForm>();
                Application.Run(form);
            }
        }
    }
}
