﻿using System;
using System.Reflection;
using Autofac;
using SOLIDFizzBuzz;
using DividendRules;

namespace WindowsFormsUI
{
    public static class Dependencies
    {
        public static ContainerBuilder CreateContainerBuilder()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainForm>().AsSelf();

            builder.RegisterType<DividendProcessor>().As<IDividendProcessor>();

            builder.Register<Func<int, string, IDividendRule>>(c => (divisor, message) => new DividendRule(divisor, message));

            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(DividendRule)))
                .Where(t => typeof(IDividendRule).IsAssignableFrom(t))
                .AsImplementedInterfaces();

            return builder;
        }
    }
}
