namespace AspNetDependencyInjectionCli
{
    using System;
    using System.Threading;
    
    public class MyService : ISingletonService, IScopedService, ITransientService
    {
        private static int Counter; 
        
        public MyService(IOtherService otherService)
        {
            OtherService = otherService;
        }
        
        public int Id { get; } = Interlocked.Increment(ref Counter);

        public DateTime Created { get; } = DateTime.Now;
        
        public IOtherService OtherService { get; }
    }
}