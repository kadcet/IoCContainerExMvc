namespace IoCContainerEx.Services
{
    public class TransientService : ITransientService
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
