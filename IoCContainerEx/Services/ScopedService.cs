namespace IoCContainerEx.Services
{
    public class ScopedService : IScopedService
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
