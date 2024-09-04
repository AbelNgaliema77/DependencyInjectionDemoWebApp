namespace DependencyInjectionDemoWebApp.Services
{

    public interface IMyService
    {
        string MyMethod();
    }
    public class MyService : IMyService
    {
        private readonly IScopedService _scopedService;

        public MyService(IScopedService scopedService)
        {
            _scopedService = scopedService;
        }

        public string MyMethod()
        {
            return "Test Abel";
        }
    }
}
