using System;
using System.Linq;
using System.Reflection;
using Autofac;
using SOLIDFizzBuzz;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var scope = BuildContainer().BeginLifetimeScope())
            {
                var processor = scope.Resolve<IDividendProcessor>();
                Enumerable.Range(1, 100).ToList().ForEach(i => Console.WriteLine(processor.Process(i)));
            }

            Console.ReadKey(true);
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DividendProcessor>().As<IDividendProcessor>();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => typeof(IDividendRule).IsAssignableFrom(t))
                .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
