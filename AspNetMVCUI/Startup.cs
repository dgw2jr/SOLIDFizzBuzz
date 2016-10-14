using Microsoft.Owin;
using Owin;
using Autofac;
using SOLIDFizzBuzz;
using DividendRules;
using System.Reflection;

[assembly: OwinStartup(typeof(AspNetMVCUI.Startup))]
namespace AspNetMVCUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.UseAutofacMiddleware(Configure());
        }

        private IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DividendProcessor>().AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(DividendRule)))
                .Where(t => typeof(IDividendRule).IsAssignableFrom(t))
                .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
