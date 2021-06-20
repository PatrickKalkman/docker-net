using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace health_check.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
      private readonly ILogger<HealthCheckController> _logger;

      public HealthCheckController(ILogger<HealthCheckController> logger)
      {
          _logger = logger;
      }

      [HttpGet]
      public IActionResult HealthCheck()
      {
          _logger.LogInformation("Performing health check");
          // Check the health of your application
          // e.g. perform query on the database and map the result
          return Ok();
      }
    }
}
