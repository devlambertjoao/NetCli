using System;
using Lambert.Domain.Arguments.Services;
using Lambert.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lambert.Application.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CarController : ControllerBase
  {
    private readonly ILogger<CarController> _logger;
		private readonly ICarService _carService;

    public CarController(ILogger<CarController> logger, ICarService carService)
    {
        _logger = logger;
				_carService = carService;
    }

    [HttpPost]
    public ActionResult<CarSaveResponse> Save([FromBody] CarSaveRequest request)
    {
			try
			{
				return Ok(_carService.Save(request));
			}
			catch (Exception e)
			{
				_logger.LogError(e.Message);
				return BadRequest(e.Message);	
			}
    }
  }
}
