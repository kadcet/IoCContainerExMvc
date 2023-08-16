namespace IoCContainerEx.Services
{
    public class OperationService
    {
        public OperationService(ISingletonService singletonService,IScopedService scopedService,ITransientService transientService)
        {
            SingletonService = singletonService;
            ScopedService = scopedService;
            TransientService = transientService;
        }
        public ISingletonService SingletonService { get; set; }

        public IScopedService ScopedService { get; set; }

        public ITransientService TransientService { get; set; }
    }
}
