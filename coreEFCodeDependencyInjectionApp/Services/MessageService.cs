namespace coreEFCodeDependencyInjectionApp.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello, from Dependency Injection!";
        }
    }
}
