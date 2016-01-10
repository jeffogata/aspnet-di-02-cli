namespace AspNetDependencyInjectionCli
{
    using StructureMap;
    
    public class MyServiceRegistry : Registry
    {
        // see http://structuremap.github.io/object-lifecycle/supported-lifecycles/
        public MyServiceRegistry()
        {
            For<ISingletonService>().Singleton().Use<MyService>();
            For<IScopedService>().ContainerScoped().Use<MyService>();
            For<ITransientService>().AlwaysUnique().Use<MyService>();
        }
    }
}