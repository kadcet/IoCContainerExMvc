namespace IoCContainerEx.Services
{
    public interface IOperationService
    {
        Guid Id { get; set; }
    }

    public interface ISingletonService : IOperationService
    { }

    public interface IScopedService : IOperationService
    { }

    public interface ITransientService : IOperationService
    { }
}
