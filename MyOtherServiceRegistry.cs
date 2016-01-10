namespace AspNetDependencyInjectionCli
{
    using StructureMap;
    
    public class MyOtherServiceRegistry : Registry
    {
        public MyOtherServiceRegistry()
        {
            For<IOtherService>().ContainerScoped().Use<MyOtherService>();
        }
    }
}