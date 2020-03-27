using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace testNetCore2.Controllers
{
    public class TestController : Controller
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [Route("/Test")]
        [HttpPost]
        public IActionResult Index([FromBody] UserModel userModel)
        {
            _logger.LogInformation($" net core 2 -- {userModel}");

            return Ok();
        }
    }
    
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }
    }
}