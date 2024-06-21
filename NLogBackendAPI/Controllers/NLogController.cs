using LoggingService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NLogBackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NLogController : ControllerBase
    {
        private readonly ILoggerManager _logger;

        public NLogController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfor("This is info message from the controller.");
            _logger.LogDebug("This is debug message from the controller.");
            _logger.LogWarn("This is warn message from the controller.");
            _logger.LogError("This is error message from the controller.");
            return new string[] { "Value 1", "Value 2", "Vlaue 3", "Value 4" };
        }
    }
}
