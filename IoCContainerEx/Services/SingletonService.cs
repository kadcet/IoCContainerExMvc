namespace IoCContainerEx.Services
{
    public class SingletonService : ISingletonService
    {
        public Guid Id { get; set; }=Guid.NewGuid();
    }
}
