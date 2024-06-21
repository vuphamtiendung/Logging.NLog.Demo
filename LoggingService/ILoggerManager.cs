using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingService
{
    public interface ILoggerManager
    {
        void LogInfor(string message);
        void LogDebug(string message);  
        void LogError(string message);
        void LogWarn(string message);
    }
}
