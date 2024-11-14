
using Microsoft.AspNetCore.Mvc;

namespace ChatApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly ILogger<MessageController> _logger;
        private readonly IServiceProvider _serviceProvider;

        public MessageController(ILogger<MessageController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        [Route("")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            
                return Ok("response");

        }

    }
}