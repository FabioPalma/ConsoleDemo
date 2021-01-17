using ConsoleDemoApp.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConsoleDemoApp
{
    public class GreetingServices : IGreetingService
    {
        private readonly ILogger<GreetingServices> _log;
        private readonly IConfiguration _config;

        public GreetingServices(ILogger<GreetingServices> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }   

        public void Run()
        {
            _log.LogInformation("Run Method in Environment: {environment}", _config.GetValue<string>("Environment"));

            for (int i = 0; i < _config.GetValue<int>("LoopTime"); i++)
            {
                _log.LogInformation("Run number {runNumber}", i);
            }

        }
    }
}
