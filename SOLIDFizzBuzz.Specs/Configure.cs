namespace SOLIDFizzBuzz.Specs
{
    using Autofac;
    using SpecFlow.Autofac;
    using WindowsFormsUI;

    public class Configure
    {
        [ScenarioDependencies]
        public static ContainerBuilder CreateContainerBuilder()
        {
            var builder = Dependencies.CreateContainerBuilder();

            builder.RegisterType<FizzBuzzSteps>().AsSelf();

            return builder;
        }
    }
}
