using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using DividendRules;
using SOLIDFizzBuzz;

namespace AspNetMVCUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DependencyResolver.SetResolver(new AutofacDependencyResolver(Configure()));
        }

        private IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DividendProcessor>().AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(DividendRule)))
                .Where(t => typeof(IDividendRule).IsAssignableFrom(t))
                .AsImplementedInterfaces();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            return builder.Build();
        }
    }
}
