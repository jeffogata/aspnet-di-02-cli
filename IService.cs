namespace AspNetDependencyInjectionCli
{
    using System;
    
    public interface IService
    {
        int Id { get; }

        DateTime Created { get; }
        
        IOtherService OtherService { get; }
    }
}