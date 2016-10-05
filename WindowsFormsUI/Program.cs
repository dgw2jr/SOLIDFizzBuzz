using System;
using System.Reflection;
using System.Windows.Forms;
using Autofac;
using SOLIDFizzBuzz;
using WindowsFormsUI.DividendRules;

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

            using (var scope = BuildContainer().BeginLifetimeScope())
            {
                var form = scope.Resolve<MainForm>();
                Application.Run(form);
            }
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainForm>().AsSelf();

            builder.RegisterType<DividendProcessor>().As<IDividendProcessor>();

            builder.Register<Func<int, string, IDividendRule>>(c => (divisor, message) => new DividendRule(divisor, message));

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => typeof(IDividendRule).IsAssignableFrom(t))
                .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
