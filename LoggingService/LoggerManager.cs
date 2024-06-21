using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace LoggingService
{
    public class LoggerManager : ILoggerManager
    {
        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string message) => _logger.Debug(message);
        public void LogError(string message) => _logger.Error(message);
        public void LogInfor(string message) => _logger.Info(message);
        public void LogWarn(string message) => _logger.Warn(message);
    }
}
