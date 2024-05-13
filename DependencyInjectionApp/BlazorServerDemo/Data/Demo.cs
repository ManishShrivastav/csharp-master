namespace BlazorServerDemo.Data
{
    public class Demo : IDemo, ILocalDemo, IDisposable
    {
        private readonly ILogger<Demo> _log;

        public DateTime StartupTime { get; init; }

        public Demo(ILogger<Demo> log)
        {
            StartupTime = DateTime.Now;
            this._log = log;
        }

        public void Dispose()
        {
            _log.LogError($"Demo ({StartupTime.ToString("hh:mm:ss ffffff")}) was disposed of");
        }
    }
}
